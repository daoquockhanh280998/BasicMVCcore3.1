using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TauThuyenViet.ClassHelpers;
using TauThuyenViet.Models;

namespace TauThuyenViet.Controllers
{
    public class ContactController : Controller
    {
        //khai bao1 dbcontext dùng chung
        DBContext db;

        public ContactController(DBContext context)
        {
            db = context;
        }

        [Route("lienhe", Name = "Contact")]
        public IActionResult Index()
        {
            //lấy dữ liệu ban đầu
            ViewBag.ContactMessage = "Mời quý khách nhập nội dung cần liên hệ";
            ViewBag.ContactMessageType = "info";
            return View();
        }
        
        [HttpPost] // post có nghĩa là gửi lên
        [Route("lienhe", Name = "Contact")]
        public IActionResult Index(Contact item)
        {
            //kiểm tra dữ liệu
            if (item.FullName.IsNullOrEmtyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời quý khách nhập họ tên";
                ViewBag.ContactMessageType = "warning";
                return View();
            }
            if (item.Mobi.IsNullOrEmtyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời quý khách nhập số điện thoại";
                ViewBag.ContactMessageType = "warning";
                return View();
            }
            if (item.Content.IsNullOrEmtyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời quý khách nhập Nội Dung";
                ViewBag.ContactMessageType = "warning";
                return View();
            }

            db.Contact.Add(item);
            db.SaveChanges();

            //hiện thông báo thành công
            ViewBag.ContactMessage = "Đã Gửi Thư Thành Công";
            ViewBag.ContactMessageType = "Success";

            ModelState.Clear();
            return View();
        }
    }
}
