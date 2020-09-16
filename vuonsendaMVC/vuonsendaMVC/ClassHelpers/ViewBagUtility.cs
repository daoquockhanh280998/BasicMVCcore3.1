using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vuonsendaMVC.ClassHelpers
{
    internal class _ViewBagUtility : ViewComponent
    {
        public string ProductRelatedHeading
        {
            get
            {
                return ViewBag.ProductRelatedHeading;
            }
            set
            {
                ViewBag.ProductRelatedHeading = value;
            }
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
    public class ViewBagUtility
    {
        internal static _ViewBagUtility x = new _ViewBagUtility();
        public static string ProductRelatedHeading
        {
            get
            {
                return x.ProductRelatedHeading;
            }
            set
            {
                x.ProductRelatedHeading = value;
            }
        }
    }
}
