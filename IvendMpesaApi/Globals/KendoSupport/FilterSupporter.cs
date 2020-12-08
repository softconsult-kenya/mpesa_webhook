using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smcaptureLib.Globals.KendoSupport
{
    public class FilterSupporter<T> where T : class, new()
    {
        private FilterUtility<T> util;

        public FilterSupporter() { }
        public ItemsRequestedResult<NeedDataSourceEventArgs> itemsResult { private set; get; }

        public FilterSupporter(IEnumerable<T> data, NeedDataSourceEventArgs args)
        {
            this.util = new FilterUtility<T>(data, args);
        }

        public IEnumerable<T> FilterData<TOrderBy>(Func<T, TOrderBy> orderbyDefault)
        {
            int count = 0;
            IEnumerable<T> results = this.util.Filter(out count).OrderBy(orderbyDefault);

            itemsResult = new ItemsRequestedResult<NeedDataSourceEventArgs>() { request = util.NeedDataSourceEventArgs };
            if (results != null && results.Count() > 0)
            {
                itemsResult.isSuccessull = true;
                itemsResult.Result = results.ToList<T>();
                itemsResult.DataSetCount = count;
            }
            else
            {
                itemsResult.isSuccessull = false;
                itemsResult.Result = null;
                itemsResult.DataSetCount = 0;
            }
            return results;
        }
        public IEnumerable<T> FilterDataOrdeyByDesceding<TOrderBy>(Func<T, TOrderBy> orderbyDefault)
        {
            int count = 0;
            IEnumerable<T> results = this.util.Filter(out count).OrderByDescending(orderbyDefault);

            itemsResult = new ItemsRequestedResult<NeedDataSourceEventArgs>() { request = util.NeedDataSourceEventArgs };
            if (results != null && results.Count() > 0)
            {
                itemsResult.isSuccessull = true;
                itemsResult.Result = results.ToList<T>();
                itemsResult.DataSetCount = count;
            }
            else
            {
                itemsResult.isSuccessull = false;
                itemsResult.Result = null;
                itemsResult.DataSetCount = 0;
            }
            return results;
        }
    }
}
