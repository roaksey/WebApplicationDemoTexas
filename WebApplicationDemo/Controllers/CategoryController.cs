using Microsoft.AspNetCore.Mvc;
using WebApplicationDemo.Data;
using WebApplicationDemo.Models;

namespace WebApplicationDemo.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }
        //Read
        public IActionResult Index()
        {
            var categories = _db.Categories.ToList();
            return View(categories);
        }
        public IActionResult Read(int id)
        {
            Category category = _db.Categories.FirstOrDefault(c => c.Id == id); 
            return View(category);
        }
        //Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category model)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(model);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public IActionResult Edit(int Id)
        {
            Category category = _db.Categories.FirstOrDefault(x => x.Id == Id);
            if(category is null)
            {
                return NotFound();
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Update(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);  
        }

        public IActionResult Delete(int Id)
        {
            Category category = _db.Categories.FirstOrDefault(x => x.Id == Id);
            if(category is null )
            {
                return NotFound();
            }
            return View(category);
        }
        [HttpPost]
        public IActionResult Delete(Category category)
        {
            if(category == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(category);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


        
    }
}
