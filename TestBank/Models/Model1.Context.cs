﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestBank.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TestBankDBEntities1 : DbContext
    {
        public TestBankDBEntities1()
            : base("name=TestBankDBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; }
        public virtual DbSet<LoanAccountDetail> LoanAccountDetails { get; set; }
        public virtual DbSet<LoanEMIDetail> LoanEMIDetails { get; set; }
        public virtual DbSet<PostalCode> PostalCodes { get; set; }
        public virtual DbSet<SavingAccountDetail> SavingAccountDetails { get; set; }
        public virtual DbSet<SavingAccountTxnHistory> SavingAccountTxnHistories { get; set; }
        public virtual DbSet<State> States { get; set; }
    }
}
