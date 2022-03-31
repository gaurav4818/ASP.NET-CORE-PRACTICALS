using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using crudcore.Models;
using crudcore.Repository;

namespace crudcore.Controllers
{
    public class BookController : Controller
    {
        private IbookRepository bookRepository;
        private BookContext db;

        public BookController(BookContext db)
        {
            this.db = db;
            this.bookRepository = new BookRepository(db);
        }
        // GET: BookController
        public IActionResult Index()
        {
            
            return View(bookRepository.GetAllBooks().ToList());
        }

        // GET: BookController/Details/5
        public IActionResult Details(int id)
        {

            Book book = bookRepository.GetBook(id);
            return View(book);
        }

        // GET: BookController/Create
        public IActionResult Create()
        {
            return View(new Book());
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
          
                if (ModelState.IsValid)
                {
                    bookRepository.Add(book);
                    bookRepository.save();
                    return RedirectToAction("Index");
                }
          
           ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            return View();
        }

        // GET: BookController/Edit/5
        public IActionResult Edit(int id)
        {
            Book book = bookRepository.GetBook(id);
            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            if (ModelState.IsValid)
            {
                bookRepository.Update(book);
                bookRepository.save();
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            return View();
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            Book book = bookRepository.GetBook(id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,Book book)
        {
            bookRepository.Delete(id);
            bookRepository.save();
            return RedirectToAction("Index");
        }
    }
}
