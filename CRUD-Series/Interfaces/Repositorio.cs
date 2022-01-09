using System;
using System.Collections.Generic;
using System.Text;

namespace Dio_Series.Interfaces
{
    public interface Repositorio <T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Exclui(int id);

        void Atualiza(int id, T entidade);

        int ProximoId ();

        
    }
}
