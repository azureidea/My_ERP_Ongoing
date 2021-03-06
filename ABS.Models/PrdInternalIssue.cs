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
    
    public partial class PrdInternalIssue
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrdInternalIssue()
        {
            this.PrdInternalIssueDetails = new HashSet<PrdInternalIssueDetail>();
        }
    
        public long IssueID { get; set; }
        public int TransactionTypeID { get; set; }
        public string IssueNo { get; set; }
        public Nullable<long> ItemID { get; set; }
        public Nullable<long> SetID { get; set; }
        public Nullable<long> BalMRRID { get; set; }
        public int DepartmentID { get; set; }
        public Nullable<bool> IsIssuedBall { get; set; }
        public Nullable<System.DateTime> IssBallDate { get; set; }
        public Nullable<int> IssBallBy { get; set; }
        public string IssBallRemarks { get; set; }
        public Nullable<bool> IsReceivedDy { get; set; }
        public Nullable<System.DateTime> ReceivedDyDate { get; set; }
        public Nullable<int> ReceivedDyBy { get; set; }
        public string ReceivedDyRemarks { get; set; }
        public Nullable<bool> IsIssuedDy { get; set; }
        public Nullable<System.DateTime> IssDyDate { get; set; }
        public Nullable<int> IssDyBy { get; set; }
        public string IssDyRemarks { get; set; }
        public Nullable<bool> IsReceivedLCB { get; set; }
        public Nullable<System.DateTime> ReceivedLCBDate { get; set; }
        public Nullable<int> ReceivedLCBBy { get; set; }
        public string ReceivedLCBRemarks { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreatePc { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateOn { get; set; }
        public string UpdatePc { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<int> DeleteBy { get; set; }
        public Nullable<System.DateTime> DeleteOn { get; set; }
        public string DeletePc { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdInternalIssueDetail> PrdInternalIssueDetails { get; set; }
        public virtual CmnItemMaster CmnItemMaster { get; set; }
        public virtual PrdSetSetup PrdSetSetup { get; set; }
    }
}
