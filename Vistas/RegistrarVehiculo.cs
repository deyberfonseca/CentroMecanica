using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Modelos;
using Conexion.Conexion_BD;

namespace Vistas 
{ 
    public partial class RegistrarVehiculo : Form
    {
        ConexionBd cn = new ConexionBd();
        public RegistrarVehiculo()
        {
            InitializeComponent();
            cmbAño.ValueMember = "Año";
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        #region BotonRegistrar
        private void btnRegistrarVehiculos_Click(object sender, EventArgs e)
        {
            if (!(txtPropietario.Text.Equals(string.Empty) || txtMarca.Text.Equals(string.Empty) || txtModelo.Text.Equals(string.Empty)
                || txtPlaca.Text.Equals(string.Empty) || cmbAño.SelectedIndex.Equals(-1)))
            {
                try
                {
                    bool existe;
                    List<Vehiculo> misVehiculos = new List<Vehiculo>();
                    misVehiculos = cn.ObtenerVehiculos();

                    existe = validacionID(txtPlaca.Text, misVehiculos);

                    if (existe == true)
                    {
                        MessageBox.Show("Placa de vehiculo ya se encuentra registrada !!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Registrar();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show("Datos Incorrectos !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Se requiere la información completa !!!", "Atención !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        #region ValidaciónID
        private bool validacionID(string placa, List<Vehiculo> vehiculo)
        {
            for (int i = 0; i < vehiculo.Count; i++)// ciclo de control
            {
                if (vehiculo[i].Placa == placa)//se valida la existencia
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region RegistroVehiculos
        private void Registrar()
        {
            try
            {
                Vehiculo ve = new Vehiculo (txtPlaca.Text, txtMarca.Text, txtModelo.Text,cmbAño.SelectedIndex+1970,txtPropietario.Text );
                cn.InsertarVehiculos(ve);

                MessageBox.Show("Registro Correcto !! Información: \n\n" + ve.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);// Mensaje de pantalla de registro correcto

                // limpieza de campos
                txtPropietario.Text = "";
                txtPlaca.Text = "";
                txtModelo.Text = "";
                txtMarca.Text = "";
                cmbAño.SelectedIndex = -1;
            }
            catch (Exception)
            {
                MessageBox.Show("Registro incorrecto !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
