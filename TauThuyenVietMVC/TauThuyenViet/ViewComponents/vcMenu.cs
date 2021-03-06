﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TauThuyenViet.Models;

namespace TauThuyenViet.ViewComponensts
{
    public class vcMenu : ViewComponent
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public vcMenu(DBContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
            var query = db.ProductMainCategory
                .Include(x => x.ProductCategory)
                .Where(x => x.Status == true)
                .OrderBy(x => x.Position)
                .ToList();

            return View(query);
        }
    }
}
