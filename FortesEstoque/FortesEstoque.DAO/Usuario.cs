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
    
    public partial class Usuario
    {
        public Usuario()
        {
            this.ProdutoHistorico = new HashSet<ProdutoHistorico>();
            this.Movimentacao = new HashSet<Movimentacao>();
        }
    
        public int Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
    
        public virtual ICollection<ProdutoHistorico> ProdutoHistorico { get; set; }
        public virtual ICollection<Movimentacao> Movimentacao { get; set; }
    }
}