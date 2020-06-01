using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Text;
using EFCore;
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

        /*
        public VsFlightContext(DbContextOptions<VsFlightContext> options):base(options)
        {
        }
        */

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //}

        public DbSet<MassageHotStone> MassageHotStone { get; set; }
        public DbSet<Flight> Flight { get; set; }

        public DbSet<Passenger> Passenger { get; set; }


        // public DbSet<Booking> Booking { get; set; }
    }
}
