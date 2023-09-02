using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domain.interfaces.Generics
{
    public interface InterfaceGeneric<T> where T : class
    {
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetEntityById(int Objeto);
        Task <List<T>> List();

    }
}
