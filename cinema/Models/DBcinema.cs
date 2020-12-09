using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace cinema.Models
{
    public class DBcinema :DbContext
    {
        public DbSet<Film> Films { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Language>  languages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Director> Directors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source=.;initial catalog=DBcinema;Integrated security=true;");
        }
    }
    
}
