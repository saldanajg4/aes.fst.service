using aes.fst.service.Data.Entities;

namespace aes.fst.service.Services
{
    public interface IUserService
    {
        public Task<User> RetrieveById(int id);

        public Task<string> RetrieveName(int id);
    }
}
