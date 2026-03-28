using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class FilmContext : DbContext
    {
        public FilmContext() : base("name=FilmContext")
        {

        }
        public DbSet<Film> Films { get; set; }    
    }
}
