using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_NET_BernarditaAntilaf_2018.Model {
    class DAO_Automovil : Conexion, DAO<Automovil> {
        private List<Automovil> lista;

        public DAO_Automovil() : base("automoviles") {
            lista = new List<Automovil>();
        }


        public void Create(Automovil ob) {
            Ejecutar("INSERT INTO automovil VALUES(" +
                "'" + ob.Patente + "'," +
                " '" + ob.Marca + "'," +
                " '" + ob.Anio + "'," +
                " '" + ob.Detalles + "'," +
                " '" + ob.Run + "'," +
                " '" + ob.NombreCompleto + "'," +
                " '" + ob.Telefono + "');");
        }

        public DataTable contadorAutos(){
            return Ejecutar("SELECT COUNT(*) FROM automovil;");
             
        }

        public DataTable Buscar(string parametro) {
            return Ejecutar("SELECT * FROM automovil WHERE patente like '%" + parametro + "%'; ");
        }
    }
}
