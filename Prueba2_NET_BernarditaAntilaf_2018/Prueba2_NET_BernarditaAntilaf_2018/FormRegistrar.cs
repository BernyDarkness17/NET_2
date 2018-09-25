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
    public partial class FormRegistrar : Form {
        private DAO_Automovil da;

        public FormRegistrar() {
            InitializeComponent();
            da = new DAO_Automovil();
        }

        private void btnRegistrarCar_Click(object sender, EventArgs e) {
            Automovil a = new Automovil();

            String rut = txtRun.Text + "-" + txtDigitoVerif;

            a.Patente = txtPatente.Text;
            a.Marca = txtMarca.Text;
            a.Anio = txtAnio.Text;
            a.Detalles = txtDetalles.Text;
            a.Run = rut;
            a.NombreCompleto = txtNombreCom.Text;
            a.Telefono = txtNumero.Text;

            da.Create(a);

        }

        private void txtDigitoVerif_TextChanged(object sender, EventArgs e) {
        }

        private void txtRun_TextChanged(object sender, EventArgs e) {
            int Digito;
            int Cont;
            int Multiplo;
            int Acumulador;
            string RutDigito;

            int rut = int.Parse(txtRun.Text);
            Cont = 2;
            Acumulador = 0;

            while (rut != 0) {
                Multiplo = (rut % 10) * Cont;
                Acumulador = Acumulador + Multiplo;
                rut = rut / 10;
                Cont++;
                if (Cont == 8) {
                    Cont = 2;
                }
            }
            Digito = 11 - (Acumulador % 11);
            RutDigito = Digito.ToString();
            txtDigitoVerif.Text = RutDigito + "";

            if (Digito == 10) {
                RutDigito = "K";
                txtDigitoVerif.Text = RutDigito;
            }
            if (Digito == 11) {
                RutDigito = "0";
                txtDigitoVerif.Text = RutDigito;
            } else {
                txtDigitoVerif.Text = RutDigito;
            }
        }
    }
}
