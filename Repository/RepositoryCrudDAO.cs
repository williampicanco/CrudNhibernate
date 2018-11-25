using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryCrudDAO<T> : ICrudDao<T> where T : class
    {
        public void Alterar(T entidade)
        {
            throw new NotImplementedException();
        }

        public IList<T> Consultar()
        {
            throw new NotImplementedException();
        }

        public void Excluir(T entidade)
        {
            throw new NotImplementedException();
        }

        public void Inserir(T entidade)
        {
            throw new NotImplementedException();
        }

        public T RetornarPorId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
