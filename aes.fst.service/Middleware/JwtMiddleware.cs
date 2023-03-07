using aes.fst.service.ConfigurationModels;
using aes.fst.service.Services;
using Microsoft.Extensions.Options;

namespace aes.fst.service.Middleware
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ServiceCoreSettings settings;
        private readonly ILogger<JwtMiddleware> logger;

        public JwtMiddleware(RequestDelegate next, IOptions<ServiceCoreSettings> appSettings, ILogger<JwtMiddleware> logger)
        {
            this.next = next;
            this.settings = appSettings.Value;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context, IUserService userService, IJwtService jwtService)
        {
            try
            {
                var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
                if (token != null)
                {
                    var userId = jwtService.ValidateJwtToken(token);
                    if (userId != null)
                    {
                        context.Items["User"] = await userService.RetrieveById(userId.Value);
                    }
                }
            }
            catch (Exception e)
            {
                logger.LogError(e, e.Message);
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                await context.Response.WriteAsync(e.Message);
            }
            finally
            {
                await next(context);
            }
        }
    }
}
