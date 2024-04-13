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
    public partial class Main : Form
    {
        List<Persona> listaPersona = IngresoDatos.listaPersonas;
        Persona persona = IngresoDatos.persona;
        public Main()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IngresoDatos f = new IngresoDatos(dgvPersonas);
            f.Show();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = listaPersona;
            dgvAutos.DataSource = null;
            //dgvAutos.DataSource = persona.Lista_de_autos(persona.ListaAutos);
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
