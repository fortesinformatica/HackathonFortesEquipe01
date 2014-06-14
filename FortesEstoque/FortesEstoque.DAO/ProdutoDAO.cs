using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortesEstoque.DAO
{
    public class ProdutoDAO : BaseDao<Produto>
    {
        public void Movimentar(ProdutoHistorico produtoHistorico)
        {
            try
            {
                this.Context.Set<ProdutoHistorico>().Add(produtoHistorico);
                this.Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<ProdutoHistorico> ConsultarMovimentacoes(int produto)
        {
            return this.Context.Set<ProdutoHistorico>().ToList();

        }

    }

}
