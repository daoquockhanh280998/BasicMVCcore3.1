using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{
    public class ArticleController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public ArticleController(DBContext context)
        {
            db = context;
        }

        [Route("tin-tuc", Name = "article-list")]
        [Route("tin-tuc/p{page:int}", Name = "article-list-page")]
        public IActionResult Index̣̣(int page)
        {
            var data = db.Article.Where(x => x.Status == true);

            // đường dẫn URL mặc định dùng để phần trang
            string url = "/tin-tuc/p{0}";

            //sắp xếp bài mới nhất
            data = data.OrderByDescending(x => x.CreateTime);

            //đếm số lượng dữ liệu phù hợp
            int totals = data.Count();

            // xử lý phân trang
            if (page <= 0)
                page = 1;

            int pageSize = 7; // đây là số phần tử xuất hiện
            int skip = (page - 1) * pageSize;

            var listData = data.Skip(skip).Take(pageSize);

            //tạo dữ liệu cho view 
            ListDatasource datasource = new ListDatasource();
            datasource.Totals = totals;
            datasource.Page = page;
            datasource.PageSize = pageSize;
            datasource.MaxPage = 6;
            datasource.Url = url;
            datasource.Data = listData.ToList();


            return View(datasource);
        }

        [Route("tin-tuc/chi-tiet/{id:int}/{title?}", Name = "article-detail")]
        public IActionResult Detail( int ID ,string Title)
        {
            var item = db.Article.Where(x => x.ArticleID == ID).FirstOrDefault();
            return View(item);
        }
    }
}
