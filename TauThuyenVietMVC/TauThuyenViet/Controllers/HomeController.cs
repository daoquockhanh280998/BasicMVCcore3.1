using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TauThuyenViet.Models;

namespace TauThuyenViet.Controllers
{
    public class HomeController : Controller
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public HomeController(DBContext context)
        {
            db = context;
        }


        [Route("", Name = "home")]
        public IActionResult Index()
        {
            var query = db.ProductCategory
                .Include(x => x.Product)
                .Where(x => x.Status == true)
                .OrderBy(x => x.Position)
                .ToList();

            return View();
        }
    }
}
