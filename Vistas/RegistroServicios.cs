using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conexion.Conexion_BD;
using Entidades.Modelos;

namespace Vistas
{
    public partial class RegistroServicios : Form
    {
        ConexionBd cn = new ConexionBd();
        public RegistroServicios()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        #region Boton Registrar
        private void btnRegistrarMecanicos_Click(object sender, EventArgs e)
        {
            if (!( txtId.Text.Equals(string.Empty) || txtDescripcion.Text.Equals(string.Empty)  ))
            {
                try
                {
                    bool existe;

                    List<Servicio> srv = new List<Servicio>();
                    srv = cn.ObtenerServicios();
                    existe = validacionID(int.Parse(txtId.Text), srv);

                    if (existe == true)
                    {
                        MessageBox.Show("El Id del Servicio ya se encuentra en uso !!!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        Registrar();
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                MessageBox.Show("Se requiere la información completa !!!", "Atención !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region ValidaciónID
        private bool validacionID(int id, List<Servicio> servicio)
        {
            for (int i = 0; i < servicio.Count; i++)// ciclo de control
            {
                if (servicio[i].IdServicio == id)//se valida la existencia
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region RegistroServicios
        private void Registrar()
        {
            try
            {
                Servicio servicio = new Servicio(int.Parse(txtId.Text), txtDescripcion.Text);
                cn.InsertarServicios(servicio);
                MessageBox.Show("Registro Correcto !! Información: \n\n" + servicio.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);// Mensaje de pantalla de registro correcto

                // limpieza de campos
                txtId.Text = "";
                txtDescripcion.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Registro incorrecto !!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion
    }
}
