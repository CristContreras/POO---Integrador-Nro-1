using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ABM_Autos : Form
    {
        public ABM_Autos()
        {
            InitializeComponent();
        }
        public Auto unAuto;
        public List<Auto> listaAutos = new List<Auto>();

        private void btnModificarAuto_Click(object sender, EventArgs e)
        {
            if (dgvAutos.Rows.Count > 0)
            {
                //int posicionAuto = dgvAutos.CurrentRow.Index;
                //listaAuto[posicionAuto].Patente = txtPatente.Text;
                //listaAuto[posicionAuto].Modelo = txtModelo.Text;
                //listaAuto[posicionAuto].Marca = txtMarca.Text;
                //listaAuto[posicionAuto].Año = txtAño.Text;
                //listaAuto[posicionAuto].Precio = decimal.Parse(txtPrecio.Text);

                //mostarLista(listaAuto, dgvAutos);
                //MessageBox.Show("Cambio realizado!");

            }
        }

        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            //if(!string.IsNullOrEmpty(txtPatente.Text))
            //{
            //    unAuto = new Auto(txtPatente.Text, txtMarca.Text, txtModelo.Text, txtAño.Text, decimal.Parse(txtPrecio.Text));

            //    foreach (var auto in listaAuto)
            //    {
            //        if (auto.Patente == unAuto.Patente)
            //        {
            //            MessageBox.Show("El auto ya esta agregado");
            //            unAuto = null;
            //            return;
            //        }
            //    }
            //    listaAuto.Add(unAuto);
            //    mostarLista(listaAuto, dgvAutos);
            //    dgvAutos.Columns[4].DefaultCellStyle.Format = "#,0.00";
            //    //dgvAutos.DataSource = null;
            //    //dgvAutos.DataSource = listaAuto;
            //    //unaPersona.Agregar_Auto(unAuto);

            //}
            //else
            //{
            //    MessageBox.Show("Patente no puede ser vacio");
            //    unaPersona = null;
            //    txtPatente.Focus();
            //}
        }

        private void btnBorrarAuto_Click(object sender, EventArgs e)
        {
            //if (dgvAutos.Rows.Count > 0)
            //{
            //    int pos = dgvAutos.CurrentRow.Index;
            //    listaAuto.RemoveAt(pos);
            //    MessageBox.Show("Objeto eliminado de la lista");
            //    mostarLista(listaAuto, dgvAutos);
            //}
        }

        private void ABM_Autos_Load(object sender, EventArgs e)
        {

        }

        private void ABM_Autos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.unaVentanaAuto = 0;
        }
    }
}
