using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFCodeFirstApproach.Models
{
    public class B21CodeFirstDBContext : DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}