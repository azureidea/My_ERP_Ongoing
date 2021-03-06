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
    
    public partial class SalLCDetail
    {
        public long LCDetailID { get; set; }
        public string CustomCode { get; set; }
        public Nullable<long> LCID { get; set; }
        public string PINo { get; set; }
        public Nullable<long> PIID { get; set; }
        public string LCReferenceNo { get; set; }
        public Nullable<bool> IsHDOCompleted { get; set; }
        public string AmendmentNo { get; set; }
        public Nullable<System.DateTime> AmendmentDate { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> StatusBy { get; set; }
        public Nullable<int> BranchID { get; set; }
        public int CompanyID { get; set; }
        public int DBID { get; set; }
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
    
        public virtual SalPIMaster SalPIMaster { get; set; }
    }
}
