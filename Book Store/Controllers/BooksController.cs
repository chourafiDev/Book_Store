using Book_Store.Data;
using Book_Store.Models;
using Book_Store.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NToastNotify;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IToastNotification _toastNotification;

        private List<string> _allowdExetenstions = new List<string> { ".jpg", ".png" };
        private long _MaxAllowedImaeSize = 1048576;

        public BooksController(ApplicationDbContext context, IToastNotification toastNotification)
        {
            _context = context;
            _toastNotification = toastNotification;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.date = _context.books.Select(m => m.PublishedDtae.ToShortDateString().ToString());
            var books = await _context.books.Include(m => m.Genres).OrderByDescending(m => m.Rate).ToListAsync();
            return View(books);
        }

        public async Task<IActionResult> Create()
        {
            var viewModel = new BookFormViewModel
            {
                Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync()
            };
            return View("BookForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BookFormViewModel BookObj)
        {
            if (!ModelState.IsValid)
            {
               BookObj.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                return View("BookForm",BookObj);
            }

            //check if model has file (images, files...)
            var files = Request.Form.Files;
            if (!files.Any())
            {
               BookObj.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                ModelState.AddModelError("Image", "Please select book image!");
                return View("BookForm",BookObj);
            }


            //check exetenstion image
            var image = files.FirstOrDefault();

            if (!_allowdExetenstions.Contains(Path.GetExtension(image.FileName).ToLower()))
            {
               BookObj.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                ModelState.AddModelError("Image", "Only .JPG and .PNG are allowed!");
                return View("BookForm",BookObj);
            }

            //check size image
            if (image.Length > _MaxAllowedImaeSize)
            {
               BookObj.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                ModelState.AddModelError("Image", "Image cannot be more 1 MB!");
                return View("BookForm",BookObj);
            }

            using var datastream = new MemoryStream();
            await image.CopyToAsync(datastream);

            var book = new Book()
            {
                Title =BookObj.Title,
                Description =BookObj.Description,
                TotalPages =BookObj.TotalPages,
                Rate =BookObj.Rate,
                Price =BookObj.Price,
                GenreId =BookObj.GenreId,
                Image = datastream.ToArray()
            };

            _context.books.Add(book);
            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Book Created Successfully");
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var book = await _context.books.Include(m => m.Genres).SingleOrDefaultAsync(m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }



        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var book = await _context.books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            var viewModel = new BookFormViewModel
            {
                Id = book.Id,
                Title = book.Title,
                Description = book.Description,
                TotalPages = book.TotalPages,
                Rate = book.Rate,
                Price = book.Price,
                GenreId = book.GenreId,
                Image = book.Image,
                Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync()
            };

            return View("BookForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(BookFormViewModel book)
        {
            if (!ModelState.IsValid)
            {
                book.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                return View("BookForm", book);
            }

            var bookFind = await _context.books.FindAsync(book.Id);
            if (book == null)
            {
                return NotFound();
            }

            var files = Request.Form.Files;
            if (files.Any())
            {
                var image = files.FirstOrDefault();

                using var dataStream = new MemoryStream();

                await image.CopyToAsync(dataStream);

                //check exetenstion image
                if (!_allowdExetenstions.Contains(Path.GetExtension(image.FileName).ToLower()))
                {
                    book.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                    ModelState.AddModelError("Image", "Only .JPG and .PNG are allowed!");
                    return View("BookForm", book);
                }

                //check size image
                if (image.Length > _MaxAllowedImaeSize)
                {
                    book.Genres = await _context.genres.OrderBy(m => m.Name).ToArrayAsync();
                    ModelState.AddModelError("Image", "Image cannot be more 1 MB!");
                    return View("BookForm", book);
                }

                bookFind.Image = dataStream.ToArray();
            }

            bookFind.Title = book.Title;
            bookFind.Description = book.Description;
            bookFind.TotalPages = book.TotalPages;
            bookFind.Rate = book.Rate;
            bookFind.Price = book.Price;
            bookFind.GenreId = book.GenreId;

            _context.SaveChanges();

            _toastNotification.AddSuccessToastMessage("Book Updated Successfully");
            return RedirectToAction(nameof(Index));
        }



        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }

            var book = await _context.books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.books.Remove(book);
            _context.SaveChanges();
            _toastNotification.AddSuccessToastMessage("Book Deleted Successfully");
            return Ok();
        }
    }
}
