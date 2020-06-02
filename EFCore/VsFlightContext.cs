using Microsoft.EntityFrameworkCore;

namespace EFCore
{
    public class VsFlightContext : DbContext
    {

        public static string ConnectionString { get; set; } = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=WWWings_2020Step2;Integrated Security=True";



        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConnectionString);
            builder.UseLazyLoadingProxies();
        }


        public DbSet<Flight> Flight { get; set; }
        public DbSet<Passenger> Passenger { get; set; }

    }
}
