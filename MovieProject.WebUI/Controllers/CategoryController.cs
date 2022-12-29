using Microsoft.AspNetCore.Mvc;
using MovieProject.Business.Abstract;
using MovieProject.Entity;

namespace MovieProject.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMovieService _movieService;

        public CategoryController(ICategoryService categoryService, IMovieService movieService)
        {
            _categoryService = categoryService;
            _movieService = movieService;
        }



        public IActionResult Index()
        {
            return View();
        }



        //Cat List
        public IActionResult CategoryList()
        {
            var values = _categoryService.GetAll();
            return View(values);
        }


        //AddCat Get
        public IActionResult AddCategory(int id)
        {
            //var value2 = _categoryService.GetById(id);
            return View();
        }

        //AddCat Post
        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            _categoryService.Create(category);
            return RedirectToAction("CategoryList", "Category");
        }


        //UpdateCat GET
        public IActionResult UpdateCategory(int id)
        {
            var value = _categoryService.GetById(id);
            return View(value);
        }


        //UpdateCat Post
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            var entity = _categoryService.GetById(category.CategoryId);
            entity.CategoryName = category.CategoryName;
            _categoryService.Update(entity);
            return RedirectToAction("CategoryList", "Category");
        }


        //Delete Cat
        public IActionResult DeleteCategory(int id)
        {
            var entity = _categoryService.GetById(id);
            _categoryService.Delete(entity);
            return RedirectToAction("CategoryList", "Category");
        }








    }
}
