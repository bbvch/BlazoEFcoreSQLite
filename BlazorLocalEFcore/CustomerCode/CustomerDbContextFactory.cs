using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace BlazorLocalEFcore.CustomerCode
{
    public class CustomerDbContextFactory
    {
        private const string SqliteDbFilename = "customer.db";
        private readonly DbContextOptions<CustomerDbContext> options = null!;

        public CustomerDbContextFactory()
        {
            var connectionStringBuilder = new SqliteConnectionStringBuilder { DataSource = SqliteDbFilename };
            var connection = new SqliteConnection(connectionStringBuilder.ToString());

            options = new DbContextOptionsBuilder<CustomerDbContext>()
                .UseSqlite(connection)
                .Options;
        }

        public CustomerDbContext BuildDbContext()
        {
            return new CustomerDbContext(options);
        }
    }
}
