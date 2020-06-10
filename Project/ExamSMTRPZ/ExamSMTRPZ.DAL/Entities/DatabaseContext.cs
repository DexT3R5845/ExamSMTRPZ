using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace ExamSMTRPZ.DAL.Entities
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Element> Elements { get; set; }
        public DbSet<NatureElement> NatureElements { get; set; }
        public DbSet<TypeElement> TypeElements { get; set; }
        public DbSet<TypeNatureElement> TypeNatureElements { get; set; }

        public DatabaseContext(string connectionString) : base(connectionString) { }
    }
}
