using Airport.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Airport.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Schedule_Out> Schedule_2 { get; set; }
        public DbSet<Schedule_In> Schedule_1 { get; set; }
        
        public DbSet<Order> Orders { get; set; }
        public DbSet<City> City { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

    }
    public class ApplicationUser : IdentityUser 
    {
        public List<Order> Orders { get; set; }
    }
}
