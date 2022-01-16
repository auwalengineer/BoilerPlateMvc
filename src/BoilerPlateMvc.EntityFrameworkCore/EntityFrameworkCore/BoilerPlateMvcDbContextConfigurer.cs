using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BoilerPlateMvc.EntityFrameworkCore
{
    public static class BoilerPlateMvcDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<BoilerPlateMvcDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<BoilerPlateMvcDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
