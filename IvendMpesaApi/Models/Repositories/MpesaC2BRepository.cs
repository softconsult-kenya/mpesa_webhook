using smcaptureLib.Globals.KendoSupport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI.WebControls;

namespace IvendMpesaApi.Models.Repositories
{
    public class MpesaC2BRepository
    {



        public ExecutionResult GetMpesaC2B(NeedDataSourceEventArgs args)
        {

            var res = new ExecutionResult(true, "Error");

            try
            {
                using (var entity = new IVENDEntities())
                {
                    entity.Configuration.LazyLoadingEnabled = false;
                    entity.Configuration.ProxyCreationEnabled = false;


                    var datafind = entity.MPESA_C2B
                        .ToList();



                    var filtered = new FilterSupporter<MPESA_C2B>(datafind, args);
                    var result = filtered.FilterData(r => r.ID);
                    res.Result = filtered.itemsResult;
                    res.Message = "Mpesa Data found";
                    res.IsOkay = true;

                }

            }
            catch (Exception ex)
            {
                res.Message = ex.Message;

            }


            return res;
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
        public ExecutionResult AddMpesaC2B(mpesaObj data)
        {
            var res = new ExecutionResult(true, "Error");
            try
            {
                using (var entity = new IVENDEntities())
                {
                    entity.Configuration.LazyLoadingEnabled = false;
                    entity.Configuration.ProxyCreationEnabled = false;

                    //mpesa api intergration
                    String a = "https://sandbox.safaricom.co.ke/mpesa/transactionstatus/v1/query";
                    string baseUrl = a;
                    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl);
                    String token = "ACCESS_TOKEN";
                    request.Headers.Add("authorization", "Bearer " + token);
                    request.ContentType = "application/json";
                    request.Headers.Add("cache-control", "no-cache");
                    request.Method = "POST";



                    //end of mpesa api 


                    var new_client = new MPESA_C2B()
                        {
                            TransactionType = data.transactiontype,
                            TransID = data.transid,
                            TransTime = data.transtime,
                            TransAmount = data.transamount,
                            BillRefNumber = data.BillRefNumber,
                            MSISDN = data.MSISDN,
                            FirstName = data.FirstName,
                            MSG = data.MSG,
                        };
                        entity.MPESA_C2B.Add(new_client);
                        entity.SaveChanges();
                        res.Result = new_client;
                        res.Message = "Mpesa Data Saved successfuly";
                        res.IsOkay = true;
                   
                }
            }
            catch (Exception ex)
            {
                res.Message = ex.Message;
            }


            return res;
        }



        //public ExecutionResult AddMpesaC2B(MPESA_C2B data)
        //{
        //    var res = new ExecutionResult(true, "Error");
        //    try
        //    {
        //        using (var entity = new IVENDEntities())
        //        {
        //            entity.Configuration.LazyLoadingEnabled = false;
        //            entity.Configuration.ProxyCreationEnabled = false;

        //            //mpesa api intergration

        //            //end of mpesa api 


        //            var new_client = new MPESA_C2B()
        //            {
        //                TransactionType = data.TransactionType,
        //                TransID = data.TransID,
        //                TransTime = data.TransTime,
        //                TransAmount = data.TransAmount,
        //                BillRefNumber = data.BillRefNumber,
        //                MSISDN = data.MSISDN,
        //                FirstName = data.FirstName,
        //                MSG = data.MSG,
        //            };
        //            entity.MPESA_C2B.Add(new_client);
        //            entity.SaveChanges();
        //            res.Result = new_client;
        //            res.Message = "Mpesa Data Saved successfuly";
        //            res.IsOkay = true;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        res.Message = ex.Message;
        //    }


        //    return res;
        //}
        public class mpesaObj
        {
            public int id { get; set; }
            public string transactiontype { get; set; }
            public string transid { get; set; }
            public string transtime { get; set; }
            public Nullable<decimal> transamount { get; set; }
            public string businessshortcode { get; set; }
            public string BillRefNumber { get; set; }
            public string InvoiceNumber { get; set; }
            public string ThirdPartyTransID { get; set; }
            public string MSISDN { get; set; }
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
            public string MSG { get; set; }
            public string PostedBy { get; set; }
            public string Status { get; set; }
            public string TillId { get; set; }
            
        }
    }
}