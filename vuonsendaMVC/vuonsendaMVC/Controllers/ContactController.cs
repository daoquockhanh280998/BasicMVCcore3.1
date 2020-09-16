using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{
    public class ContactController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public ContactController(DBContext context)
        {
            db = context;
        }

        [Route("lien-he", Name = "contact")]
        public IActionResult Index̣̣()
        {
            // lấy dữ liệu ban đầu
            ViewBag.ContactMessage = "Mời Quý Khách Nhập Nội Dung Liên Hệ";
            ViewBag.ContactMessageType = "info";
            return View();
        }

        [HttpPost]
        [Route("lien-he", Name = "contact")]
        public IActionResult Index̣̣(Contact item)
        {
            //kiểm tra dữ liệu
            if (item.FullName.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Họ Tên";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.Email.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Email";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.Mobi.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Số Điện Thoại";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.Content.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Nội Dung";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }

            db.Contact.Add(item);
            db.SaveChanges();

            //thông báo gửi thư thành công
            ViewBag.ContactMessage = "Đã Gửi Thư Liên Hệ Thành Công";
            ViewBag.ContactMessageType = "Success";

            //xóa form (còn gọi là xóa trắng trạng thái)
            ModelState.Clear();

            return View();
        }
    }
}
