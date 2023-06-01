using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Mecanicos
    {
        #region Atributos
        private int idMecanico;
        private string nombre;
        private string primerApellido;
        private string segundoApellido;
        private int telefono;
        #endregion

        #region Constructores
        public Mecanicos(int idMecanico, string nombre, string primerApellido, string segundoApellido, int telefono)
        {
            this.idMecanico = idMecanico;
            this.nombre = nombre;
            this.primerApellido = primerApellido;
            this.segundoApellido = segundoApellido;
            this.telefono = telefono;
        }

        public Mecanicos()
        {
        }
        #endregion

        #region GetterySetter
        public int IdMecanico { get => idMecanico; set => idMecanico = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public int Telefono { get => telefono; set => telefono = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format(" {0} {1} {2} ",
                Nombre, PrimerApellido, SegundoApellido);
        }
        #endregion
    }
}
