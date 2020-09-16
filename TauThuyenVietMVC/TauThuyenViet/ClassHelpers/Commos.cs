﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TauThuyenViet.ClassHelpers
{
    public static class Commos
    {
        public static string SplitImages(this string value)
        {
            string[] segments = value.Split('\n');
            if (segments.Length > 0)
            {
                return segments[0];
            }
            else
            {
                return string.Empty;
            }
        }

        public static string ToUrlFormat(this string value)
        {
            string result = value;
            result = value.Replace(" ", "-").Replace("/", "-");

            Regex regex = new Regex("-+");
            result = regex.Replace(result, "-");

            // bỏ dấu tiếng việt
            regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            result = result.Normalize(NormalizationForm.FormD);
            result = regex.Replace(result, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
            return result.ToLower();
        }

        public static bool IsNullOrEmtyOrWhiteSpace (this string value)
        {
            if (value == null)
            {
                return true;
            }
            if (value.ToString().Trim() == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
