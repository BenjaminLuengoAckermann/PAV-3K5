using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CordobaVuela.Negocio.Entidades;
using CordobaVuela.Negocio.Servicios;

namespace CordobaVuela.Presentacion
{
    public partial class AltaPasajero : Form

 
    {
        private UsuarioService serviceUsu;
        private TipoDocumentoService serviceD;


     
        public AltaPasajero()
        {
            InitializeComponent();
            serviceUsu = new UsuarioService();
            serviceD = new TipoDocumentoService();
        }


        private void AltaPasajero_Load(object sender, EventArgs e)
        {
            TipoDocumento[] aux = serviceD.ListadoDeTipoDocumento();
            for (int i = 0; i < aux.Length; i++)
            {
                cmbTipoDocumento.Items.Add(aux[i].Nombre.ToString());
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
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
            if (ValidarCampos() && ValidarNombreUsuario())
            {
                if (txtPassword.TextLength >= 8 || txtRepitaPassword.TextLength >= 8)
                {
                    bool result = serviceUsu.CrearUsuario(txtNomUsu.Text, txtPassword.Text);

                    if (result)
                    {
                        MessageBox.Show("Se ha registrado correctamente el usuario!", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Usuario usu = new Usuario(txtNomUsu.Text, txtPassword.Text);
                        Principal ventana = new Principal(usu);
                        ventana.Show();
                        this.Hide();
                    }
                }
                else {
                    MessageBox.Show("ERROR! La contraseña debe ser de al menos 8 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                MessageBox.Show("Error. Debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtPassword.Text != txtRepitaPassword.Text)
            {
                MessageBox.Show("Error. Las contraseñas deben coincidir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRepitaPassword.Text = "";
                txtRepitaPassword.Focus();
                return false;
            }
            return true;

        }

        private bool ValidarNombreUsuario()
        {
            if (serviceUsu.ValidarNombreUsuario(txtNomUsu.Text.ToString()))
                {
                    return true;
                }
            
            MessageBox.Show("Ese nombre de usuario ya esta registrado. Por favor, ingrese otro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtNomUsu.Text = "";
            txtNomUsu.Focus();
            return false;
        }


    }
}
