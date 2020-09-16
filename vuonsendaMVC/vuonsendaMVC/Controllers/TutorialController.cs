using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{
    public class TutorialController : Controller
    {
        [Route("huong-dan", Name = "tutorial")]
        public IActionResult Index̣̣()
        {
            return View();
        }

    }
}
