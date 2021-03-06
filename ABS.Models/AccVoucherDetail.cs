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
    
    public partial class AccVoucherDetail
    {
        public int Id { get; set; }
        public int VMasterId { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<int> CostCenterId { get; set; }
        public int AC5Id { get; set; }
        public decimal DebitAmount { get; set; }
        public decimal CreditAmount { get; set; }
        public string TransactionType { get; set; }
        public string Others { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        public virtual AccACDetail AccACDetail { get; set; }
        public virtual AccVoucherMaster AccVoucherMaster { get; set; }
        public virtual AccCostCenterInfo AccCostCenterInfo { get; set; }
    }
}
