﻿using System;
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
        private UsuarioService serviceU;
        private PaisService serviceP;
        private ProvinciaService servicePcia;
        public ConsultarAeropuerto(Usuario us)
        {
            InitializeComponent();
            this.usu = us;
            serviceAero = new AeropuertoService();
            serviceC = new CiudadService();
            serviceU = new UsuarioService();
            serviceP = new PaisService();
            servicePcia = new ProvinciaService();

        }


        private void ConsultarAeropuerto_Load(object sender, EventArgs e)
        {
            Pais[] aux = serviceP.ListadoDePaises();
            for (int i = 0; i < aux.Length; i++)
            {
                cmbPais.Items.Add(aux[i].Nombre.ToString());
            }
            if (!serviceU.ValidarPermiso(usu))
                MessageBox.Show(usu.IdUsuario + " usted no podra acceder a la funcion de eliminar aeropuertos ya que es solo para el personal de CordobaVuela", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
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



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Filtra y ordena
            if (txtNombreAeropuerto.Text != String.Empty && chkOrdenado.Checked)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.FindByNombreOrdenado(txtNombreAeropuerto.Text);
                if (aeropuertos.Length == 0)
                { MessageBox.Show("No se encontraron aeropuertos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    foreach (Aeropuerto oAero in aeropuertos)
                    {
                        dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad), oAero.IdAeropuerto.ToString(), oAero.IdCiudad.ToString() }); ;

                    }
                }
            }

            // Filtra pero no ordena
            if (txtNombreAeropuerto.Text != String.Empty && chkOrdenado.Checked == false)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.FindByNombre(txtNombreAeropuerto.Text);
                if (aeropuertos.Length == 0)
                { MessageBox.Show("No se encontraron aeropuertos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    foreach (Aeropuerto oAero in aeropuertos)
                        dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad), oAero.IdAeropuerto.ToString(), oAero.IdCiudad.ToString() });
                }
            }

            // No filtra pero ordena
            if (txtNombreAeropuerto.Text == String.Empty && chkOrdenado.Checked)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.getAllOrdenado();
                if (aeropuertos.Length == 0)
                { MessageBox.Show("No se encontraron aeropuertos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    foreach (Aeropuerto oAero in aeropuertos)
                        dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad), oAero.IdAeropuerto.ToString(), oAero.IdCiudad.ToString() });
                }
            }

            // No filtra y no ordena
            if (txtNombreAeropuerto.Text == String.Empty && chkOrdenado.Checked == false)
            {
                dgvConsultarAeropuerto.Rows.Clear();
                Aeropuerto[] aeropuertos = serviceAero.getAll();
                if (aeropuertos.Length == 0)
                { MessageBox.Show("No se encontraron aeropuertos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    foreach (Aeropuerto oAero in aeropuertos)
                        dgvConsultarAeropuerto.Rows.Add(new string[] { oAero.Nombre.ToString(), serviceC.FindByIdAndReturnNombre(oAero.IdCiudad), oAero.IdAeropuerto.ToString(), oAero.IdCiudad.ToString() });
                }
            }

            // Hace que cuando alguien busque de manera consecutiva, los botones se desactiven
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;


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

        private void dgv_perfiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(serviceU.ValidarPermiso(usu))
            {
                bool selectedRow = dgvConsultarAeropuerto.CurrentRow.Index != -1;
                btnEliminar.Enabled = selectedRow;
                btnModificar.Enabled = selectedRow;
            }
            
        }

        private void dgvConsultarAeropuerto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Primero validamos si tiene los permisos
            if (serviceU.ValidarPermiso(usu))
            {  
                // Chequeamos que la grilla tiene al menos una fila para quitar
                if (dgvConsultarAeropuerto.Rows.Count > 0)
                {
                    if (MessageBox.Show("Seguro que desea eliminar el aeropuerto seleccionado?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dgvConsultarAeropuerto.CurrentRow.Cells["colId"].Value);
                        if (serviceAero.BorrarAeropuerto(id))
                        {
                            dgvConsultarAeropuerto.Rows.RemoveAt(dgvConsultarAeropuerto.CurrentRow.Index);
                            MessageBox.Show("Aeropuerto eliminado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Ha ocurrido un error al intentar borrar el aeropuerto!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    btnEliminar.Enabled = false;

            }
            else
                MessageBox.Show("Acceso unicamente para personal de CordobaVuela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            // Primero validamos si tiene los permisos
            if (serviceU.ValidarPermiso(usu))
            {
                // Chequeamos que la grilla tiene al menos una fila para quitar
                if (dgvConsultarAeropuerto.Rows.Count > 0)
                {
                    //Aca abrimos el formulario para modificar
                    int id = Convert.ToInt32(dgvConsultarAeropuerto.CurrentRow.Cells["colId"].Value);
                    string nombre = (dgvConsultarAeropuerto.CurrentRow.Cells["colNombre"].Value).ToString();
                    int idCiudad = Convert.ToInt32(dgvConsultarAeropuerto.CurrentRow.Cells["colIdCiudad"].Value);


                    Aeropuerto aero = new Aeropuerto(id, nombre, idCiudad);
                    frmModificarAeropuerto ventana = new frmModificarAeropuerto(usu, aero);
                    this.Hide();
                    ventana.Show();
                    
                }
                else
                    btnModificar.Enabled = false;

            }
            else
                MessageBox.Show("Acceso unicamente para personal de CordobaVuela.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

    }
    }
    


