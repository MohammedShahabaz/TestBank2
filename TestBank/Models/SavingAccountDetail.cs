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
    
    public partial class SavingAccountDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SavingAccountDetail()
        {
            this.SavingAccountTxnHistories = new HashSet<SavingAccountTxnHistory>();
        }
    
        public int AccNum { get; set; }
        public string SavingAccType { get; set; }
        public string IFSCcode { get; set; }
        public int Balance { get; set; }
        public int TrasferLimit { get; set; }
        public int BranchCode { get; set; }
    
        public virtual CustomerAccount CustomerAccount { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SavingAccountTxnHistory> SavingAccountTxnHistories { get; set; }
    }
}
