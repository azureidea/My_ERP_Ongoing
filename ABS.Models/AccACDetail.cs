//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ABS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AccACDetail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccACDetail()
        {
            this.AccVoucherDetails = new HashSet<AccVoucherDetail>();
        }
    
        public int AC1Id { get; set; }
        public int AC2Id { get; set; }
        public int AC3Id { get; set; }
        public int AC4Id { get; set; }
        public int Id { get; set; }
        public string ACode { get; set; }
        public string ACName { get; set; }
        public string EntryType { get; set; }
        public string TransactionType { get; set; }
        public string ReportHead { get; set; }
        public Nullable<bool> Transfered { get; set; }
        public Nullable<int> AddedBy { get; set; }
        public Nullable<System.DateTime> DateAdded { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
        public Nullable<double> OpeningBalance { get; set; }
        public Nullable<System.DateTime> OpeningBalanceDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual AccAC4 AccAC4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccVoucherDetail> AccVoucherDetails { get; set; }
    }
}
