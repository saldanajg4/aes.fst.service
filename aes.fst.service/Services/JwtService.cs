using aes.fst.service.ConfigurationModels;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace aes.fst.service.Services
{
    public class JwtService : IJwtService
    {
        private readonly IOptions<ServiceCoreSettings> settings;

        public JwtService(
            IOptions<ServiceCoreSettings> settings)
        {
            this.settings = settings;
        }

        public int? ValidateJwtToken(string token)
        {
            if (token == null)
            {
                return null;
            }

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(settings.Value.JWTSecret);

            try
            {
                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                    ClockSkew = TimeSpan.Zero
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;
                var userId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value);
                return userId;
            }
            catch
            {
                return null;
            }
        }
    }
}
