using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.Models;
using System.Diagnostics;

namespace Pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly PustokDbContext _context;

        public HomeController(PustokDbContext context)
        {
            this._context = context;
        }

        public IActionResult Index()
        {

          ICollection<Book> books = _context.Books.Include(b=>b.Author).Include(b=>b.Genre).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).ToList();
            return View(books);
        }

       
    }
}