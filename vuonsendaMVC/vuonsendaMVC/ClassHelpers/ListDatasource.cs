using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vuonsendaMVC.Models;

namespace vuonsendaMVC.ClassHelpers
{
    public class ListDatasource
    {
        public int Totals { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int MaxPage { get; set; }
        public string Url { get; set; }

       public IEnumerable<object> Data { get; set; }
    }
}
