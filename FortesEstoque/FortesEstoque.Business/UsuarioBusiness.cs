using FortesEstoque.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortesEstoque.Business
{
    public class UsuarioBusiness
    {
        UsuarioDAO _usuarioDAO;

        public UsuarioBusiness()
        {
            this._usuarioDAO = new UsuarioDAO();
        }

        public List<Usuario> Consultar()
        {
            try
            {
                return this._usuarioDAO.Consultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Inserir(Usuario usuario)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario.Nome))
                {
                    throw new Exception("Informe o Nome.");
                }
                this._usuarioDAO.Inserir(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
