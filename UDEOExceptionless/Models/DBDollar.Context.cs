﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UDEOExceptionless.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBDollarEntities : DbContext
    {
        public DBDollarEntities()
            : base("name=DBDollarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Balances> Balances { get; set; }
        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<donacion_balance> donacion_balance { get; set; }
        public virtual DbSet<Donacions> Donacions { get; set; }
    }
}
