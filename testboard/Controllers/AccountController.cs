using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using testboard.DataContext;
using testboard.Models;

namespace testboard.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Login fuction
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        /// <summary>
        /// Register function
        /// </summary>
        /// <returns></returns>
        
        public IActionResult Register()
        {
            return View();
        }  
        
        [HttpPost]
        public IActionResult Register(User model)
        {
            if (ModelState.IsValid) //validate if all mandatory files are filled 
            {
                using (var db = new AspnetNoteDbContext())
                { 
                    db.Users.Add(model);
                    db.SaveChanges();
                }

                return RedirectToAction("Index", "Home"); //redirect to Home controller 
            }

            return View();
        } 
        
        
    }
}