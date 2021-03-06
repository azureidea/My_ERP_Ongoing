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
    
    public partial class MntMachineMaintenanceOrder
    {
        public long MaintenanceID { get; set; }
        public string MaintenanceNo { get; set; }
        public Nullable<long> MachineConfigID { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Reason { get; set; }
        public bool IsMaintenance { get; set; }
        public Nullable<System.DateTime> MaintenanceDate { get; set; }
        public bool IsReleased { get; set; }
        public Nullable<int> MaintenanceEmployeeID { get; set; }
        public Nullable<System.DateTime> ReleaseDate { get; set; }
        public string ReleaseRemarks { get; set; }
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
    
        public virtual CmnOrganogram CmnOrganogram { get; set; }
        public virtual PrdWeavingMachinConfig PrdWeavingMachinConfig { get; set; }
        public virtual CmnUser CmnUser { get; set; }
        public virtual CmnUser CmnUser1 { get; set; }
    }
}
