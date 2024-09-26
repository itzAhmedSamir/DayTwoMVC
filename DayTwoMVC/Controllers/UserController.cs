using DayTwoMVC.DAL.DB;
using DayTwoMVC.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft;
using Microsoft.EntityFrameworkCore;

namespace DayTwoMVC.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Result = context.Users.Include(a => a.posts).ToList();
            return View(Result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid) 
            {
                context.Users.Add(user);
                context.SaveChanges();
                return RedirectToAction("Index", "User");
            }   
            return View(user);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var Result = context.Users.Where(a=>a.Id==id).FirstOrDefault();
            return View(Result);
        }
        [HttpPost]
        public IActionResult Edit(User user)
        {
            var Result = context.Users.Where(a => a.Id == user.Id).FirstOrDefault();
            Result.Email=user.Email;
            Result.Age=user.Age;
            Result.Password=user.Password;
            Result.Name=user.Name;

            context.SaveChanges();
            return RedirectToAction("Index", "User");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var Result = context.Users.Where(a => a.Id == id).FirstOrDefault();
            Result.IsDeleted=!Result.IsDeleted;
            context.SaveChanges();
            return RedirectToAction("Index", "User");
        }

    }
}
    