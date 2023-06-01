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
    public partial class ReparacionesPendientes : Form
    {
        ConexionBd cn = new ConexionBd();
        public ReparacionesPendientes()
        {
            InitializeComponent();
            Iniciar();
        }

        #region Iniciar
        private void Iniciar()
        {
            DataTable dt = new DataTable();
            dt = cn.Pendientes();

            dgvPendientes.DataSource = dt;
            
        }
        #endregion

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
