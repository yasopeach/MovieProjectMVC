using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Abstract
{
    public interface IMovieService
    {
        Movie GetById(int id);

        List<Movie> GetAll();
        List<Movie> GetListAll();
        void Create(Movie entity);
        void Update(Movie entity);
        void Delete(Movie entity);

        IEnumerable<Movie> GetMoviesByCategory(int id);   

        IEnumerable<Movie> GetMoviesWithCategory(int id);

        string GetCategoryName(int id);
    }
}
