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
    
    public partial class PrdBallMRRConsumption
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrdBallMRRConsumption()
        {
            this.PrdBallMRRDetails = new HashSet<PrdBallMRRDetail>();
        }
    
        public long BallConsumptionID { get; set; }
        public long YarnCountID { get; set; }
        public Nullable<long> SupplierID { get; set; }
        public Nullable<long> DepartmentID { get; set; }
        public Nullable<long> LotID { get; set; }
        public Nullable<decimal> LengthM { get; set; }
        public Nullable<decimal> LengthYds { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Qty { get; set; }
        public Nullable<int> Unit { get; set; }
        public string Remarks { get; set; }
        public Nullable<long> TransactionTypeID { get; set; }
        public Nullable<System.DateTime> IssueDate { get; set; }
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
        public virtual ICollection<PrdBallMRRDetail> PrdBallMRRDetails { get; set; }
    }
}