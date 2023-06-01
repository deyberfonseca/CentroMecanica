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
    public partial class ConsultaMecanicos : Form
    {
        ConexionBd cn = new ConexionBd();
        public ConsultaMecanicos()
        {
            InitializeComponent();
            Inicio();
        }

        private void Inicio()
        {
            List<Mecanicos> mecanicos = new List<Mecanicos>();
            mecanicos = cn.ObtenerMecanicos();

            dgvMecanicos.DataSource = mecanicos;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

    }
}
