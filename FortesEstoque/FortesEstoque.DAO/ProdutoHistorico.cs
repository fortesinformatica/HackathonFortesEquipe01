//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class ProdutoHistorico
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int UsuarioId { get; set; }
        public System.DateTime DataEntrada { get; set; }
        public System.DateTime DataSaida { get; set; }
        public int Qtde { get; set; }
    
        public virtual Produto Produto { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
