using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CordobaVuela.Presentacion
{
    public partial class AltaPasajero : Form
    {
        public AltaPasajero()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmLogin ventana = new frmLogin();
            ventana.Show();
            this.Hide();

        }

        //IMPORTANTE!!!!!!
        //***************************************************************************************************************************************
        //LOS METODOS QUE ESTAN DE MÁS PRIMERO SE BORRAN DESDE LOS EVENTOS DE LAS PROPIEDADES, Y RECIEN DESPUES SE BORRAN ACA, SINO SE CLAVA
        //***************************************************************************************************************************************
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCordovaVuela_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos() {
            txtNombre.Text ="";
            txtApellido.Text = "";
            txtNomUsu.Text = "";
            txtPassword.Text = "";
            txtRepitaPassword.Text = "";
            mskDocumento.Text = "";
            mskNacimiento.Text = "";
            cmbTipoDocumento.Text = "";
            
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                Principal ventana = new Principal(txtNombre.Text);
                ventana.Show();
                this.Hide();
            }
            
        }


        private bool ValidarCampo(TextBox campo) 
        {
            if (string.IsNullOrEmpty(campo.Text))
            {
                campo.Focus();
                return true;
            }
            return false;

        }
        private bool ValidarCampo(MaskedTextBox campo)
        {
            if (string.IsNullOrEmpty(campo.Text))
            {          
                campo.Focus();
                return true;
            }
            return false;
        }

        private bool ValidarCampos() 
        {

            if (ValidarCampo(txtNombre) || ValidarCampo(txtApellido) || ValidarCampo(txtNomUsu) || ValidarCampo(txtPassword) || ValidarCampo(txtRepitaPassword) || ValidarCampo(mskDocumento) || ValidarCampo(mskNacimiento))
            {
                MessageBox.Show("Error. Debe ingresar todos los campos");
                return false;
            }
            if (txtPassword.Text != txtRepitaPassword.Text)
            {
                MessageBox.Show("Error. Las contraseñas deben coincidir");
                txtRepitaPassword.Text = "";
                txtRepitaPassword.Focus();
                return false;
            }
            return true;

        }

    }
}
