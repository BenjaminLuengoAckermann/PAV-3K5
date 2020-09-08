using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CordobaVuela.Negocio.Entidades;
using CordobaVuela.Negocio.Servicios;
using CordobaVuela.Presentacion;


namespace CordobaVuela
{
    public partial class frmLogin : Form
    {
        private UsuarioService service;
        public frmLogin()
        {
            InitializeComponent();
            service = new UsuarioService();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // Se cierra la app
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);

            }


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Validacion ingreso user
            if ((txtUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validacion ingreso password
            if ((txtPassword.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }

            //Controlamos que las creadenciales sean las correctas. 
           
             Usuario logueado = new Usuario(txtUsuario.Text, txtPassword.Text);
             if (service.validarUsuario(logueado))
              {
              Principal ventana = new Principal(logueado);
              ventana.Show();
              this.Hide();
             }
            else
            {
            //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
              txtPassword.Text = "";
             // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
             txtPassword.Focus();
            //Mostramos un mensaje indicando que el usuario/password es invalido.
             MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }
            

              


            
            
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            AltaPasajero ventana = new AltaPasajero();
            ventana.Show();
            this.Hide();
        }
    }
}
