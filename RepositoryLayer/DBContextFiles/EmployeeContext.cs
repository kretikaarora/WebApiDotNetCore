using CommaonLayer.ContextModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.DBContextFiles
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<CompanyEmployee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CompanyEmployee>()
                .HasIndex(u => u.Email)
                .IsUnique();
        }

    }
}
