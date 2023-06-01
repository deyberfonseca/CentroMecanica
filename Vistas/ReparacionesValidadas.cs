using Conexion.Conexion_BD;
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
    public partial class ReparacionesValidadas : Form
    {
        ConexionBd cn = new ConexionBd();
        public ReparacionesValidadas()
        {
            InitializeComponent();
            Inicio();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Inicio()
        {
            DataTable dt = new DataTable();
            dt = cn.Validadas();

            dgvPendientes.DataSource = dt;
        }
    }
}
