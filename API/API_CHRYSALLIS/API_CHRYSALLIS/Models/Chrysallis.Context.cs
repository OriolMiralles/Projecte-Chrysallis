﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_CHRYSALLIS.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ChrysallisEntities : DbContext
    {
        public ChrysallisEntities()
            : base("name=ChrysallisEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<assistir> assistir { get; set; }
        public virtual DbSet<comunitats> comunitats { get; set; }
        public virtual DbSet<documents> documents { get; set; }
        public virtual DbSet<localitats> localitats { get; set; }
        public virtual DbSet<menors> menors { get; set; }
        public virtual DbSet<menors_socis> menors_socis { get; set; }
        public virtual DbSet<provincies> provincies { get; set; }
        public virtual DbSet<rols> rols { get; set; }
        public virtual DbSet<socis> socis { get; set; }
        public virtual DbSet<tipus_events> tipus_events { get; set; }
        public virtual DbSet<usuaris> usuaris { get; set; }
        public virtual DbSet<valoracions> valoracions { get; set; }
        public virtual DbSet<esdeveniments> esdeveniments { get; set; }
    }
}
