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
    
    public partial class InvStockDetail
    {
        public long StockDetailID { get; set; }
        public int StockID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<long> TransactionID { get; set; }
        public int TransactionTypeID { get; set; }
        public System.DateTime StockDate { get; set; }
        public long ItemID { get; set; }
        public Nullable<int> ItemTypeID { get; set; }
        public Nullable<long> LotID { get; set; }
        public Nullable<int> GradeID { get; set; }
        public Nullable<long> BatchID { get; set; }
        public string LotNo { get; set; }
        public Nullable<int> SupplierID { get; set; }
        public Nullable<decimal> ReceiveQty { get; set; }
        public Nullable<decimal> ReceiveValue { get; set; }
        public Nullable<decimal> ReceiveRate { get; set; }
        public Nullable<decimal> IssueQty { get; set; }
        public Nullable<int> UOMID { get; set; }
        public Nullable<decimal> IssueRate { get; set; }
        public Nullable<decimal> IssueValue { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CompanyID { get; set; }
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
    }
}