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
    
    public partial class tblEzzypay
    {
        public int Id { get; set; }
        public string TillNumber { get; set; }
        public string MobileNumber { get; set; }
        public string Amount { get; set; }
        public string TimeStamp { get; set; }
        public string TransactionRefNo { get; set; }
        public string ServedBy { get; set; }
        public string AdditionalInfo { get; set; }
        public Nullable<System.DateTime> Transdate { get; set; }
        public bool Consumed { get; set; }
        public string CustomerName { get; set; }
        public string Status { get; set; }
    }
}
