using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace testboard.Controllers
{
    public class AccountController : Controller
    {
        /// <summary>
        /// Login fuction
        /// </summary>
        /// <returns></returns>
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
    }
}