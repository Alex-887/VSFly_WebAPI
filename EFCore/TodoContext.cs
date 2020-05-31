using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace WebAPITuto.Models
{
    public class TodoContext : DbContext
    {

        public static string ConnectionString { get; set; } = @"Server=(localdb)\MSSQLLocalDB;Initial Catalog=WWWings_2020Step2;Integrated Security=True";



        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {



            builder.UseSqlServer(ConnectionString);

            builder.UseLazyLoadingProxies();
        }

        /*
        public TodoContext(DbContextOptions<TodoContext> options):base(options)
        {
        }
        */

        public DbSet<Flight> Flight { get; set; }

        public DbSet<Passenger> Passenger { get; set; }

       // public DbSet<Booking> Booking { get; set; }
    }
}
