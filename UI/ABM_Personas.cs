using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ABM_Personas : Form
    {
        public Persona unaPersona;
        public List<Persona> listaPersonas = new List<Persona>();
        public ABM_Personas()
        {
            InitializeComponent();

        }

        private void btnAgregarPropietario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDNI.Text))
            {
                unaPersona = new Persona(txtDNI.Text, txtNombre.Text, txtApellido.Text);

                foreach (var persona in listaPersonas)
                {
                    if (persona.DNI == unaPersona.DNI)
                    {
                        MessageBox.Show("La persona ya esta agregada");

                        return;
                    }
                }
                listaPersonas.Add(unaPersona);
                mostrarLista(listaPersonas, dgvPersonas);
                MessageBox.Show("Persona agregada correctamente");
                MessageBox.Show(unaPersona.ToString());
                limpiarCampos();
                txtDNI.Select();

            }
            else
            {
                MessageBox.Show("DNI no puede ser vacío");
                txtDNI.Focus();
            }       
        }
        public void mostrarLista<T>(List<T> lista, DataGridView datagrid)
        {
            datagrid.DataSource = null;
            datagrid.DataSource = lista;
            dgvPersonas.ClearSelection();
        }
        private void ABM_Personas_Load(object sender, EventArgs e)
        {
            

        }

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            int pos = dgvPersonas.CurrentCell.RowIndex;
            //int posicionPersona = dgvPersonas.CurrentRow.Index;

            if (pos >= 0)
            {
                if (txtDNI.Text != listaPersonas[pos].DNI || txtApellido.Text != listaPersonas[pos].Apellido || txtNombre.Text != listaPersonas[pos].Nombre)
                {
                    if (txtDNI.Text != listaPersonas[pos].DNI)
                    {
                        foreach(var item in listaPersonas)
                        {
                            if(item.DNI == txtDNI.Text)
                            {
                                MessageBox.Show("Error ya hay otro persona con ese DNI");
                                return;
                            }
                        }
                        listaPersonas[pos].DNI = txtDNI.Text;

                    }
                    else if (txtApellido.Text != listaPersonas[pos].Apellido)
                    {
                        listaPersonas[pos].Apellido = txtApellido.Text;
                    }
                    else if (txtNombre.Text != listaPersonas[pos].Nombre)
                    {
                        listaPersonas[pos].Nombre = txtNombre.Text;
                    }
                    mostrarLista(listaPersonas, dgvPersonas);
                    MessageBox.Show("¡Cambio realizado!");
                    limpiarCampos();
                }
            }
            //if (dgvPersonas.SelectedRows.Count > 0)
            //{
            //    if(txtDNI.Text != listaPersonas[posicionPersona].DNI|| txtApellido.Text != listaPersonas[posicionPersona].Apellido|| txtNombre.Text != listaPersonas[posicionPersona].Nombre)
            //    {
            //        if (txtDNI.Text != listaPersonas[posicionPersona].DNI)
            //        {
            //            listaPersonas[posicionPersona].DNI = txtDNI.Text;
            //        }
            //        else if (txtApellido.Text != listaPersonas[posicionPersona].Apellido)
            //        {
            //            listaPersonas[posicionPersona].Apellido = txtApellido.Text;
            //        }
            //        else if (txtNombre.Text != listaPersonas[posicionPersona].Nombre)
            //        {
            //            listaPersonas[posicionPersona].Nombre = txtNombre.Text;
            //        }
            //        mostarLista(listaPersonas, dgvPersonas);
            //        MessageBox.Show("¡Cambio realizado!");
            //        limpiarCampos();
            //    }
            //}
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            if (listaPersonas.Count > 0)
            {
                int pos = dgvPersonas.CurrentRow.Index;

                DialogResult respuesta = MessageBox.Show($"¿Esta seguro que desea borrar a la persona: {listaPersonas[pos].DNI}", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {

                    if (dgvPersonas.Rows.Count > 0)
                    {
                        listaPersonas.RemoveAt(pos);
                        MessageBox.Show($"Objeto eliminado de la lista.");
                        if (listaPersonas.Count > 0)
                        {
                            mostrarLista(listaPersonas, dgvPersonas);

                        }
                        else
                        {
                            dgvPersonas.DataSource = null;
                        }
                        limpiarCampos();
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay personas que eliminar");
            }    
        }

        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            //if (listaPersonas.Count > 0)
            //{
            //    if (dgvPersonas.Rows.Count > 0)
            //    {
            //        int posicionPersona = dgvPersonas.CurrentRow.Index;
            //        txtDNI.Text = listaPersonas[posicionPersona].DNI;
            //        txtNombre.Text = listaPersonas[posicionPersona].Nombre;
            //        txtApellido.Text = listaPersonas[posicionPersona].Apellido;
            //    }
            //}
          

        }
        
        public void limpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }
        private void ABM_Personas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.unaVentanaPersona = 0;
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = 0;
            //if (dgvPersonas.SelectedRows.Count > 0)
            //{
            //    i = dgvPersonas.CurrentRow.Index;
            //    lblIndicePrueba.Text = i.ToString();

            //}

            //MessageBox.Show("Celda seleccionada");
        }

        private void btnVerLista_Click(object sender, EventArgs e)
        {
            btnVerLista.Enabled = false;
            mostrarLista(listaPersonas, dgvPersonas);
            limpiarCampos();
        }

        private void dgvPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("Con cellclick");
            int fila = e.RowIndex;
            txtDNI.Text = listaPersonas[fila].DNI;
            txtNombre.Text = listaPersonas[fila].Nombre;
            txtApellido.Text = listaPersonas[fila].Apellido;

            //int i = 0;
            //if (dgvPersonas.SelectedRows.Count > 0)
            //{
            //    i = dgvPersonas.CurrentRow.Index;
            //    lblIndicePrueba.Text = i.ToString();

            //}
        }

        private void dgvPersonas_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //MessageBox.Show("Selecionado");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
