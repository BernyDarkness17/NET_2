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
    public partial class Form1 : Form {
        private DAO_Automovil da;

        public Form1() {
            InitializeComponent();
            da = new DAO_Automovil();
            Numero();


        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            Numero();
        }

        private void registrarAutomovilToolStripMenuItem_Click(object sender, EventArgs e) {
            FormRegistrar form = new FormRegistrar();
            form.Show();
        }

        private void buscarAutomovilToolStripMenuItem_Click(object sender, EventArgs e) {
            FormBuscar form = new FormBuscar();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e){
      

        }

        public void Numero() {
            DataTable dt = da.contadorAutos();
            if (dt.Rows.Count != 0) {
                txtContadorAutos.Text = dt.Rows[0][0].ToString();
            }


        }
      
    }
}
