//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CustomerAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAccount()
        {
            this.LoanAccountDetails = new HashSet<LoanAccountDetail>();
        }
    
        public Nullable<int> CustID { get; set; }
        public int AccNum { get; set; }
        public string AccountType { get; set; }
        public string AccountSubType { get; set; }
    
        public virtual SavingAccountDetail SavingAccountDetail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LoanAccountDetail> LoanAccountDetails { get; set; }
        public virtual CustomerDetail CustomerDetail { get; set; }
    }
}