using Microsoft.EntityFrameworkCore;
//using Project.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Project.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext(DbContextOptions<VehicleContext> options) : base (options)
        {
        }

        public  DbSet<VehicleMake> VehicleMakes { get; set; }
        public  DbSet<VehicleModel> VehicleModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleMake>()
                .HasMany(e => e.VehicleModels)
                .WithOne(e => e.VehicleMake)
                .HasForeignKey(e => e.MakeId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
