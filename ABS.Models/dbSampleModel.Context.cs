﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbSampleEntities : DbContext
    {
        public dbSampleEntities()
            : base("name=dbSampleEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Customer> tbl_Customer { get; set; }
        public virtual DbSet<tbl_ItemSize> tbl_ItemSize { get; set; }
        public virtual DbSet<tbl_Product> tbl_Product { get; set; }
        public virtual DbSet<tbl_ProductOutlet> tbl_ProductOutlet { get; set; }
        public virtual DbSet<tbl_ProductType> tbl_ProductType { get; set; }
        public virtual DbSet<tbl_Sales> tbl_Sales { get; set; }
        public virtual DbSet<tbl_SalesItem> tbl_SalesItem { get; set; }
        public virtual DbSet<tbl_Supplier> tbl_Supplier { get; set; }
        public virtual DbSet<EmpMaster> EmpMasters { get; set; }
    }
}
