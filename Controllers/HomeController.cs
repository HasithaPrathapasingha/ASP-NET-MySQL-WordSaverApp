using Microsoft.AspNetCore.Mvc;
using WordSaverApp.Data;
using WordSaverApp.Models;

namespace WordSaverApp.Controllers
{
    public class HomeController(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(string word)
        {
            if (!string.IsNullOrWhiteSpace(word))
            {
                var entry = new WordEntry { Word = word };
                _context.WordEntries.Add(entry);
                _context.SaveChanges();
            }

            ViewBag.Message = "Word saved successfully!";
            return View("Index");
        }
        public IActionResult List()
        {
            var words = _context.WordEntries.ToList();
            return View(words);
        }
    }
}
