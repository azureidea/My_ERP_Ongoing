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
    
    public partial class CmnItemMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CmnItemMaster()
        {
            this.InvMrrDetails = new HashSet<InvMrrDetail>();
            this.InvRChallanDetails = new HashSet<InvRChallanDetail>();
            this.InvRequisitionDetails = new HashSet<InvRequisitionDetail>();
            this.PrdBOMDyings = new HashSet<PrdBOMDying>();
            this.PrdBOMMasters = new HashSet<PrdBOMMaster>();
            this.PrdBOMSizes = new HashSet<PrdBOMSize>();
            this.PrdDyingChemicalSetupDetails = new HashSet<PrdDyingChemicalSetupDetail>();
            this.PrdDyingConsumptionMasters = new HashSet<PrdDyingConsumptionMaster>();
            this.PrdDyingMachineParts = new HashSet<PrdDyingMachinePart>();
            this.PrdFinishingChemicalSetupDetails = new HashSet<PrdFinishingChemicalSetupDetail>();
            this.PrdFinishingMRRMasters = new HashSet<PrdFinishingMRRMaster>();
            this.PrdFinishingPackingLists = new HashSet<PrdFinishingPackingList>();
            this.PrdFinishingQAMasters = new HashSet<PrdFinishingQAMaster>();
            this.PrdFinishingTypes = new HashSet<PrdFinishingType>();
            this.PrdInternalIssues = new HashSet<PrdInternalIssue>();
            this.PrdPreCostingDyings = new HashSet<PrdPreCostingDying>();
            this.PrdPreCostingMasters = new HashSet<PrdPreCostingMaster>();
            this.PrdPreCostingSizes = new HashSet<PrdPreCostingSize>();
            this.PrdPreCostingYarns = new HashSet<PrdPreCostingYarn>();
            this.PrdSizingBeamIssues = new HashSet<PrdSizingBeamIssue>();
            this.PrdSizingChemicalSetups = new HashSet<PrdSizingChemicalSetup>();
            this.PrdSizingChemicalSetupDetails = new HashSet<PrdSizingChemicalSetupDetail>();
            this.PrdWastageDetails = new HashSet<PrdWastageDetail>();
            this.PrdWeavingMachinConfigs = new HashSet<PrdWeavingMachinConfig>();
            this.PrdWeavingMachineConfigDetails = new HashSet<PrdWeavingMachineConfigDetail>();
            this.PrdWeavingMachineSetups = new HashSet<PrdWeavingMachineSetup>();
            this.PrdWeavingMRRMasters = new HashSet<PrdWeavingMRRMaster>();
            this.PurchasePODetails = new HashSet<PurchasePODetail>();
            this.SalBookingDetails = new HashSet<SalBookingDetail>();
            this.PrdDyingMachineSetups = new HashSet<PrdDyingMachineSetup>();
            this.PrdDyingMachineSetups1 = new HashSet<PrdDyingMachineSetup>();
            this.PrdDyingMRRMasters = new HashSet<PrdDyingMRRMaster>();
            this.PrdDyingMRRMasters1 = new HashSet<PrdDyingMRRMaster>();
            this.PrdDyingOperationSetups = new HashSet<PrdDyingOperationSetup>();
            this.PrdDyingOperationSetups1 = new HashSet<PrdDyingOperationSetup>();
            this.PrdSizingChemicalConsumptions = new HashSet<PrdSizingChemicalConsumption>();
            this.PrdSizingChemicalconsumptionDetails = new HashSet<PrdSizingChemicalconsumptionDetail>();
            this.InvMrrQcDetails = new HashSet<InvMrrQcDetail>();
            this.InvIssueDetails = new HashSet<InvIssueDetail>();
            this.PrdSetSetups = new HashSet<PrdSetSetup>();
            this.PrdDyingConsumptionChemicals = new HashSet<PrdDyingConsumptionChemical>();
        }
    
        public long ItemID { get; set; }
        public string ArticleNo { get; set; }
        public string BaseArticleNo { get; set; }
        public Nullable<int> TransactionTypeID { get; set; }
        public int IsDevelopmentComplete { get; set; }
        public Nullable<int> ItemTypeID { get; set; }
        public Nullable<int> ItemGroupID { get; set; }
        public string ItemName { get; set; }
        public Nullable<long> WarpYarnID { get; set; }
        public Nullable<long> WeftYarnID { get; set; }
        public Nullable<int> WeftColorID { get; set; }
        public Nullable<int> WeftSupplierID { get; set; }
        public string Weave { get; set; }
        public Nullable<int> ItemColorID { get; set; }
        public string SetNo { get; set; }
        public string FlangeNo { get; set; }
        public Nullable<decimal> Length { get; set; }
        public Nullable<decimal> CuttableWidth { get; set; }
        public Nullable<decimal> WeightPerUnit { get; set; }
        public Nullable<int> CoatingID { get; set; }
        public Nullable<int> SPCoatingID { get; set; }
        public Nullable<int> OverDyedID { get; set; }
        public Nullable<int> BuyerID { get; set; }
        public Nullable<int> BuyerRefID { get; set; }
        public Nullable<decimal> TotalEnds { get; set; }
        public Nullable<decimal> NoOfPick { get; set; }
        public Nullable<int> WeightUOMID { get; set; }
        public Nullable<int> FinishingWeightID { get; set; }
        public Nullable<decimal> FinishingWidth { get; set; }
        public Nullable<long> WeavingMachineID { get; set; }
        public Nullable<decimal> WeavingLength { get; set; }
        public Nullable<decimal> GEPI { get; set; }
        public Nullable<decimal> GPPI { get; set; }
        public Nullable<decimal> GWidth { get; set; }
        public Nullable<System.DateTime> WeavingDate { get; set; }
        public Nullable<decimal> GGSM { get; set; }
        public Nullable<int> WashingTypeID { get; set; }
        public Nullable<decimal> WashingWeigth { get; set; }
        public Nullable<decimal> WashingWidth { get; set; }
        public Nullable<decimal> MinLShrinkageW { get; set; }
        public Nullable<decimal> MaxLshrinkageW { get; set; }
        public Nullable<decimal> MinWshrinkageW { get; set; }
        public Nullable<decimal> MaxWShrinkageW { get; set; }
        public Nullable<decimal> SkewW { get; set; }
        public Nullable<decimal> WEPI { get; set; }
        public Nullable<decimal> WPPI { get; set; }
        public Nullable<decimal> MinLShrinkage { get; set; }
        public Nullable<decimal> MaxLshrinkage { get; set; }
        public Nullable<decimal> MinWshrinkage { get; set; }
        public Nullable<decimal> MaxWShrinkage { get; set; }
        public Nullable<decimal> Skew { get; set; }
        public Nullable<decimal> Cotton { get; set; }
        public Nullable<decimal> Polyester { get; set; }
        public Nullable<decimal> Spandex { get; set; }
        public Nullable<decimal> Tencel { get; set; }
        public Nullable<decimal> C4100 { get; set; }
        public Nullable<decimal> Modal { get; set; }
        public Nullable<decimal> Viscos { get; set; }
        public Nullable<decimal> Lycra { get; set; }
        public string OtherComp { get; set; }
        public Nullable<decimal> T4100 { get; set; }
        public Nullable<decimal> EPI { get; set; }
        public Nullable<decimal> PPI { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> ItemSpecificationID { get; set; }
        public Nullable<int> ItemStyleID { get; set; }
        public Nullable<int> ItemSeasonID { get; set; }
        public Nullable<int> ItemYearID { get; set; }
        public Nullable<int> UOMID { get; set; }
        public Nullable<int> ItemBrandID { get; set; }
        public Nullable<int> ItemModelID { get; set; }
        public Nullable<int> OriginCountryID { get; set; }
        public Nullable<int> ItemSizeID { get; set; }
        public Nullable<int> ItemConditionID { get; set; }
        public Nullable<int> StandardID { get; set; }
        public string UniqueCode { get; set; }
        public string HSCODE { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string Note { get; set; }
        public Nullable<bool> IsDetailComplete { get; set; }
        public Nullable<bool> IsSample { get; set; }
        public Nullable<bool> IsPart { get; set; }
        public Nullable<int> ItemGradeID { get; set; }
        public Nullable<int> CountTypeID { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> DepartmentID { get; set; }
        public Nullable<int> StatusID { get; set; }
        public int CompanyID { get; set; }
        public Nullable<decimal> FinishingWeight { get; set; }
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
    
        public virtual CmnItemCoating CmnItemCoating { get; set; }
        public virtual CmnItemCoating CmnItemCoating1 { get; set; }
        public virtual CmnItemColor CmnItemColor { get; set; }
        public virtual CmnItemCondition CmnItemCondition { get; set; }
        public virtual CmnItemFinishingWeight CmnItemFinishingWeight { get; set; }
        public virtual CmnItemGroup CmnItemGroup { get; set; }
        public virtual CmnItemMaster CmnItemMaster1 { get; set; }
        public virtual CmnItemMaster CmnItemMaster2 { get; set; }
        public virtual PrdWeavingMachinConfig PrdWeavingMachinConfig { get; set; }
        public virtual CmnItemModel CmnItemModel { get; set; }
        public virtual CmnItemOverDyed CmnItemOverDyed { get; set; }
        public virtual CmnItemSize CmnItemSize { get; set; }
        public virtual CmnItemSpecification CmnItemSpecification { get; set; }
        public virtual CmnItemStyleMaster CmnItemStyleMaster { get; set; }
        public virtual CmnItemType CmnItemType { get; set; }
        public virtual CmnItemYear CmnItemYear { get; set; }
        public virtual CmnOrganogram CmnOrganogram { get; set; }
        public virtual CmnUOM CmnUOM { get; set; }
        public virtual RndYarnCR RndYarnCR { get; set; }
        public virtual RndYarnCR RndYarnCR1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvMrrDetail> InvMrrDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvRChallanDetail> InvRChallanDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvRequisitionDetail> InvRequisitionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdBOMDying> PrdBOMDyings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdBOMMaster> PrdBOMMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdBOMSize> PrdBOMSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingChemicalSetupDetail> PrdDyingChemicalSetupDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingConsumptionMaster> PrdDyingConsumptionMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingMachinePart> PrdDyingMachineParts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdFinishingChemicalSetupDetail> PrdFinishingChemicalSetupDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdFinishingMRRMaster> PrdFinishingMRRMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdFinishingPackingList> PrdFinishingPackingLists { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdFinishingQAMaster> PrdFinishingQAMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdFinishingType> PrdFinishingTypes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdInternalIssue> PrdInternalIssues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdPreCostingDying> PrdPreCostingDyings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdPreCostingMaster> PrdPreCostingMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdPreCostingSize> PrdPreCostingSizes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdPreCostingYarn> PrdPreCostingYarns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdSizingBeamIssue> PrdSizingBeamIssues { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdSizingChemicalSetup> PrdSizingChemicalSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdSizingChemicalSetupDetail> PrdSizingChemicalSetupDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdWastageDetail> PrdWastageDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdWeavingMachinConfig> PrdWeavingMachinConfigs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdWeavingMachineConfigDetail> PrdWeavingMachineConfigDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdWeavingMachineSetup> PrdWeavingMachineSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdWeavingMRRMaster> PrdWeavingMRRMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PurchasePODetail> PurchasePODetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalBookingDetail> SalBookingDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingMachineSetup> PrdDyingMachineSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingMachineSetup> PrdDyingMachineSetups1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingMRRMaster> PrdDyingMRRMasters { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingMRRMaster> PrdDyingMRRMasters1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingOperationSetup> PrdDyingOperationSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingOperationSetup> PrdDyingOperationSetups1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdSizingChemicalConsumption> PrdSizingChemicalConsumptions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdSizingChemicalconsumptionDetail> PrdSizingChemicalconsumptionDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvMrrQcDetail> InvMrrQcDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvIssueDetail> InvIssueDetails { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdSetSetup> PrdSetSetups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrdDyingConsumptionChemical> PrdDyingConsumptionChemicals { get; set; }
        public virtual CmnItemBrand CmnItemBrand { get; set; }
    }
}
