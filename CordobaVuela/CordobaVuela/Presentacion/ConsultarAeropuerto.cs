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
    public partial class ConsultarAeropuerto : Form
    {
        private Usuario usu;
        private AeropuertoService serviceAero;
        private CiudadService serviceC;
        public ConsultarAeropuerto(Usuario us)
        {
            InitializeComponent();
            this.usu = us;
            serviceAero = new AeropuertoService();
            serviceC = new CiudadService();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtra y ordena
            if (txtNombreAeropuerto.Text != String.Empty && chkOrdenado.Checked)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.FindByNombreOrdenado(txtNombreAeropuerto.Text);

                foreach (Aeropuerto oAero in aeropuertos)
                {
                    dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad)});

                }
            }
            
            // Filtra pero no ordena
            if (txtNombreAeropuerto.Text != String.Empty && chkOrdenado.Checked == false)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.FindByNombre(txtNombreAeropuerto.Text);
                foreach (Aeropuerto oAero in aeropuertos)
                    dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad) });
            }

            // No filtra pero ordena
            if (txtNombreAeropuerto.Text == String.Empty && chkOrdenado.Checked)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.getAllOrdenado();
                foreach (Aeropuerto oAero in aeropuertos)
                    dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad) });
            }

            // No filtra y no ordena
            if (txtNombreAeropuerto.Text == String.Empty && chkOrdenado.Checked == false)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.getAll();
                foreach (Aeropuerto oAero in aeropuertos)
                    dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad) });
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
           
                Principal ventana = new Principal(usu);
                ventana.Show();
                this.Hide();
            
        }

        private void dgvConsultarAeropuerto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

