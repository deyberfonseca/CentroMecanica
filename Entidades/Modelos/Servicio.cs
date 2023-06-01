using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Servicio
    {
        #region Atruibutos
        private int idServicio;
        private string descripcion;
        #endregion

        #region Constructores
        public Servicio(int idServicio, string descripcion)
        {
            this.idServicio = idServicio;
            this.descripcion = descripcion;
        }

        public Servicio()
        {
        }
        #endregion

        #region GetterySetter
        public int IdServicio { get=>idServicio; set=>idServicio=value; }
        public string Descripcion { get=>descripcion; set=>descripcion=value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format(" {0} {1}  ",
                IdServicio, Descripcion);
        }
        #endregion
    }
}
