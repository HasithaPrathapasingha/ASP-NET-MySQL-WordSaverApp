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
        public IActionResult Submit(string word, string description)
        {
            int wordCount = description?.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length ?? 0;

            if (string.IsNullOrWhiteSpace(word) || string.IsNullOrWhiteSpace(description) || wordCount > 100){
                ViewBag.Message = "Both fields are required and description must be 100 words max.";
                return View("Index");
            }

            var entry = new WordEntry{
                Word = word,
                Description = description,
                Date = DateOnly.FromDateTime(DateTime.Today)
            };

            _context.WordEntries.Add(entry);
            _context.SaveChanges();

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
