﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hospital
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HospitalEntities1 : DbContext
    {
        public HospitalEntities1()
            : base("name=HospitalEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Card_Type> Card_Type { get; set; }
        public virtual DbSet<Existing_Account> Existing_Account { get; set; }
        public virtual DbSet<Material_Status> Material_Status { get; set; }
        public virtual DbSet<Occupation> Occupations { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Patient_Category> Patient_Category { get; set; }
        public virtual DbSet<Patient_Family> Patient_Family { get; set; }
        public virtual DbSet<Religion> Religions { get; set; }
        public virtual DbSet<State_of_Origin> State_of_Origin { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Title> Titles { get; set; }
    }
}
