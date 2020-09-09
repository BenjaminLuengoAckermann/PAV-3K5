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
    public partial class AltaAeropuerto : Form
    {
        private Usuario us;
        private PaisService serviceP;
        private CiudadService serciceC;
        private AeropuertoService serviceA;
        private ProvinciaService servicePcia;

        public AltaAeropuerto(Usuario usu)
        {
            InitializeComponent();
            this.us = usu;
            serviceP = new PaisService();
            serciceC = new CiudadService();
            serviceA = new AeropuertoService();
            servicePcia = new ProvinciaService();
            lblUsu.Text = "Usuario Logueado: " + usu.IdUsuario.ToString();

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            cmbPais.Items.Clear() ;
            cmbProvincia.Items.Clear();
            txtNombre.Text = "";
            cmbCiudad.Items.Clear();
            // Esta linea llama al metodo alta aeropueto para llenar de nuevo los combos
            AltaAeropuerto_Load(null, null);
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
            Principal ventana = new Principal(us);
            ventana.Show();
            this.Hide();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void AltaAeropuerto_Load(object sender, EventArgs e)
        {
            Pais[] aux = serviceP.ListadoDePaises();
            for (int i = 0; i < aux.Length; i++)
            {
                cmbPais.Items.Add(aux[i].Nombre.ToString());
            }

            Provincia[] auxTres = servicePcia.ListadoDeProvincias();
            for(int i = 0; i < auxTres.Length; i++)
            {
                cmbProvincia.Items.Add(auxTres[i].Nombre.ToString());
            }

            Ciudad[] auxDos = serciceC.ListadoDeciudades();
            for (int i = 0; i < auxDos.Length; i++)
            {
                cmbCiudad.Items.Add(auxDos[i].Nombre.ToString());
            }


        }

        
       /* private void cmbPais_SelectedItemChanged (object sender, EventArgs e)
        {
            
            if (cmbPais.SelectedValue.ToString() != "")
            {
                MessageBox.Show("AAA", "aLERTA"); //Chekeo si por lo menos llego aca pero no :(
                string pais = cmbPais.SelectedValue.ToString();

                Provincia[] auxTres = servicePcia.ListadoDeProvinciasPorPais(pais);
                for (int i = 0; i < auxTres.Length; i++)
                {
                    cmbProvincia.Items.Add(auxTres[i].Nombre.ToString());
                }

                cmbPais.SelectedIndex = 0;


            }

        }*/

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            //Se deberia llamar registrar aeropuerto, no crear cuenta. Despues lo cambiamos.


            Ciudad aux = serciceC.ObtenerCiudad(cmbCiudad.Text);
            Aeropuerto colab = new Aeropuerto(txtNombre.Text, (int) aux.IdCiudad);
            
            DialogResult result = MessageBox.Show("¿Esta seguro que desea agregar el aeropuerto?", "Agregar aeropuerto", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {
                serviceA.CrearAeropuerto(colab);
                this.Hide();
                MessageBox.Show("Se ha registrado el aeropuerto correctamente!", "Registro de Aeropuerto Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Principal ventana = new Principal(us);
                ventana.Show();
            }
             

        }
    }
}
