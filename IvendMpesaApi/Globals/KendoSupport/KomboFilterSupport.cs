using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smcaptureLib.Globals.KendoSupport
{
    public static class KomboFilterSupport
    {
        public static ItemsRequestedResult<NeedDataSourceEventArgs> ProcessAlreadyFiltered<T, TOrderBy>(NeedDataSourceEventArgs args, IEnumerable<T> results, Func<T, TOrderBy> orderbyDefault)
        {
            var count = results.Count();

            var itemsResult = new ItemsRequestedResult<NeedDataSourceEventArgs>() { request = args };
            if (results != null && results.Count() > 0)
            {
                itemsResult.isSuccessull = true;
                itemsResult.DataSetCount = count;
                results = results.Skip(args.skip).Take(args.take);
                itemsResult.Result = results.ToList<T>();
            }
            else
            {
                itemsResult.isSuccessull = false;
                itemsResult.Result = new List<T>();
                itemsResult.DataSetCount = 0;
            }
            return itemsResult;
        }
    }
}
