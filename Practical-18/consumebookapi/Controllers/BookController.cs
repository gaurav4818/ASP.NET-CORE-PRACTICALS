using consumebookapi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace consumebookapi.Controllers
{
   
    public class BookController : Controller
    {
        private readonly IConfiguration _configuration;
        private readonly string apiBaseUrl;

        public BookController(IConfiguration configuration)
        {
            _configuration = configuration;
            apiBaseUrl = _configuration.GetValue<string>("WebAPIBaseUrl");
        }

        public IActionResult Index()
        {
            IEnumerable<BookInfo> book = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);
                //HTTP GET
                var responseTask = client.GetAsync("Books");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<BookInfo>>();
                    readTask.Wait();

                    book = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    book = Enumerable.Empty<BookInfo>();

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(book);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookInfo book)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);

                //HTTP POST
                var postTask = client.PostAsJsonAsync<BookInfo>("books", book);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Index");
                }
            }

            ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");

            return View(book);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            BookInfo book = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);
                //HTTP GET
                var responseTask = client.GetAsync("books/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<BookInfo>();
                    readTask.Wait();

                    book = readTask.Result;
                }
            }

            return View(book);
        }
        [HttpPost]
        public IActionResult Edit(int id,BookInfo book)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);


                //HTTP POST
                var putTask = client.PutAsJsonAsync<BookInfo>("books/"+id.ToString(), book);
                putTask.Wait();

                var result = putTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }
            return View(book);

        }
        public IActionResult Delete(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);

                //HTTP DELETE
                var deleteTask = client.DeleteAsync("books/" + id.ToString());
                deleteTask.Wait();

                var result = deleteTask.Result;
                if (result.IsSuccessStatusCode)
                {

                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            BookInfo book = null;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBaseUrl);
                //HTTP GET
                var responseTask = client.GetAsync("books/" + id.ToString());
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<BookInfo>();
                    readTask.Wait();

                    book = readTask.Result;
                }
            }

            return View(book);
        }
    }
}
