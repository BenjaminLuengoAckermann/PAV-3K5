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

namespace CordobaVuela.Presentacion
{
    public partial class Principal : Form
    {
        public Principal(string usu)
        {
            InitializeComponent();
            lblUsuario.Text = "Usuario Logueado: " + usu;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            
        }

        private void pasajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void vuelosToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
