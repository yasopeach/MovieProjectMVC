using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieProject.Business.Abstract;
using MovieProject.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MovieProject.WebUI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IMovieService _movieService;
        private readonly ICategoryService _categoryService;

        public MovieController(IMovieService movieService, ICategoryService categoryService)
        {
            _movieService = movieService;
            _categoryService = categoryService;
        }


        public IActionResult Index()
        {
            return View();
        }


        public IActionResult MovieList()
        {
            var values = _movieService.GetListAll();
            return View(values);
        }


        //AddMovGET
        public IActionResult AddMovie(int id)
        {
            List<SelectListItem> value1 = (from x in _categoryService.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()

                                           }).ToList();
            ViewBag.cv = value1;
            var value2 = _movieService.GetById(id);
            return View(value2);
        }


        //AddMovPOST
        [HttpPost]
        public IActionResult AddMovie(Movie movie)
        {
            _movieService.Create(movie);

            return RedirectToAction("MovieList", "Movie");
        }


        //UpdateMovie GET
        public IActionResult UpdateMovie(int id)
        {

            List<SelectListItem> value1 = (from x in _categoryService.GetAll()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryId.ToString()

                                           }).ToList();
            ViewBag.cv = value1;
            var value2 = _movieService.GetById(id);
            return View(value2);
        }

        //UpdateMovie POST
        [HttpPost]
        public IActionResult UpdateMovie(Movie movie)
        {
            var entity = _movieService.GetById(movie.MovieId);
            entity.MovieName = movie.MovieName;
            entity.MovieDate = movie.MovieDate;
            entity.MovieImdb = movie.MovieImdb;
            entity.CategoryId= movie.CategoryId;
            _movieService.Update(entity);
            return RedirectToAction("MovieList", "Movie");
        
        }


        public IActionResult DeleteMovie(int id)
        {
            var entity = _movieService.GetById(id);      
            _movieService.Delete(entity);
            return RedirectToAction("MovieList", "Movie");
        }

        public IActionResult MoviesByCategory(int categoryId)
        {
            IEnumerable<Movie> movieByCatList = _movieService.GetMoviesByCategory(categoryId);

            ViewBag.catName = _movieService.GetCategoryName(categoryId);
            
            return View(movieByCatList);
        }



    }
}
