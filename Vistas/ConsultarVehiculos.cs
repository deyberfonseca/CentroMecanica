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
    public partial class ConsultarVehiculos : Form
    {
        ConexionBd cn = new ConexionBd();
        public ConsultarVehiculos()
        {
            InitializeComponent();
            Llenar();
        }

        private void Llenar()
        {
            List<Vehiculo> vehiculo = new List<Vehiculo>();
            vehiculo = cn.ObtenerVehiculos();

            dgvVehiculos.DataSource = vehiculo;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
