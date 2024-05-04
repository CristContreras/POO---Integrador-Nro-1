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
        //List<Persona> listaPersona = IngresoDatos.listaPersonas;
        //Persona persona = IngresoDatos.persona;
        Persona unaPersona = new Persona();

        Auto unAuto = new Auto();
        List<Persona> listaPersonas=new List<Persona>();
        List<Auto> listaAutos = new List<Auto>();
       
        public Main()
        {
            InitializeComponent();
            
        }

        

        

        

        private void Main_Load(object sender, EventArgs e)
        {
            //unaPersona.DNI = "123";
            //habilitarControlesPersona(false);
            //habilitarControlesAuto(false);
            //txtDNI.Select();
            //decimal precio = 20000.59m;
            //txtPrecio.Text = precio.ToString("#,0.00");
        }
        //public void habilitarControlesPersona(bool estado)
        //{
        //    txtNombre.Enabled = estado;
        //    txtApellido.Enabled = estado;
        //    txtPatente.Enabled = estado;


        //}

        //public void habilitarControlesAuto(bool estado)
        //{
        //    txtMarca.Enabled = estado;
        //    txtModelo.Enabled = estado;
        //    txtPrecio.Enabled = estado;
        //    txtAño.Enabled = estado;

        //}



        //private void btnAgregarPropietario_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(txtDNI.Text))
        //    {
        //        unaPersona = new Persona(txtDNI.Text, txtNombre.Text, txtApellido.Text);

        //        foreach (var persona in listaPersonas)
        //        {
        //            if (persona.DNI == unaPersona.DNI)
        //            {
        //                MessageBox.Show("La persona ya esta agregada");

        //                return;
        //            }
        //        }
        //        listaPersonas.Add(unaPersona);
        //        mostarLista(listaPersonas, dgvPersonas);
        //        MessageBox.Show("Persona Agregado correctamente");

        //        txtDNI.Clear();
        //        txtNombre.Clear();
        //        txtApellido.Clear();


        //else
        //{
        //    MessageBox.Show("DNI no puede ser vacío");
        //    txtDNI.Focus();
        //}
        //IngresoDatos f1 = new IngresoDatos(dgvPersonas);




        //private void txtDNI_TextChanged(object sender, EventArgs e)
        //{
        //    if(!string.IsNullOrEmpty(txtDNI.Text))
        //    {
        //        habilitarControlesPersona(true);
        //    }
        //    else
        //    {
        //        habilitarControlesPersona(false);
        //    }

        //}

        //private void txtPatente_TextChanged(object sender, EventArgs e)
        //{
        //    decimal valorTemp = decimal.Parse(txtPrecio.Text);
        //    if (!string.IsNullOrEmpty(txtPatente.Text))
        //    {
        //        habilitarControlesAuto(true);
        //        txtPrecio.Text = valorTemp.ToString();

        //    }
        //    else
        //    {

        //        habilitarControlesAuto(false);
        //        if(decimal.Parse(txtPrecio.Text) != 0.0m)
        //        {
        //            valorTemp = decimal.Parse(txtPrecio.Text);
        //            txtPrecio.Text = valorTemp.ToString();
        //        }
        //    }
        //}





        //private void btnAsignarAuto_Click(object sender, EventArgs e)
        //{
        //    int posiciondgvPersonas = 0;
        //    int posiciondgvAutos = 0;
        //    //if (posiciondgvPersonas != 0)
        //    //{
        //        posiciondgvPersonas = dgvPersonas.CurrentRow.Index;

        //        //if (posiciondgvAutos != 0)
        //        //{
        //            posiciondgvAutos = dgvAutos.CurrentRow.Index;
        //            listaPersonas[posiciondgvPersonas].Agregar_Auto(listaAuto[posiciondgvAutos]);
        //    //listaAuto.RemoveAt(posiciondgvAutos);
        //    //dgvAutos.DataSource = null;
        //    //dgvAutos.DataSource = listaAuto;
        //            MessageBox.Show($"Auto agregado exitosamente al usuario {listaPersonas[posiciondgvPersonas].DNI}");
        //            //unaPersona.Agregar_Auto(listaAuto.Find();

        //        //}
        //        //else { MessageBox.Show("Falta seleccionar un auto");}
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("Debe seleccionar una persona primero");
        //    //}
        //    //MessageBox.Show(posicion.ToString());

        //}

        //private void dgvAutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    //if (dgvPersonas.SelectedRows.Count > 0)
        //    //{
        //    //    int posicionPersona = dgvPersonas.CurrentCell;
        //    //    txtDNI.Text = listaPersonas[posicionPersona].DNI;
        //    //    txtNombre.Text = listaPersonas[posicionPersona].Nombre;
        //    //    txtApellido.Text = listaPersonas[posicionPersona].Apellido;
        //    //}
        //}

        //private void btnModificarPersona_Click(object sender, EventArgs e)
        //{
        //    if (dgvPersonas.SelectedRows.Count > 0)
        //    {
        //        int posicionPersona = dgvPersonas.CurrentRow.Index;
        //        listaPersonas[posicionPersona].Nombre = txtNombre.Text;
        //        listaPersonas[posicionPersona].Nombre = txtApellido.Text;
        //        mostarLista(listaPersonas, dgvPersonas);
        //        MessageBox.Show("Cambio realizado!");

        //    }
        //}

        //private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvPersonas.Rows.Count>0)
        //    {
        //        int posicionPersona = dgvPersonas.CurrentRow.Index;
        //        txtDNI.Text = listaPersonas[posicionPersona].DNI;
        //        txtNombre.Text = listaPersonas[posicionPersona].Nombre;
        //        txtApellido.Text = listaPersonas[posicionPersona].Apellido;
        //    }
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if(dgvPersonas.Rows.Count>0)
        //    {
        //        int pos = dgvPersonas.CurrentRow.Index;
        //        listaPersonas.RemoveAt(pos);
        //        MessageBox.Show("Objeto eliminado de la lista");
        //        mostarLista(listaPersonas, dgvPersonas);
        //    }
        //}

        //private void toolStripButton1_Click(object sender, EventArgs e)
        //{

        //}

        //private void toolStripLabel1_Click(object sender, EventArgs e)
        //{

        //}

        //private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        //private void borrarPeToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void asignarAutoToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnModificarAuto_Click(object sender, EventArgs e)
        //{
        //    if (dgvAutos.Rows.Count > 0)
        //    {
        //        int posicionAuto = dgvAutos.CurrentRow.Index;
        //        listaAuto[posicionAuto].Patente = txtPatente.Text;
        //        listaAuto[posicionAuto].Modelo = txtModelo.Text;
        //        listaAuto[posicionAuto].Marca = txtMarca.Text;
        //        listaAuto[posicionAuto].Año = txtAño.Text;
        //        listaAuto[posicionAuto].Precio = decimal.Parse(txtPrecio.Text);

        //        mostarLista(listaAuto, dgvAutos);
        //        MessageBox.Show("Cambio realizado!");

        //    }
        //}

        //private void btnBorrarAuto_Click(object sender, EventArgs e)
        //{
        //    if (dgvAutos.Rows.Count > 0)
        //    {
        //        int pos = dgvAutos.CurrentRow.Index;
        //        listaAuto.RemoveAt(pos);
        //        MessageBox.Show("Objeto eliminado de la lista");
        //        mostarLista(listaAuto, dgvAutos);
        //    }
        //}

        //private void dgvAutos_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (dgvAutos.Rows.Count > 0)
        //    {
        //        int posicionauto = dgvAutos.CurrentRow.Index;

        //        txtPatente.Text = listaAuto[posicionauto].Patente;
        //        txtMarca.Text = listaAuto[posicionauto].Marca;
        //        txtModelo.Text = listaAuto[posicionauto].Modelo;
        //        txtAño.Text = listaAuto[posicionauto].Año;
        //        txtPrecio.Text = listaAuto[posicionauto].Precio.ToString();

        //    }
        //}

        //private void asignarAutoToolStripMenuItem_Click_1(object sender, EventArgs e)
        //{

        //}

        //private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        //{

        //}

        //private void groupBox2_Enter(object sender, EventArgs e)
        //{

        //}
        public static int unaVentanaPersona = 0;
        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unaVentanaPersona == 0)
            {
                ABM_Personas abmPersonas = new ABM_Personas();
                abmPersonas.MdiParent = this;
                abmPersonas.unaPersona = unaPersona;
                abmPersonas.listaPersonas = listaPersonas;
                abmPersonas.Show();
                //abmPersonas.limpiarCampos();
                unaVentanaPersona = 1;
            }
            else
            {
                MessageBox.Show("Solo se puede una instancia");
            }

            
        }
        public static int unaVentanaAuto = 0;

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (unaVentanaAuto == 0)
            {
                ABM_Autos abmAutos = new ABM_Autos();
                abmAutos.MdiParent = this;
                abmAutos.unAuto = unAuto;
                abmAutos.listaAutos = listaAutos;
                abmAutos.Show();
                unaVentanaAuto = 1;
            }
            else
            {
                MessageBox.Show("Solo se puede una instancia");
            }


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

            }
           
        }
        

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro desea salir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                
            }
            else if(result ==DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        //private void asignarAutoToolStripMenuItem1_Click(object sender, EventArgs e)
        //{

        //}
    }
}
