using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TauThuyenViet.ClassHelpers;
using TauThuyenViet.Models;

namespace TauThuyenViet.Controllers
{
    public class ArticleController : Controller
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public ArticleController(DBContext context)
        {
            db = context;
        }

        [Route("tintuc", Name="Acticle-List")]
        [Route("tintuc/p{page:int}", Name = "Acticle-List-page")]
        [Route("tintuc/{id:int}/{title?}", Name = "Acticle-List-main")]
        public IActionResult Index(int id, string title, int page)
        {
            var query = db.Article.Where(x => x.Status == true);

            string url = "/tintuc/p{0}";

            //sắp xếp theo ngày đăng
            var data = query.OrderByDescending(x => x.CreateTime);

            // dem so luong du lieu  phu hop 
            int totals = data.Count();

            // sử lý phân trang
            if (page <= 0)
            {
                page = 1;
            }
            int pageSize = 3;
            int skip = (page - 1) * pageSize;

            var listData = data.Skip(skip).Take(pageSize);

            // TAO DŨ LIEU CHO VIEW
            ListDatasource datasource = new ListDatasource();
            datasource.Total = totals;
            datasource.Page = page;
            datasource.PageSize = pageSize;
            datasource.MaxPage = 6;
            datasource.Url = url;
            datasource.Data = listData.ToList();

            return View(datasource);
        }

        [Route("tintuc/chitiet/{id:int}/{title?}", Name = "Acticle-Detail")]
        public IActionResult Detail(int id, string title)
        {
            var item = db.Article.Where(x => x.ArticleID == id).FirstOrDefault();
            return View(item);
        }
    }
}
