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
    public partial class ValidarReparacion : Form
    {
        ConexionBd cn = new ConexionBd();
        public ValidarReparacion()
        {
            InitializeComponent();
            Iniciar();
            dtpFechaSalida.Value = DateTime.Today;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        #region Iniciar
        private void Iniciar()
        {
            DataTable dt = new DataTable();
            dt = cn.PendientesValidar();
            dgvPendientes.DataSource = dt;

            cmbIdRep.DataSource = dt;
            cmbIdRep.ValueMember = "IdReparacion";
            cmbIdRep.DisplayMember = "IdReparacion";
            cmbIdRep.SelectedIndex = -1;

        }
        #endregion

        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (!(cmbIdRep.SelectedIndex.Equals(-1) || txtCosto.Text.Equals(string.Empty) ))
            {
                try
                {
                    cn.Validar(decimal.Parse(txtCosto.Text), dtpFechaSalida.Value, int.Parse(cmbIdRep.SelectedValue.ToString()));
                    Iniciar();
                    MessageBox.Show("Validación Correcta  !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmbIdRep.SelectedIndex = -1;
                    txtCosto.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Error de Validación  !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("Se requiere toda la Información !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
