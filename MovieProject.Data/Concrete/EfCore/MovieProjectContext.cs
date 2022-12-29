using Microsoft.EntityFrameworkCore;
using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data.Concrete.EfCore
{
    public class MovieProjectContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-AFUMI0D\\MSSQLCNBRK; Database = MovieProject_Db; User = sa; Password = 123");

        }
    }
}
