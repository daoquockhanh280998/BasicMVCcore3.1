using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.ViewComponents
{
    public class vcProductRelated : ViewComponent
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public vcProductRelated(DBContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke(int? ID, int? catID)
        {
            var data = db.Product.Where(x => x.Status == true).OrderBy(x => Guid.NewGuid()).AsQueryable();
            if (ID != null && catID != null)
            {
                data = data.Where(x => x.ProductID != ID && x.ProductCategoryID == catID);
                // ViewBag.Heading = "Xem Thêm Sản Phẩm Tương Tự";
                ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING] = "Xem Thêm Sản Phẩm Tương Tự";
            }
            else if (ID == null && catID != null)
            {
                data = data.Where(x => x.ProductCategoryID != catID);
                //ViewBag.Heading = "Xem Thêm Sản Phẩm Khác";
                ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING] = "Xem Thêm Sản Phẩm Khác";
            }
            else
            {
                //ViewBag.Heading = "Có Thể Bạn Quan Tâm";
                ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING] = "Có Thể Bạn Quan Tâm";
            }

            return View(data.Take(4).ToList());
        }
    }
}
