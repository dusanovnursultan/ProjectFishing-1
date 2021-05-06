using ProjectFishing.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProjectFishing.Infrastructure
{
    public class Context : DbContext
    {
        public Context() : base("DbFishing") { }
        public DbSet<Fish> Fishies { get; set; }
        public DbSet<Lakes> Lakes { get; set; }
        public DbSet<Shops> Shops { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
       
    }
    
}