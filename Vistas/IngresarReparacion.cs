using Conexion.Conexion_BD;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class IngresarReparacion : Form
    {
        ConexionBd cn = new ConexionBd();
        public IngresarReparacion()
        {
            InitializeComponent();
            Inicio();
            Contador();
        }

        private void btnIngresarReparacionClick(object sender, EventArgs e)
        {
            if (!(txtIdRep.Text.Equals(string.Empty) || cmbMecanico.SelectedIndex.Equals(-1) || cmbPlaca.SelectedIndex.Equals(-1)
                || cmbServicio.SelectedIndex.Equals(-1) || txtDescripcion.Text.Equals(string.Empty)  ))
            {
                try
                {
                    Reparaciones reparaciones = new Reparaciones(int.Parse(txtIdRep.Text), int.Parse(cmbMecanico.SelectedValue.ToString()), int.Parse(cmbServicio.SelectedValue.ToString()), cmbPlaca.SelectedValue.ToString(), txtDescripcion.Text, dtpFechaIng.Value);
                    cn.InsertarReparaciones(reparaciones);
                    MessageBox.Show("Registro Correcto !! Información: \n\n" + reparaciones.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);// Mensaje de pantalla de registro correcto

                    // limpieza de campos
                    cmbPlaca.SelectedIndex = -1;
                    cmbMecanico.SelectedIndex = -1;
                    cmbServicio.SelectedIndex = -1;
                    txtDescripcion.Text = "";
                    Contador();
                }
                catch (Exception)
                {
                    MessageBox.Show("Registro incorrecto !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Se requiere la información completa !!!", "Atención !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        #region Infirmación
        private void Inicio()
        {
            List<Vehiculo> vehiculo = new List<Vehiculo>();
            vehiculo = cn.ObtenerVehiculos();
            cmbPlaca.DataSource = vehiculo;
            cmbPlaca.ValueMember = "Placa";
            cmbPlaca.DisplayMember = "Placa";
            cmbPlaca.SelectedIndex = -1;

            List<Mecanicos> mecanicos = new List<Mecanicos>();
            mecanicos = cn.ObtenerMecanicos();
            cmbMecanico.DataSource = mecanicos;
            cmbMecanico.ValueMember = "IdMecanico";
            cmbMecanico.DisplayMember = "";
            cmbMecanico.SelectedIndex = -1;
        

            List<Servicio> servicios = new List<Servicio>();
            servicios = cn.ObtenerServicios();
            cmbServicio.DataSource = servicios;
            cmbServicio.ValueMember = "IdServicio";
            cmbServicio.DisplayMember = "Descripcion";
            cmbServicio.SelectedIndex = -1;

            dtpFechaIng.Value = DateTime.Today;
        }
        #endregion

        private void Contador()
        {
            List<Reparaciones> reparaciones = new List<Reparaciones>();
            reparaciones = cn.ObtenerCantidadReparaciones();
            int cantidad = reparaciones.Count + 1;
            txtIdRep.Text = cantidad.ToString();
        }
    }
}
