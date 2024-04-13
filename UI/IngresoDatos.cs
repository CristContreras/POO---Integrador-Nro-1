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
    public partial class IngresoDatos : Form
    {

        public static Persona persona;
        Auto auto;
        public static List<Persona> listaPersonas = new List<Persona>();

        private DataGridView dgvPersonas;

        public IngresoDatos(DataGridView dgvPersonas)
        {
            InitializeComponent();
            this.dgvPersonas = dgvPersonas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            

            listaPersonas.Add(new Persona(txtDNI.Text, txtNombre.Text, txtApellido.Text, new List<Auto>()));

            persona.ListaAutos.Add(new Auto(txtPatente.Text, txtMarca.Text, txtModelo.Text, txtAño.Text, decimal.Parse(txtPrecio.Text)));
            auto = new Auto(txtPatente.Text, txtMarca.Text, txtModelo.Text, txtAño.Text, decimal.Parse(txtPrecio.Text));
            //persona.ListaAutos.Add(auto);

            //persona.Lista_de_autos(persona.ListaAutos);

            //dgvPersonas.DataSource = persona.ListaAutos;
            MessageBox.Show("Guardado Correctamente");

            //p1.ListaAutos.Add(a1);
            //p1.ListaAutos.Add(a2);
            //p1.Lista_de_autos(p1.ListaAutos);
            //p1.Cantidad_de_Autos(p1.ListaAutos);
        }

        private void IngresoDatos_Load(object sender, EventArgs e)
        {

        }
    }
}
