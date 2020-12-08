using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smcaptureLib.Globals.KendoSupport
{
    public class ItemRequestedEventArgs
    {
        public object SearchText { get; set; }
        public string PageSize { get; set; }
        public string CurrentPage { get; set; }


    }
}
