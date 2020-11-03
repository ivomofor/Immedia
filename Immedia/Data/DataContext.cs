using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Immedia.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Immedia.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Geocode> Geocodes { get; set; }
        public DbSet<Icon> Icons { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Response> Responses { get; set; }
        public DbSet<Venue> Venues { get; set; }
        public DbSet<Root> Roots { get; set; }
        public DbSet<Api> Apis { get; set; }
        public DbSet<RootImage> RootImages { get; set; }
        public DbSet<Hit> Hits { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RootImage>()
            .Property(b => b.ResponseData).HasConversion<string>();

        }
    }

}
