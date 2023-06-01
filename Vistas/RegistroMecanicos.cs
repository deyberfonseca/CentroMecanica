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
    public partial class RegistroMecanicos : Form
    {
        ConexionBd cn = new ConexionBd();
        public RegistroMecanicos()
        {
            InitializeComponent();
        }

        #region Botón Regresar
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
        #endregion

        #region Botón Registrar
        private void btnRegistrarMecanicos_Click(object sender, EventArgs e)
        {
            if (!(txtId.Text.Equals(string.Empty) || txtNombre.Text.Equals(string.Empty) || txtPrimerAp.Text.Equals(string.Empty)
                   || txtSegundoAp.Text.Equals(string.Empty) || txtTelefono.Text.Equals(string.Empty)))
            {
                try
                {

                    bool existe;

                    List<Mecanicos> mecanicos = new List<Mecanicos>();
                    mecanicos = cn.ObtenerMecanicos();
                    existe = validacionID(int.Parse(txtId.Text), mecanicos);

                    if (existe == true)
                    {
                        MessageBox.Show("El Id del Mecánico ya se encuentra en uso !!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private bool validacionID(int identificacion, List<Mecanicos> mecanicos)
        {
            for (int i = 0; i < mecanicos.Count; i++)// ciclo de control
            {
                if (mecanicos[i].IdMecanico == identificacion)//se valida la existencia
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region RegistroMecanicos
        private void Registrar()
        {
            try
            {
                Mecanicos mecanico = new Mecanicos(int.Parse(txtId.Text), txtNombre.Text, txtPrimerAp.Text, txtSegundoAp.Text, int.Parse(txtTelefono.Text));
                cn.InsertarMecanico(mecanico);

                MessageBox.Show("Registro Correcto !! Información: \n\n" + mecanico.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);// Mensaje de pantalla de registro correcto

                // limpieza de campos
                txtId.Text = "";
                txtNombre.Text = "";
                txtPrimerAp.Text = "";
                txtSegundoAp.Text = "";
                txtTelefono.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Registro incorrecto !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
