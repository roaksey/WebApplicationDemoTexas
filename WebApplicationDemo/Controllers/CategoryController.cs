using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Data;

namespace WebApplicationDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            return View(categories);
        }
    }
}
