using FortesEstoque.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortesEstoque.Business
{
    public class ProdutoBusiness
    {
        private ProdutoDAO _produtoDAO;

        public ProdutoBusiness()
        {
            this._produtoDAO = new ProdutoDAO();
        }

        public List<Produto> Consultar()
        {
            try
            {
                return this._produtoDAO.Consultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void _ValidaMovimentacao(ProdutoHistorico produtoHistorico)
        {
            if (string.IsNullOrEmpty(produtoHistorico.Tipo))
            {
                throw new Exception("Informe o Tipo da Operação.");
            }
            if (produtoHistorico.Qtd < 1)
            {
                throw new Exception("Informe a Quantidade.");
            }
            if (produtoHistorico.SetorId < 1)
            {
                throw new Exception("Informe o Setor.");
            }
            if (produtoHistorico.ProdutoId < 1)
            {
                throw new Exception("Informe o Produto.");
            }

        }

        public void Movimentar(ProdutoHistorico produtoHistorico)
        {
            try
            {
                this._ValidaMovimentacao(produtoHistorico);
              //  produtoHistorico.Usuario = new Usuario();
                produtoHistorico.UsuarioId = 1;
                produtoHistorico.DataRegistro = DateTime.Now;
                produtoHistorico.Produto = this._produtoDAO.Consultar(filtro => filtro.Id == produtoHistorico.ProdutoId).FirstOrDefault();
                if (produtoHistorico.Tipo == "E" /* Entrada */)
                {
                    produtoHistorico.Produto.Qtd += produtoHistorico.Qtd;
                }
                else
                {
                    if (produtoHistorico.Produto.Qtd == 0)
                    {
                        throw new Exception("Não existe produto no estoque.");
                    }
                    produtoHistorico.Produto.Qtd -= produtoHistorico.Qtd;
                }
                this._produtoDAO.Movimentar(produtoHistorico);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public List<ProdutoHistorico> ConsultarMovimentacoes(int produto)
        {
            try
            {
                return this._produtoDAO.ConsultarMovimentacoes(produto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
