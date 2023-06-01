using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Vehiculo
    {
        #region Atributos
        private string placa;
        private string marca;
        private string modelo;
        private int año;
        private string propietario;
        #endregion

        #region Constructores
        public Vehiculo(string placa, string marca, string modelo, int año, string propietario)
        {
            this.placa = placa;
            this.marca = marca;
            this.modelo = modelo;
            this.año = año;
            this.propietario = propietario;
        }

        public Vehiculo()
        {
        }
        #endregion

        #region GetterySetter
        public string Placa { get => placa; set => placa = value; }
        public string Marca { get => marca; set=> marca = value; }
        public string Modelo { get=>modelo; set=>modelo=value; }
        public int Año { get=>año; set=>año=value; }
        public string Propietario { get=>propietario; set=>propietario=value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4} ",
               Placa, Marca, Modelo, Año, Propietario );
        }
        #endregion
    }
}
