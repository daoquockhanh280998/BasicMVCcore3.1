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
    public class ClientRegisterController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public ClientRegisterController(DBContext context)
        {
            db = context;
        }

        [Route("dang-ky", Name = "register")]
        public IActionResult Index̣̣()
        {
            ViewBag.ContactMessage = "Mời Quý Khách Nhập Thông Tin Tài Khoản";
            ViewBag.ContactMessageType = "info";
            return View();
        }

        [HttpPost]
        [Route("dang-ky", Name = "register")]
        public IActionResult Index̣̣(Client item)
        {
            
            //kiểm tra dữ liệu nhập vào hay chưa
            if (item.Email.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Email";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.Password.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Mật Khẩu";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.RePassword.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Lại Mật Khẩu";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.FullName.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Họ Tên";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            if (item.Address.IsNullOrEmptyOrWhiteSpace())
            {
                ViewBag.ContactMessage = "Mời Quý Khách Nhập Địa Chỉ";
                ViewBag.ContactMessageType = "Warning";
                return View();
            }
            db.Client.Add(item);
            db.SaveChanges();

            //thông báo Đăng Kí thành công
            ViewBag.ContactMessage = "Đã Đăng Kí Tài Khoản Thành Công";
            ViewBag.ContactMessageType = "Success";

            //xóa form (còn gọi là xóa trắng trạng thái)
            ModelState.Clear();


            return View();

        }

       
    }
}
