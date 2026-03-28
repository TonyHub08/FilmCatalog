using Data;
using Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business
{
    public class ProductBusinesss
    {
        private FilmContext FilmContext;
        public List<Film> GetAll() 
        {
            using (FilmContext = new FilmContext())
            {
                return FilmContext.Films.ToList();
            }
        }
        public Film Get(int id) 
        {
            using (FilmContext = new FilmContext())
            {
                return FilmContext.Films.Find(id);
            }
        }
        public void Add(Film product)
        {
            using (FilmContext = new FilmContext())
            {
                FilmContext.Films.Add(product);
                FilmContext.SaveChanges();
            }
        }
        public void Update(Film product)
        {
            using (FilmContext = new FilmContext())
            {
                var item = FilmContext.Films.Find(product.Id);
                if (item != null)
                {
                    FilmContext.Entry(item).CurrentValues.SetValues(product);
                    FilmContext.SaveChanges();
                }
            }
        }
        public void Delete(int id)
        {
            using (FilmContext = new FilmContext())
            {
                var item = FilmContext.Films.Find(id);
                if (item != null)
                {
                    FilmContext.Films.Remove(item);
                    FilmContext.SaveChanges();
                }
            }
        }
    }
}
