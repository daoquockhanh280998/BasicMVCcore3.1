using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vuonsendaMVC.ClassHelpers
{
    public class PaggingDatasource
    {
        public string PageFirstUrl { get; set; }
        public string PageLastUrl { get; set; }
        public string PageBackUrl { get; set; }
        public string PageNextUrl { get; set; }
        public int Page { get; set; }

       public Dictionary<int,string> PageNumbers { get; set; }
    }
}
