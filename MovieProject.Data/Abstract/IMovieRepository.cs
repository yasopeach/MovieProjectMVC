using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Data.Abstract
{
    public interface IMovieRepository : IRepository<Movie>
    {
        List<Movie> GetListAll();

        IEnumerable<Movie> GetMoviesByCategory(int id);

        IEnumerable<Movie> GetMoviesWithCategory();

        string GetCategoryName(int id);
    }
}
