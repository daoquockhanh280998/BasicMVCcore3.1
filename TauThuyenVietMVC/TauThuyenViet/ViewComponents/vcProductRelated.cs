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
    public class vcProductRelated : ViewComponent
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public vcProductRelated(DBContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke(int? ID, int? catID)
        {
            //load tất cả sản phẩm
            var data = db.Product.Where(x => x.Status == true)
                                 .OrderBy(x => Guid.NewGuid()).AsQueryable();

            if (ID != null && catID != null)
            {
                // load san pham lien quan
                data = data.Where(x => x.ProductID != ID && x.ProductCategoryID == catID);
                // ViewBag.Heading = "Xem Thêm Các Sản Phẩm Liên Quan";
                //ViewBagUtility.ProductRelatedHeading = "Xem Thêm Các Sản Phẩm Liên Quan";
                ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING] = "Xem Thêm Các Sản Phẩm Liên Quan";
            }
            else if (ID == null && catID != null)
            {
                // load san pham khong lien quan khac catID
                data = data.Where(x => x.ProductCategoryID != catID);
                // ViewBag.Heading = "Xem Thêm Các Sản Phẩm Khác";
               // ViewBagUtility.ProductRelatedHeading = "Xem Thêm Các Sản Phẩm Khác";
                ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING] = "Xem Thêm Các Sản Phẩm Khác";
            }
            else
            {
                // ViewBag.Heading = "Có Thể Bạn Quan Tâm";
               // ViewBagUtility.ProductRelatedHeading = "Có Thể Bạn Quan Tâm";
                ViewData[ViewDataUtility.PRODUCT_RELATED_HEADING] = "Có Thể Bạn Quan Tâm";
            }



            return View(data.ToList());
        }
    }
}
