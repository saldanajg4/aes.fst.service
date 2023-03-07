namespace aes.fst.service.ConfigurationModels
{
    public class ServiceCoreSettings
    {
        public string JWTSecret { get; set; }        

        public string MongoDbConnectionString { get; set; }

        public string RigDataApi { get; set; }        

        public string AesProApi { get; set; }

        public string RootAPI { get; set; }

    }
}
