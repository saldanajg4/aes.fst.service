using aes.fst.service.Data;
using aes.fst.service.Data.Entities;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NodaTime;

namespace aes.fst.service.Services
{
    public class UserService : IUserService
    {
        private SalesPortalContext context;
        private ILogger<UserService> logger;
        private IClock clock;
        private IMapper mapper;
        //private ICachingService cachingService;

        public UserService(
            SalesPortalContext context,
            IMapper mapper,
            ILogger<UserService> logger,
            IClock clock
            //ICachingService cachingService,
            )
        {
            this.context = context;
            this.logger = logger;
            this.clock = clock;
            this.mapper = mapper;
            //this.cachingService = cachingService;
        }

        public async Task<User> RetrieveById(int id)
        {
            var functionName = System.Reflection.MethodBase.GetCurrentMethod().Name;

            try
            {
                this.logger.LogInformation($"{clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: Entering {functionName}");

                var user = await context.Users
                    .Include(x => x.UserProfile)
                    .FirstOrDefaultAsync(x => x.UserId == id);


                if (user == null)
                {
                    throw new ArgumentException("Couldn't load user with id: " + id);
                }

                return user;
            }
            catch (Exception ex)
            {
                this.logger.LogError($"{functionName} EXCEPTION- {clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: {ex.Message}");
                if (ex.InnerException != null)
                {
                    this.logger.LogError($"{clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: {ex.InnerException.Message}");
                }
            }
            finally
            {
                this.logger.LogInformation($"{clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: Exited {functionName}.");
            }

            return null;
        }

        public async Task<string> RetrieveName(int id)
        {
            var functionName = System.Reflection.MethodBase.GetCurrentMethod().Name;
            string name = null;

            try
            {
                this.logger.LogInformation($"{clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: Entering {functionName}");


                //var userEntity = await cachingService.GetSWPUserFromCache(id);
                var userProfile = await context.UserProfiles.FindAsync(id);


                if (userProfile != null)
                {
                    name = userProfile.FirstName + " " + userProfile.LastName;
                }
            }
            catch (Exception ex)
            {
                this.logger.LogError($"{functionName} EXCEPTION- {clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: {ex.Message}");
                if (ex.InnerException != null)
                {
                    this.logger.LogError($"{clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: {ex.InnerException.Message}");
                }
            }
            finally
            {
                this.logger.LogInformation($"{clock.GetCurrentInstant().ToDateTimeUtc().ToLocalTime()}: Exited {functionName}.");
            }

            return name;
        }

    }
}
