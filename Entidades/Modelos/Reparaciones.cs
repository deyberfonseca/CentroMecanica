using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Reparaciones
    {
        #region Atributos
        private int idReparacion;
        private int idMecanico;
        private int idServicio;
        private string placa;
        private string descripcion;
        private DateTime fechaIngreso;
        private decimal costo;
        private bool estado;
        private DateTime fechaSalida;
        #endregion

        #region Constructores

        public Reparaciones(int idReparacion, int idMecanico, int idServicio, string placa, string descripcion, DateTime fechaIngreso, decimal costo, bool estado, DateTime fechaSalida)
        {
            this.idReparacion = idReparacion;
            this.idMecanico = idMecanico;
            this.idServicio = idServicio;
            this.placa = placa;
            this.descripcion = descripcion;
            this.fechaIngreso = fechaIngreso;
            this.costo = costo;
            this.estado = estado;
            this.fechaSalida = fechaSalida;
        }

        public Reparaciones()
        {
        }

        public Reparaciones(int idReparacion, int idMecanico, int idServicio, string placa, string descripcion, DateTime fechaIngreso)
        {
            this.idReparacion = idReparacion;
            this.idMecanico = idMecanico;
            this.idServicio = idServicio;
            this.placa = placa;
            this.descripcion = descripcion;
            this.fechaIngreso = fechaIngreso;
        }


        #endregion

        #region GetterySetter
        public int IdReparacion { get=>idReparacion; set=>idReparacion=value; }
        public int IdMecanico { get=>idMecanico; set=>idMecanico=value; }
        public int IdServicio { get=>idServicio; set=>idServicio=value; }
        public string Placa { get=>placa; set=>placa=value; }
        public  string Descripcion { get=>descripcion; set=>descripcion=value; }
        public DateTime FechaIngreso { get=>fechaIngreso; set=>fechaIngreso=value; }
        public decimal Costo { get=>costo; set=>costo=value; }
        public bool Estado { get=>estado; set=>estado=value; }
        public DateTime FechaSalida { get=>fechaSalida; set=>fechaSalida=value; }

        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} {5} ",
                IdReparacion, IdMecanico, IdServicio, Placa, Descripcion, FechaIngreso);
        }
        #endregion
    }

}
