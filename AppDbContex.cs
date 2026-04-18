using EFTask.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTask
{
    internal class AppDbContex : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=\\\\.\\pipe\\MSSQL$SQLEXPRESS\\sql\\query;Database=EFGroup1;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<Book> books { get; set; }
        public DbSet<Auther> authers { get; set; }

    }
}
