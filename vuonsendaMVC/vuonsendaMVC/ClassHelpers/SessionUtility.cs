using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vuonsendaMVC.ClassHelpers
{
    public class SessionUtility
    {
        public static  string AcountEmail { get; set; }
        public static string AcountFullName { get; set; }

        public static string AcountPassWord { get; set; }
        public const string CLIENT_EMAIL = "ClientEmail";
    }
}
