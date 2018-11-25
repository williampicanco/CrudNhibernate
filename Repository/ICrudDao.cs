using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICrudDao<T>
    { // T é genérico, vai ser uma classe no momento certo
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        T RetornarPorId(int id); //retorna um registro da tabela
        IList<T> Consultar(); //retorna uma list de T
    }
}
