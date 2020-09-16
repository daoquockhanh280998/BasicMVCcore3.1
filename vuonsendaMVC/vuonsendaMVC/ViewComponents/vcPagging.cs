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
    public class vcPagging : ViewComponent
    {
        public IViewComponentResult Invoke(int totals, int pagesize, int page, string url, int maxPage)
        {
            int totalPages = (int)Math.Ceiling((double)totals / pagesize);
            int pageFirst = 1;
            int pageLast = totalPages;
            int pageBack = page - 1;
            if (pageBack == 0)
            {
                pageBack = 1;
            }

            int pageNext = page + 1;
            if (pageNext > pageLast)
            {
                pageNext = pageLast;
            }

            string pageFisrtUrl = string.Format(url, pageFirst);
            string pageLastUrl = string.Format(url, pageLast);
            string pageBackUrl = string.Format(url, pageBack);
            string pageNextUrl = string.Format(url, pageNext);

            // khai bao dictionary de lu tru key va value trong đó key là số trang hiện tại nếu giống thì sáng lên , còn value là dg dẫn trang đó
            Dictionary<int, string> pageNumbers = new Dictionary<int, string>();
            for (int i = pageFirst; i <= pageLast; i++)
            {
                pageNumbers.Add(i, string.Format(url, i));
            }

            //tạo 1 class helper để chứa các Url đặt tên là PaggingDatasource
            PaggingDatasource datasource = new PaggingDatasource();
            datasource.PageFirstUrl = pageFisrtUrl;
            datasource.PageLastUrl = pageLastUrl;
            datasource.PageBackUrl = pageBackUrl;
            datasource.PageNextUrl = pageNextUrl;
            datasource.Page = page;
            datasource.PageNumbers = pageNumbers;


            return View(datasource);
        }
    }
}
