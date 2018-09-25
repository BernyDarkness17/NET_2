using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_NET_BernarditaAntilaf_2018.Model {
    interface DAO<T> {
        void Create(T ob);
        DataTable Buscar(String parametro);
    }
}
