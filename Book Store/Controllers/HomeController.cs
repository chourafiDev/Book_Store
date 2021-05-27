using Book_Store.Data;
using Book_Store.Models;
using Book_Store.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _Context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext Context)
        {
            _logger = logger;
            _Context = Context;
        }

        private List<Book> GetNewestRelease() => _Context.books.Include(m => m.Genres).OrderByDescending(m => m.PublishedDtae).Take(8).ToList();
        private List<Book> GetRecommended() => _Context.books.Include(m => m.Genres).OrderByDescending(m => m.Rate).Take(4).ToList();
        //private List<Book> GetTopGenre()
        //{
        //    var Result = _Context.books
        //                 .GroupBy(m => m.GenreId)
        //                 .Select(m => new { GenreId = m.Key, Count = m.Count() })
        //                 .OrderByDescending(m => m.Count)
        //                 .Take(3)
        //                 .ToList();
                         

        //    return Result;

        //}

        public async Task<IActionResult> Index()
        {
            HomeIndexViewModel model = new HomeIndexViewModel();
            model.Genres = await _Context.genres.Take(3).ToListAsync();
            return View(model);
        }

        public async Task<IActionResult> ListOfBooks()
        {
            SearchIndexViewModel model = new SearchIndexViewModel();
            model.Books = await _Context.books.Include(m => m.Genres).ToListAsync();
            model.Genres = await _Context.genres.ToListAsync();
            model.BooksResent = _Context.books.Include(m => m.Genres).OrderByDescending(m => m.PublishedDtae).Take(4).ToList();

            ViewBag.CountBooks = _Context.books.Count();
            return View(model);
        }


        public IActionResult GetBooksByGenre(int Id)
        {
            var result = _Context.books.Include(a => a.Genres).Where(a => a.GenreId == Id).ToList();
            ViewBag.CountResultGenre = _Context.books.Where(a => a.GenreId == Id).Count();
            ViewBag.NameGenre = _Context.books.Where(a => a.GenreId == Id).Select(a => a.Genres.Name).FirstOrDefault();
            return View(result);
        }

        public JsonResult GetNewestReleaseJson()
        {
            var getNewestRelease = GetNewestRelease();
            return new JsonResult(getNewestRelease);
        }

        public IActionResult GetRecommendedJson()
        {
            var getRecommended = GetRecommended();
            return new JsonResult(getRecommended);
        }

        //public IActionResult GetPopulareCategoryJson()
        //{
        //    //var PopulareCategory = _Context.books
        //    //                    .Include(m => m.Genres.Name)
        //    //                    .GroupBy(m => m.GenreId)
        //    //                    .Select(m => new { GenreId = m.Key, Count = m.Count() })
        //    //                    .OrderByDescending(m => m.Count)
        //    //                    .Take(3)
        //    //                    .ToList();
        //    var PopulareCategory = _Context.books.Include(m=>m.Genres).Take(3).ToList();
        //    return View(PopulareCategory);
        //}


        public IActionResult Search()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string searchString)
        {
            SearchIndexViewModel modelSearch = new SearchIndexViewModel();
            //modelSearch.Books = await _Context.books.Include(m => m.Genres).ToListAsync();
            modelSearch.Genres = await _Context.genres.ToListAsync();
            modelSearch.Books = await _Context.books.Where(a => a.Title.Contains(searchString) 
                                || a.Genres.Name.Contains(searchString) 
                                || a.Description.Contains(searchString)).ToListAsync();
            modelSearch.BooksResent = _Context.books.Include(m => m.Genres).OrderByDescending(m => m.PublishedDtae).Take(4).ToList();
            ViewBag.CountBookSearch = modelSearch.Books.Count();
            return View(modelSearch);
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
