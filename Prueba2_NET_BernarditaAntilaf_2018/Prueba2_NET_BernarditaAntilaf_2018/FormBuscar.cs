using Prueba2_NET_BernarditaAntilaf_2018.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba2_NET_BernarditaAntilaf_2018 {
    public partial class FormBuscar : Form {
        private DAO_Automovil da;

        public FormBuscar() {
            InitializeComponent();
            da = new DAO_Automovil();
        }

        private void btnBuscar_Click(object sender, EventArgs e) {
            cargarTablaBusqueda();
        }

        private void cargarTablaBusqueda() {
            String busqueda = txtBuscador.Text;

            DataTable dt = da.Buscar(busqueda);
            if (dt.Rows.Count != 0) {
                txtPatente.Text = dt.Rows[0][1].ToString();

                txtMarca.Text = dt.Rows[0][2].ToString();
                txtAnio.Text = dt.Rows[0][3].ToString();
                txtDetalles.Text = dt.Rows[0][4].ToString();
                txtRun.Text = dt.Rows[0][5].ToString();
                txtNombreCom.Text = dt.Rows[0][6].ToString();
                txtNumero.Text = dt.Rows[0][7].ToString();

            }

            //foreach (Automovil aut in dt)) {
            //    ListViewItem item = new ListViewItem();
            //    item = ListViewAutos.Items.Add(aut.ID1+"");//Primer item(id)
            //    item.SubItems.Add(aut.Patente);//Todo lo demas, es subItem
            //    item.SubItems.Add(aut.Marca);
            //    item.SubItems.Add(aut.Anio);
            //    item.SubItems.Add(aut.Detalles);
            //    item.SubItems.Add(aut.Run);
            //    item.SubItems.Add(aut.NombreCompleto);
            //    item.SubItems.Add(aut.Telefono);
            //}






        }

        private void txtPatente_TextChanged(object sender, EventArgs e) {
            txtPatente.ForeColor = ColorTranslator.FromHtml("red");

        }
    }
}
