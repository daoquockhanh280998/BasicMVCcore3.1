using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{
    public class HomeController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public HomeController(DBContext context)
        {
            db = context;
        }

        [Route("", Name = "home")]
        public IActionResult Index̣̣()
        {
           
            return View();
        }
    }
}
