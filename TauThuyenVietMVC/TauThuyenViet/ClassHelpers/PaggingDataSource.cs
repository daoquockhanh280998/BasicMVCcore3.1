using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TauThuyenViet.ClassHelpers
{
    public class PaggingDataSource
    {
        public string PageFirstUrl { get; set; }
        public string PageLastUrl { get; set; }
        public string PageBackUrl { get; set; }
        public string PageNextUrl { get; set; }
        public int page { get; set; }

      public  Dictionary<int , string> PageNumbers { get; set; }
    }
}
