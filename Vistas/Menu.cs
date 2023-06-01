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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegistrarMecanico_Click(object sender, EventArgs e)
        {
            RegistroMecanicos registro = new RegistroMecanicos();
            registro.Show();
            this.Hide();
        }

        private void btnConsultarMec_Click(object sender, EventArgs e)
        {
            ConsultaMecanicos consulta = new ConsultaMecanicos();
            consulta.Show();
            this.Hide();

        }

        private void btnRegistroServ_Click(object sender, EventArgs e)
        {
            RegistroServicios registroServicios = new RegistroServicios();
            registroServicios.Show();
            this.Hide();
        }

        private void btnConsultarServ_Click(object sender, EventArgs e)
        {
            ConsultaServicios consulta = new ConsultaServicios();
            consulta.Show();
            this.Hide();
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            RegistrarVehiculo rv = new RegistrarVehiculo();
            rv.Show();
            this.Hide();
        }

        private void btnConltVeh_Click(object sender, EventArgs e)
        {
            ConsultarVehiculos cv = new ConsultarVehiculos();
            cv.Show();
            this.Hide();
        }

        private void btnIngresarRep_Click(object sender, EventArgs e)
        {
            IngresarReparacion ingresar = new IngresarReparacion();
            ingresar.Show();
            this.Hide();
        }

        private void btnRepPendientes_Click(object sender, EventArgs e)
        {
            ReparacionesPendientes rp = new ReparacionesPendientes();
            rp.Show();
            this.Hide();
        }

        private void btnValidarRep_Click(object sender, EventArgs e)
        {
            ValidarReparacion valRep = new ValidarReparacion();
            valRep.Show();
            this.Hide();
        }

        private void btnRepRealizadas_Click(object sender, EventArgs e)
        {
            ReparacionesValidadas rV = new ReparacionesValidadas();
            rV.Show();
            this.Hide();
        }
    }
}
