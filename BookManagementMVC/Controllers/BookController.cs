using Microsoft.AspNetCore.Mvc;
using BookManagementMVC.Models;

namespace BookManagementMVC.Controllers
{
    public class BookController : Controller
    {
        private static List<Book> books = new()
        {
            new Book { Id = 1, Name = "Clean Code", Price = 20 },
            new Book { Id = 2, Name = "ASP.NET MVC", Price = 15 },
            new Book { Id = 3, Name = "Design Pattern", Price = 25 }
        };

        
        public IActionResult Index()
        {
            return View(books);
        }

       
        public IActionResult Detail(int id)
        {
            var book = books.FirstOrDefault(x => x.Id == id);
            return View(book);
        }

      
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            book.Id = books.Count + 1;
            books.Add(book);

            ViewBag.Message = "Thêm sách thành công";

            return View(book);
        }
    }
}