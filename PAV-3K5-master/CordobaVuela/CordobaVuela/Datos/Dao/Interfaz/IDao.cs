using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CordobaVuela.Datos.Dao.Interfaz
{
    interface IDao<T>
    {
        T findById(string id);
        IList<T> getAll();
        bool add(T obj);
        bool delete(string id);
    }
}
