﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseFirst
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AdventureWorks2017Entities : DbContext
    {
        public AdventureWorks2017Entities()
            : base("name=AdventureWorks2017Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<AddressType> AddressType { get; set; }
        public virtual DbSet<BusinessEntity> BusinessEntity { get; set; }
        public virtual DbSet<BusinessEntityAddress> BusinessEntityAddress { get; set; }
        public virtual DbSet<BusinessEntityContact> BusinessEntityContact { get; set; }
        public virtual DbSet<ContactType> ContactType { get; set; }
        public virtual DbSet<CountryRegion> CountryRegion { get; set; }
        public virtual DbSet<EmailAddress> EmailAddress { get; set; }
        public virtual DbSet<Password> Password { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonPhone> PersonPhone { get; set; }
        public virtual DbSet<PhoneNumberType> PhoneNumberType { get; set; }
        public virtual DbSet<StateProvince> StateProvince { get; set; }
    }
}
