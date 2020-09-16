using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{
    public class ProductController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public ProductController(DBContext context)
        {
            db = context;
        }

        [Route("san-pham", Name = "product-list")]
        [Route("san-pham/p{page:int}", Name = "product-list-page")]
        [Route("san-pham/{mid:int}/{title?}", Name = "product-list-main")]
        [Route("san-pham/{mid:int}/{title?}/p{page:int}", Name = "product-list-main-page")]
        [Route("san-pham/{mid:int}/{cid:int}/{title?}", Name = "product-list-sub")]
        [Route("san-pham/{mid:int}/{cid:int}/{title?}/p{page:int}", Name = "product-list-sub-page")]
        public IActionResult Index̣̣(int mid, int cid, string title, int page = 1)
        {
            var query = db.Product
                .Where(x => x.Status == true);

            string url = "/san-pham/p{0}";
            //nếu có mid thì load sản phẩm theo dk mid
            if (mid > 0)
            {
                url = $"/san-pham/{mid}/{title}/p{{0}}"; //p{{0}} : là do page này mình k lấy page hiện tại nên mình k thể bỏ vào biến p{page} dc mà phải để là p{0} nhưng biến $ sẽ hiểu đây chỉ là tên biến k hiểu nên phải xài theo kiểu sql là dấu nào k dc thì mình chơi 2 dấu :)) (cách tà đạo)
                query = query.Where(x => x.ProductCategory.ProductMainCategoryID == mid);
            }

            //nếu có cid thì load sản phẩm theo dk cid
            if (cid > 0)
            {
                url = $"/san-pham/{mid}/{cid}/{title}/p{{0}}";
                query = query.Where(x => x.ProductCategoryID == cid);
            }


            //sắp xếp mới nhất
            var data = query.OrderByDescending(x => x.CreateTime);

            //đếm số lượng dữ liệu phù hợp
            int totals = data.Count();

            // xử lý phân trang
            if (page <= 0)
                page = 1;

            int pageSize = 12; // đây là số phần tử xuất hiện
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
        [Route("san-pham/chi-tiet/{id:int}/{title?}", Name = "product-detail")]
        public IActionResult Detail(int id, string title)
        {
            var item = db.Product.Where(x => x.ProductID == id).FirstOrDefault();
            return View(item);
        }
    }
}
