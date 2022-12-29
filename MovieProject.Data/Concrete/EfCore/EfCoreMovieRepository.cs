using Microsoft.EntityFrameworkCore;
using MovieProject.Data.Abstract;
using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data.Concrete.EfCore
{
    public class EfCoreMovieRepository : EfCoreGenericRepository<Movie, MovieProjectContext>, IMovieRepository
    {
        public List<Movie> GetListAll()
        {
            using (var context = new MovieProjectContext())
            {
                return context.Movies.Include(x => x.Category).ToList();
            }
        }

        

        public string GetCategoryName(int id)
        {
            using (var context = new MovieProjectContext()) 
            {
                return context.Categories.Find(id).CategoryName;
            }
        }

        public IEnumerable<Movie> GetMoviesByCategory(int catId)
        {
            using (var context = new MovieProjectContext())
            {
                return context.Movies.Where(x => x.CategoryId == catId);
            }
        }

        public IEnumerable<Movie> GetMoviesWithCategory()
        {
            using (var context = new MovieProjectContext())
            {
                return context.Movies.Include(u => u.Category);
            }
        }
    }
}
