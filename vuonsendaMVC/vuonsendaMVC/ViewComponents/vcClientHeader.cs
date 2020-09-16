using Microsoft.AspNetCore.Http;
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
    public class vcClientHeader : ViewComponent
    {
        //khai báo dbcontext dùng chung
        DBContext db;
        public vcClientHeader(DBContext context)
        {
            db = context;
        }

        public IViewComponentResult Invoke()
        {
        
            //if (SessionUtility.CLIENT_EMAIL == null)
            //{
            //    ViewBag.ClientRoute = "login";
            //    ViewBag.ClientContent = "Đăng Nhập | Đăng Kí";
            //}
            //else
            //{
            //    ViewBag.ClientRoute = "Client";
            //    ViewBag.ClientContent = "Tài Khoản Của Bạn";
            //}


            return View();
        }
    }
}
