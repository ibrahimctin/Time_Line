namespace Time_Line.Infrastructure
{
    public static class Extensions
    {
        public static IServiceCollection LoadInfrastructureConf(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
               options.UseSqlServer(
                   configuration.GetConnectionString("TimeLineConn")
                   ));
            return services;
        }
    }
}