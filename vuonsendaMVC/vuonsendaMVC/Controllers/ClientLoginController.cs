using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using vuonsendaMVC.ClassHelpers;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.Controllers
{

    public class ClientLoginController : Controller
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        private object context;

        public ClientLoginController(DBContext context)
        {
            db = context;
        }

        [Route("dang-nhap", Name = "login")]
        public IActionResult Index̣̣()
        {
            ViewBag.ContactMessage = "Mời Quý Khách Nhập Thông Tin Tài Khoản";
            ViewBag.ContactMessageType = "info";
            return View();
        }

        [HttpPost]
        [Route("dang-nhap", Name = "login")]
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

            string email = item.Email.Trim();
            string password = item.Password.Trim();
            var query = db.Client.Where(x => x.Email == email && x.Password == password).FirstOrDefault();

            //KIỂM TRA TỒN TẠI HAY K
            if (query == null)
            {
                ViewBag.ContactMessage = "Tài Khoản Hoặc Mật Khẩu Bị Sai Vui Lòng Kiểm Tra Lại";
                ViewBag.ContactMessageType = "danger";
                return View();
            }

            //lưu vào session
            //SessionUtility.AcountEmail = item.Email;
            //SessionUtility.AcountFullName = item.FullName;
            //SessionUtility.AcountPassWord = item.Password;
            HttpContext.Session.SetInt32("ClientID",query.ClientID);
            HttpContext.Session.SetString(SessionUtility.CLIENT_EMAIL, query.Email);
            HttpContext.Session.SetString("ClientFullName", query.FullName);
            HttpContext.Session.SetString("ClientPassword", query.Password);
            //đăng nhập thành công chuyển về trang chủ
            return RedirectToRoute("home");
        }

    }
}
