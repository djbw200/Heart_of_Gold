﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hearts_of_Gold.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Hearts_Of_GoldEntities1 : DbContext
    {
        public Hearts_Of_GoldEntities1()
            : base("name=Hearts_Of_GoldEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Donation_Categories> Donation_Categories { get; set; }
        public DbSet<Donation_Location> Donation_Location { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Login> Logins { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<sysdiagram> sysdiagrams { get; set; }
        public DbSet<User> Users { get; set; }
    }
}