using System.Configuration;
namespace Save_Yoour_Apps
{
    public static class Config
    {
        public static void Init()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("config.json", optional: false);
            Configuration = builder.Build();
        }
        public static IConfiguration Configuration { get; set; }
    }
}
