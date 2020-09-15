using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Theatermoviemanagement._00data
{
    public class MovieDBContext : DbContext
    {
      public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Pubg> Pubgs { get; set; }
        /*dotnet tool install --global dotnet-ef 

dotnet ef migrations add InitialCreate   -- creates script 

Or 

Add-Migration NewMigration -Project DAL 

dotnet ef database update  -- creates db and runs the migration 

dotnet ef migrations remove 

dotnet ef database drop 
         */
    }
}
