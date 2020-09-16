using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{
    public class ClientController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public ClientController(DBContext context)
        {
            db = context;
        }

        [Route("tai-khoan", Name = "Client")]
        public IActionResult Index̣̣()
        {
           // var client = JsonConvert.DeserializeObject<Client>(HttpContext.Session.GetString("ClientSession"));
            if (SessionUtility.AcountEmail == null)
            {
                Response.Redirect("/");
                return RedirectToAction("index", "home");
            }
            else
            {
                string email = SessionUtility.AcountEmail;
                var data = db.Client.Where(x => x.Email == email).FirstOrDefault();
                return View(data);
            }
        }

        [HttpPost]
        [Route("tai-khoan", Name = "Client")]
        public IActionResult Index̣̣(Client item)
        {
            HttpContext.Session.Clear();
            return RedirectToRoute("home");
        }
    }
}
