//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IvendMpesaApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBankPayments_EXP
    {
        public long id { get; set; }
        public string amount { get; set; }
        public string authCode { get; set; }
        public string cardExpiry { get; set; }
        public string cashBack { get; set; }
        public string currency { get; set; }
        public string invoiceNo { get; set; }
        public string mid { get; set; }
        public string msg { get; set; }
        public string pan { get; set; }
        public string paymentDetails { get; set; }
        public string respCode { get; set; }
        public string rrn { get; set; }
        public string tid { get; set; }
        public string transactionType { get; set; }
        public string user { get; set; }
        public string tillNo { get; set; }
        public string used { get; set; }
        public string @lock { get; set; }
        public Nullable<System.DateTime> transDate { get; set; }
        public string Bank { get; set; }
        public string CardType { get; set; }
        public string Reconciled { get; set; }
    }
}
