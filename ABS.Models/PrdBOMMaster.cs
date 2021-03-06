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
    
    public partial class PrdBOMMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PrdBOMMaster()
        {
            this.PrdBOMSizes = new HashSet<PrdBOMSize>();
            this.PrdBOMDyings = new HashSet<PrdBOMDying>();
            this.PrdPreCostingMasters = new HashSet<PrdPreCostingMaster>();
        }
    
        public long BOMID { get; set; }
        public string BOMNO { get; set; }
        public Nullable<System.DateTime> BOMDate { get; set; }
        public string Description { get; set; }
        public long ItemID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public Nullable<int> StatusBy { get; set; }
        public Nullable<System.DateTime> StatusOn { get; set; }
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
        public virtual ICollection<PrdBOMSize> PrdBOMSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdBOMDying> PrdBOMDyings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdPreCostingMaster> PrdPreCostingMasters { get; set; }
        public virtual CmnItemMaster CmnItemMaster { get; set; }
    }
}
