using Module6MVVM;
using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using System.IO;
using Module6MVVM.Model;

namespace Module6MVVM.Services
{
    internal class DatabaseContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set; }

        public DatabaseContext() {
        this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dBpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "Employee.db");
            optionsBuilder.UseSqlite($"Filename={dBpath}");
        }

    }
}
