using FortesEstoque.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortesEstoque.Business
{
    public class SetorBusiness
    {
        private SetorDAO _setorDAO;

        public SetorBusiness()
        {
            this._setorDAO = new SetorDAO();
        }

        public List<Setor> Consultar()
        {
            try
            {
                return this._setorDAO.Consultar();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
