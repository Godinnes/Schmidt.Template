using Microsoft.Extensions.Configuration;

namespace Schmidt.Template.Common.Extensions
{
    public static class DataConnectionExtentions
    {
        public static string GetConnectionString(this IConfiguration configuration) => configuration["Database:ConnectionString"];
    }
}
