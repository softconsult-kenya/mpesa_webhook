using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smcaptureLib.Globals.KendoSupport
{
    public class NeedDataSourceEventArgs
    {
        public int take { get; set; }
        public int skip { get; set; }
        public int page { get; set; }
        public int pageSize { get; set; }
        public filter filter { get; set; }
        public List<sort> sort { get; set; }

    }
}
