﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XnetIT.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class xnetDBEntities : DbContext
    {
        public xnetDBEntities()
            : base("name=xnetDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<engineer> engineers { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<job_ratings> job_ratings { get; set; }
        public virtual DbSet<eng_ratings> eng_ratings { get; set; }
        public virtual DbSet<assign_engineer> assign_engineer { get; set; }
    }
}
