﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FortesEstoque.DAO
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AlmoxarifadoEntidates : DbContext
    {
        public AlmoxarifadoEntidates()
            : base("name=AlmoxarifadoEntidates")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Setor> Setor { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<ProdutoHistorico> ProdutoHistorico { get; set; }
    }
}
