using System.ComponentModel.Design;
using aes.fst.service.ConfigurationModels;
using Microsoft.Extensions.Configuration;
using NodaTime;
using AutoMapper;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using aes.fst.service.Middleware;
using aes.fst.service.Data;
using Microsoft.EntityFrameworkCore;

namespace aes.fst.service
{
    public class Startup
    {

        readonly IConfiguration Configuration;

        public Startup(IWebHostEnvironment hostingEnv)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(hostingEnv.ContentRootPath)
                .AddJsonFile($"appsettings.{hostingEnv.EnvironmentName}.json", true)
                .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IClock>(SystemClock.Instance);
            services.AddAutoMapper(typeof(MappingProfile));

            services.AddDbContext<SalesPortalContext>(options => options.UseSqlServer(BuildSalesPortalConnectionString()));

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                                    .AllowAnyMethod()
                                    .AllowAnyHeader());
            });

            var appSettingsSection = Configuration.GetSection("ServiceCore");
            var appSettings = appSettingsSection.Get<ServiceCoreSettings>();
           

            //General configurations
            services.Configure<ServiceCoreSettings>(Configuration.GetSection("ServiceCore"));

            //DI Services needed by the project
            //services.AddSingleton<AesRigFileRequestContext>();
            //services.AddSingleton<IJwtService, JwtService>();

            //services.AddScoped<IHttpService, HttpService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<IRigFileRequestSubmitService, RigFileRequestSubmitService>();
            //services.AddScoped<IRigFileRequestRetrieveService, RigFileRequestRetrieveService>();
            //services.AddScoped<IRigFileRequestFinalSubmitService, RigFileRequestFinalSubmitService>();
            //services.AddScoped<IRigFileRequestRollbackService, RigFileRequestRollbackService>();
            //services.AddScoped<IRigFileRequestNotifcationService, RigFileRequestNotifcationService>();
            //services.AddSingleton<IMessagingPublishService, RabbitPublishService>();

            services.AddControllers();
            services.AddMvc(option => option.EnableEndpointRouting = false)
                .AddNewtonsoftJson(options =>
                {
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                    options.SerializerSettings.NullValueHandling = NullValueHandling.Ignore;
                    options.SerializerSettings.Formatting = Formatting.Indented;
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    options.AllowInputFormatterExceptionMessages = true;
                });


            services.AddLogging(loggingBuilder =>
            {
                loggingBuilder.AddConfiguration(Configuration.GetSection("Logging"));
                loggingBuilder.AddConsole();
                loggingBuilder.AddDebug();
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseCors("CorsPolicy");

            app.UseMiddleware<ExceptionHandlingMiddleware>();
            app.UseMiddleware<JwtMiddleware>();

            //app.UseHangfireDashboard();
            
            app.UseMvc();

            app.UseRouting();
            app.UseAuthorization();

            //RecurringJobsSchedulerService.ScheduleRecurringJobs();
        }

        private string BuildSalesPortalConnectionString()
        {
            var dbConn = Configuration.GetConnectionString("SalesPortal");
            var dbServer = Configuration["DBSERVER"];
            var dbName = Configuration["DBNAME"];
            var dbUser = Configuration["DBUSER"];
            var dbPwd = Configuration["DBPASSWORD"];

            return string.Format(dbConn, dbName, dbServer, dbUser, dbPwd);
        }

    }
}
