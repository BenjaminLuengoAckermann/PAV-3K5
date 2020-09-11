using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CordobaVuela.Negocio.Entidades;
using CordobaVuela.Negocio.Servicios;

namespace CordobaVuela.Presentacion
{
    public partial class Principal : Form
    {
        private UsuarioService service;
        private Usuario usu;
        int noticia = 0;

        public Principal(Usuario usu)
        {
            InitializeComponent();
            service = new UsuarioService();
            this.usu = usu;
            lblUsuario.Text = "Usuario Logueado: " + usu.IdUsuario.ToString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //while (true)
            //{
            //pbxNoticias.Image = CordobaVuela.Properties.Resources.covid_avion1;
            //pbxNoticias.Image = CordobaVuela.Properties.Resources.foto;
            //Thread.Sleep(5);


            //}Timer timer = new Timer(172800000);
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

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TransparentToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void registrarAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AltaAeropuerto ventana = new AltaAeropuerto(usu);
            //ventana.Show();
            //this.Hide();
            /*if (service.ValidarPermiso(usu))
            {*/
                AltaAeropuerto ventana = new AltaAeropuerto(usu);
                ventana.Show();
                this.Hide();
            /*}
            else
            {
                MessageBox.Show("Acceso unicamente para personal de CordobaVuela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/
        }

        private void consultarAeropuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarAeropuerto ventana = new ConsultarAeropuerto(usu);
            ventana.Show();
            this.Hide();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea cerrar sesión?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                frmLogin ventana = new frmLogin();
                ventana.Show();
                this.Hide();
            }
        }

        private void tmrFotos_Tick(object sender, EventArgs e)
        {
            if (noticia == 3)
            {
                noticia = 0;
            }
            pbxNoticias.Image = imlNoticias.Images[noticia];
            noticia++;
        }

        private void tmfFecha_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }
    }
}
