using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TauThuyenViet.ClassHelpers;
using TauThuyenViet.Models;

namespace TauThuyenViet.ViewComponensts
{
    public class vcArticleRelated : ViewComponent
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public vcArticleRelated(DBContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke(int? ID)
        {
            //load tất cả sản phẩm
            var data = db.Article.Where(x => x.Status == true)
                                 .OrderBy(x => Guid.NewGuid()).AsQueryable();

            if (ID != null)
            {
                // load san pham lien quan
                data = data.Where(x => x.ArticleID != ID);
            }

            return View(data.ToList());
        }
    }
}
