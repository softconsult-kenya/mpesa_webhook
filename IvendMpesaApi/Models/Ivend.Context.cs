﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IVENDEntities : DbContext
    {
        public IVENDEntities()
            : base("name=IVENDEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Audit> Audits { get; set; }
        public virtual DbSet<AutoAuth> AutoAuths { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<ContactAtr> ContactAtrs { get; set; }
        public virtual DbSet<ContactGroup> ContactGroups { get; set; }
        public virtual DbSet<ContactGroupsAtr> ContactGroupsAtrs { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<GlobalAtr> GlobalAtrs { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<MPESA_C2B> MPESA_C2B { get; set; }
        public virtual DbSet<MPESA_C2B_IMPORT> MPESA_C2B_IMPORT { get; set; }
        public virtual DbSet<MPESA_C2B_REVERSAL> MPESA_C2B_REVERSAL { get; set; }
        public virtual DbSet<Msg> Msgs { get; set; }
        public virtual DbSet<MsgTemplate> MsgTemplates { get; set; }
        public virtual DbSet<REPORT> REPORTS { get; set; }
        public virtual DbSet<Right> Rights { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<tblBankPayment> tblBankPayments { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<MPESA_C2B_ARCH> MPESA_C2B_ARCH { get; set; }
        public virtual DbSet<MPESA_C2B_ARCH_EXP> MPESA_C2B_ARCH_EXP { get; set; }
        public virtual DbSet<MPESA_C2B_REVERSAL_EXP> MPESA_C2B_REVERSAL_EXP { get; set; }
        public virtual DbSet<tblBankPayments_EXP> tblBankPayments_EXP { get; set; }
        public virtual DbSet<tblEzzypay> tblEzzypays { get; set; }
        public virtual DbSet<tblEzzypay_ARCH> tblEzzypay_ARCH { get; set; }
        public virtual DbSet<tblEzzypay_ARCH_EXP> tblEzzypay_ARCH_EXP { get; set; }
    }
}
