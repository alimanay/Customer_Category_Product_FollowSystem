﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ef_Core_Statistic_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbProject3Entities : DbContext
    {
        public DbProject3Entities()
            : base("name=DbProject3Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TblCategory> TblCategory { get; set; }
        public virtual DbSet<TblCustomer> TblCustomer { get; set; }
        public virtual DbSet<TblOrder> TblOrder { get; set; }
        public virtual DbSet<TblProduct> TblProduct { get; set; }
    }
}
