using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smcaptureLib.Globals.KendoSupport
{
    public class ItemsRequestedResult<T>
    {
        public T request { get; set; }
        public bool isSuccessull { get; set; }
        public int DataSetCount { get; set; }

        public Object Result { get; set; }
        public ItemsRequestedResult()
            : base()
        {


        }
    }

}
