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
    public partial class frmModificarAeropuerto : Form
    {
        private Usuario us;
        private Aeropuerto aero;
        private PaisService serviceP;
        private CiudadService serviceC;
        private AeropuertoService serviceA;
        private ProvinciaService servicePcia;
        

        public frmModificarAeropuerto(Usuario usu, Aeropuerto aero)
        {
            InitializeComponent();
            this.us = usu;
            this.aero = aero;
            serviceP = new PaisService();
            serviceC = new CiudadService();
            serviceA = new AeropuertoService();
            servicePcia = new ProvinciaService();           
            lblUsu.Text = "Usuario Logueado: " + usu.IdUsuario.ToString();
        }
    
        public void frmModificarAeropuerto_Load(object sender, EventArgs e)
        {

            txtNombre.Text = aero.Nombre;
            //HABRÍA QUE INTENTAR QUE SE LLENEN LOS COMBOS SOLOS CON ESTOS DATOS
            cmbPais.SelectedItem = aero.Pais;
            cmbProvincia.Text = aero.Provincia;
            cmbCiudad.Text = aero.Ciudad; 

            Pais[] aux = serviceP.ListadoDePaises();
            for (int i = 0; i < aux.Length; i++)
            {
                cmbPais.Items.Add(aux[i].Nombre.ToString());
            }
   
        }

        // Aqui consulta las provincias segun el pais elegido
        private void cmbPais_SelectedItemChanged(object sender, EventArgs e)
        {

            string pais = cmbPais.Text.ToString();

            // Limpia los combos para que solo muestre lo referido al pais elegido
            cmbProvincia.Items.Clear();
            cmbCiudad.Items.Clear();

            Provincia[] auxTres = servicePcia.ListadoDeProvinciasPorPais(pais);
            for (int i = 0; i < auxTres.Length; i++)
            {
                cmbProvincia.Items.Add(auxTres[i].Nombre.ToString());
            }

        }


        // Aqui consulta las ciudades segun la provincia elegida
        private void cmbProvincia_SelectedItemChanged(object sender, EventArgs e)
        {
            string pcia = cmbProvincia.Text.ToString();

            // Limpia el combo para que solo muestre lo referido al pais y provincia elegido
            cmbCiudad.Items.Clear();

            Ciudad[] aux = serviceC.ListadoDeCiudadesPorProvincia(pcia);
            for (int i = 0; i < aux.Length; i++)
            {
                cmbCiudad.Items.Add(aux[i].Nombre.ToString());
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Se cierra la app
            DialogResult result = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ConsultarAeropuerto ventana = new ConsultarAeropuerto(us);
            ventana.Show();
            this.Hide();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbPais.Items.Clear();
            cmbProvincia.Items.Clear();
            txtNombre.Text = "";
            cmbCiudad.Items.Clear();
            
            
            // Esta linea llama al metodo alta aeropueto para llenar de nuevo los combos
            frmModificarAeropuerto_Load(null, null);
            txtNombre.Focus();
        }

        private void btnModificarAeropuerto_Click(object sender, EventArgs e)
        {
            if (ValidarIngreso())

            {
                Ciudad aux = serviceC.ObtenerCiudad(cmbCiudad.Text);

                DialogResult result = MessageBox.Show("¿Esta seguro que desea modificar el aeropuerto?", "Modificar aeropuerto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    serviceA.ModificarAeropuerto(aero.IdAeropuerto, txtNombre.Text, aux.IdCiudad);
                    MessageBox.Show("Se ha modificado el aeropuerto correctamente!", "Modificacion de Aeropuerto Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information); this.Hide();
                    ConsultarAeropuerto ventana = new ConsultarAeropuerto(us);
                    ventana.Show();
                }
            }
        }


        private bool ValidarIngreso()
        {

            if (ValidarCampo(txtNombre) || cmbCiudad.SelectedIndex == -1)
            {
                MessageBox.Show("Error. Debe ingresar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;

        }


        public bool ValidarCampo(TextBox campo)

        {
            if (string.IsNullOrEmpty(campo.Text))
            {
                campo.Focus();
                return true;
            }
            return false;
        }

    }

}
