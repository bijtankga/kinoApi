﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KinoRezerwacja.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class kinoEntities : DbContext
    {
        public kinoEntities()
            : base("name=kinoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<film> film { get; set; }
        public virtual DbSet<klient> klient { get; set; }
        public virtual DbSet<miejsce> miejsce { get; set; }
        public virtual DbSet<rezerwacja> rezerwacja { get; set; }
        public virtual DbSet<seans> seans { get; set; }
    }
}
