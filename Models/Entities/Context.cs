using System;
using Microsoft.EntityFrameworkCore;

namespace Models.Entities
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Layout> Layouts { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<TableGroup> TableGroups { get; set; }
        public DbSet<User> Users { get; set; }        
    }
}
