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
    
    public partial class CmnWFApprovalPendingList
    {
        public long TransactionID { get; set; }
        public Nullable<bool> IsApprove { get; set; }
        public string Comment { get; set; }
        public Nullable<int> CurrentUserID { get; set; }
        public Nullable<int> PreviousUserID { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public Nullable<int> PreviousStatusID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public string Status { get; set; }
        public string Amount { get; set; }
    }
}
