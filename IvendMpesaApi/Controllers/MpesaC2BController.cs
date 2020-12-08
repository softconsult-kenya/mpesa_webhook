using IvendMpesaApi.Models;
using IvendMpesaApi.Models.Repositories;
using smcaptureLib.Globals.KendoSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;
using static IvendMpesaApi.Models.Repositories.MpesaC2BRepository;

namespace IvendMpesaApi.Controllers
{
    [RoutePrefix("MpesaC2B")]
    public class MpesaC2BController : ApiController
    {
        [Route("GetMpesaC2B"), HttpGet]
        public IHttpActionResult GetMpesaC2B(NeedDataSourceEventArgs args)
        {
            var repo = new MpesaC2BRepository();
            try
            {

                ExecutionResult res = repo.GetMpesaC2B(args);
                if (res.IsOkay)
                    return new NegotiatedContentResult<ExecutionResult>(HttpStatusCode.OK, res, this);
                else
                    return new NegotiatedContentResult<ExecutionResult>(HttpStatusCode.NotFound, res, this);
            }
            catch (Exception ex)
            {
                var res = new ExecutionResult(false, ex.Message, ex);
                return new NegotiatedContentResult<ExecutionResult>(HttpStatusCode.InternalServerError, res, this);
            }
        }

        [Route("AddMpesaC2B"), HttpPost]
        public IHttpActionResult Add([FromBody] mpesaObj dta)
        {
            var result = new ExecutionResult(false, "error");

            var repository = new MpesaC2BRepository();
            result = repository.AddMpesaC2B(dta);

            if (result.IsOkay)
                return new NegotiatedContentResult<ExecutionResult>(HttpStatusCode.OK, result, this);
            else
                return new NegotiatedContentResult<ExecutionResult>(HttpStatusCode.NotFound, result, this);

        }
    }
}
