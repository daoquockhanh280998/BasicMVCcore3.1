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
    public class ProductController : Controller
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public ProductController(DBContext context)
        {
            db = context;
        }

        [Route("sanpham", Name = "Product-List")]
        [Route("sanpham/p{page:int}", Name = "Product-List-page")]
        [Route("sanpham/{mid:int}/{title?}", Name = "Product-List-main")]
        [Route("sanpham/{mid:int}/{title?}/p{page:int}", Name = "Product-List-main-page")]
        [Route("sanpham/{mid:int}/{cid:int}/{title?}", Name = "Product-List-sub")]
        [Route("sanpham/{mid:int}/{cid:int}/{title?}/p{page:int}", Name = "Product-List-sub-page")]
        public IActionResult Index(int mid, int cid, string title, int page)
        {
            var query = db.Product.Include(x => x.ProductCategory)
                        .Where(x => x.Status == true);

            string url = "/sanpham/p{0}";

            // nếu có mid thì lọc theo mid
            if (mid > 0)
            {
                url = $"/sanpham/{mid}/{title}/p{{0}}"; // do xài $ của mvc 5 nên phần  p{0} là phần page dc hiểu là page{0} nên phải sử dụng p{{0}} giống như sql dấu nào cấm thì chơi 2 dấu cùng 1 lúc :))
                query = query.Where(x => x.ProductCategory.ProductMainCategoryID == mid);
            }

            // nếu có cid thì lọc theo cid
            if (cid > 0)
            {
                url = $"/sanpham/{mid}/{cid}/{title}/p{{0}}";
                query = query.Where(x => x.ProductCategoryID == cid);
            }

            //sắp xếp theo ngày đăng
            var data = query.OrderByDescending(x => x.CreateTime);

            // dem so luong du lieu  phu hop 
            int totals = data.Count();

            // sử lý phân trang
            if (page <=0)
            {
                page = 1;
            }
            int pageSize = 9;
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

        [Route("sanpham/chitiet/{id:int}/{title?}", Name = "Product-Detail")]
        public IActionResult Detail(int id , string title)
        {
            var item = db.Product.Where(x => x.ProductID == id).FirstOrDefault();
            return View(item);
        }
    }
}
