using MovieProject.Business.Abstract;
using MovieProject.Data.Abstract;
using MovieProject.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieRepository _movieRepository;

        public MovieManager(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }


        public void Create(Movie entity)
        {
            _movieRepository.Create(entity);
        }

        public void Delete(Movie entity)
        {
            _movieRepository.Delete(entity);
        }

        public List<Movie> GetAll()
        {
            return _movieRepository.GetAll();
        }

        public Movie GetById(int id)
        {
            return _movieRepository.GetById(id);
        }

        public string GetCategoryName(int id)
        {
            return _movieRepository.GetCategoryName(id);
        }

        public List<Movie> GetListAll()
        {
            return _movieRepository.GetListAll();
        }

        public IEnumerable<Movie> GetMoviesByCategory(int id)
        {
            return _movieRepository.GetMoviesByCategory(id);
        }

        public IEnumerable<Movie> GetMoviesWithCategory(int id)
        {
            return _movieRepository.GetMoviesByCategory(id);
        }

        public void Update(Movie entity)
        {
            _movieRepository.Update(entity);
        }
    }
}
