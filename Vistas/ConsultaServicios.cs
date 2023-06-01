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
    public partial class ConsultaServicios : Form
    {
        ConexionBd cn = new ConexionBd();
        public ConsultaServicios()
        {
            InitializeComponent();
            Inico();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void Inico()
        {
            List<Servicio> servicios = new List<Servicio>();
            servicios = cn.ObtenerServicios();

            dgvServicios.DataSource = servicios;
        }
    }
}
