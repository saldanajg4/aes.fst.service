namespace aes.fst.service.Services
{
    public interface IJwtService
    {
        public int? ValidateJwtToken(string token);
    }
}
