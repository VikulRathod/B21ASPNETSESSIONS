using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class B21CodeFirstDBContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configuration.LazyLoadingEnabled = false; // disabling lazy loading
        }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<Course> Courses { get; set; }
    }
}