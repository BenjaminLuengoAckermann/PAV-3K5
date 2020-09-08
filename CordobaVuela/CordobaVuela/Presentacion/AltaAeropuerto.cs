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
    public partial class AltaAeropuerto : Form
    {
        public AltaAeropuerto(string usu)
        {
            InitializeComponent();
           
            lblUsu.Text = usu;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtId.Text =  "";
            txtNombre.Text = "";
            cmbCiudad.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Se cierra la app
            DialogResult result = MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Principal ventana = new Principal(lblUsu.Text);
            ventana.Show();
            this.Hide();
        }
    }
}
