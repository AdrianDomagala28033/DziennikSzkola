using Microsoft.EntityFrameworkCore;
using MiniDziennik.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniDziennik.Context
{
    class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=bazaMiniDziennik.db");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Klasa> Klasa { get; set; }
        public DbSet<Uczniowie> Uczniowie { get; set; }
        
        
    }
}

