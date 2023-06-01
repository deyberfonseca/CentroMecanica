using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion.Conexion_BD
{
    public class ConexionBd
    {
        string cadena = "Data Source =.; Initial Catalog = ServiciosMecanicos; Integrated Security = True";
        public SqlConnection conexion = new SqlConnection();

        public ConexionBd()
        {
            conexion.ConnectionString = cadena;
        }

        #region InsertarMecanico
        public void InsertarMecanico(Mecanicos mecanico)
        {
            SqlCommand comando = new SqlCommand("INSERT INTO Mecanico VALUES (@IdMecanico, @Nombre, @PrimerApellido, @SegundoApellido, @Telefono);");
            conexion.Open();
            comando.Parameters.AddWithValue("@IdMecanico", mecanico.IdMecanico);
            comando.Parameters.AddWithValue("@Nombre", mecanico.Nombre);
            comando.Parameters.AddWithValue("@PrimerApellido", mecanico.PrimerApellido);
            comando.Parameters.AddWithValue("@SegundoApellido", mecanico.SegundoApellido);
            comando.Parameters.AddWithValue("@Telefono", mecanico.Telefono);

            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        #endregion

        #region ObtenerMecanicos
        public List<Mecanicos> ObtenerMecanicos()
        {
            List<Mecanicos> mec = new List<Mecanicos>();

            SqlConnection conexion;
            string sentencia;
            SqlCommand comando = new SqlCommand();
            SqlDataReader reader;

            conexion = new SqlConnection(cadena);

            sentencia = "select IdMecanico, Nombre, PrimerApellido, SegundoApellido, Telefono " +
                        "from Mecanico";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    mec.Add(new Mecanicos
                    {
                        IdMecanico = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        PrimerApellido = reader.GetString(2),
                        SegundoApellido = reader.GetString(3),
                        Telefono = reader.GetInt32(4)
                    });

                }
            }

            conexion.Close();

            return mec;

        }
        #endregion

        #region InsertarServicios
        public void InsertarServicios(Servicio servicio)
        {
            SqlCommand comando = new SqlCommand("insert into Servicio Values (@IdServicio, @Descripcion);");

            conexion.Open();
            comando.Parameters.AddWithValue("@IdServicio", servicio.IdServicio);
            comando.Parameters.AddWithValue("@Descripcion", servicio.Descripcion);

            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        #endregion

        #region ObtenerServicios
        public List<Servicio> ObtenerServicios()
        {
            List<Servicio> servicios = new List<Servicio>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadena);

            sentencia = "select IdServicio, Descripcion " +
                      "from Servicio";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    servicios.Add(new Servicio
                    {
                        IdServicio = reader.GetInt32(0),
                        Descripcion = reader.GetString(1)
                    });
                }
            }

            conexion.Close();

            return servicios;

        }
        #endregion

        #region InsertarVehiculos
        public void InsertarVehiculos(Vehiculo vehiculo)
        {
            SqlCommand comando = new SqlCommand("insert into Vehiculo Values (@Placa, @Marca, @Modelo, @Año, @Propietario);");

            conexion.Open();
            comando.Parameters.AddWithValue("@Placa", vehiculo.Placa);
            comando.Parameters.AddWithValue("@Marca", vehiculo.Marca);
            comando.Parameters.AddWithValue("@Modelo", vehiculo.Modelo);
            comando.Parameters.AddWithValue("@Año", vehiculo.Año);
            comando.Parameters.AddWithValue("@Propietario", vehiculo.Propietario);

            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        #endregion

        #region ObtenerVehiculos
        public List<Vehiculo> ObtenerVehiculos()
        {
            List<Vehiculo> vehiculo = new List<Vehiculo>();
            SqlConnection conexion;
            SqlCommand comando= new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadena);

            sentencia = "Select Placa, Marca, Modelo, Año, Propietario " +
                        "From Vehiculo";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    vehiculo.Add(new Vehiculo{
                        Placa=reader.GetString(0),
                        Marca=reader.GetString(1),
                        Modelo=reader.GetString(2),
                        Año=reader.GetInt32(3),
                        Propietario=reader.GetString(4)


                    });
                }
            }

            conexion.Close();

            return vehiculo;
        }
        #endregion

        #region InsertarReparaciones
        public void InsertarReparaciones(Reparaciones reparaciones)
        {
            SqlCommand comando = new SqlCommand("Insert Into Reparacion (IdReparacion, IdMecanico, IdServicio, Placa, Descripcion, FechaIngreso) " +
                "Values (@IdReparacion, @IdMecanico, @IdServicio, @Placa, @Descripcion, @FechaIngreso)");

            conexion.Open();
            comando.Parameters.AddWithValue("@IdReparacion", reparaciones.IdReparacion);
            comando.Parameters.AddWithValue("@IdMecanico", reparaciones.IdMecanico);
            comando.Parameters.AddWithValue("@IdServicio", reparaciones.IdServicio);
            comando.Parameters.AddWithValue("@Placa", reparaciones.Placa);
            comando.Parameters.AddWithValue("@Descripcion", reparaciones.Descripcion);
            comando.Parameters.AddWithValue("@FechaIngreso", reparaciones.FechaIngreso);

            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            conexion.Close();
        }
        #endregion

        #region ObtenerCantidadReparaciones 
        public List<Reparaciones> ObtenerCantidadReparaciones()
        {

            List<Reparaciones> reparaciones = new List<Reparaciones>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadena);

            sentencia = "Select IdReparacion "+
                " From Reparacion";

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    reparaciones.Add(new Reparaciones
                    {
                        IdReparacion=reader.GetInt32(0)

                    });
                }
            }

            conexion.Close();

            return reparaciones;
        }

        #endregion

        #region ObtenerPendientes
        public List<Reparaciones> ObtenerPendientes(/*int id*/)
        {
            List<Reparaciones> reparaciones = new List<Reparaciones>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            string sentencia;
            SqlDataReader reader;

            conexion = new SqlConnection(cadena);

            sentencia = "Select IdReparacion, IdMecanico, IdServicio, Placa, Descripcion, FechaIngreso " +
                "From Reparacion ";
                //"Where IdReparacion = "+id.ToString();

            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;

            conexion.Open();

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    reparaciones.Add(new Reparaciones
                    {
                        IdReparacion=reader.GetInt32(0),
                        IdMecanico=reader.GetInt32(1),
                        IdServicio=reader.GetInt32(2),
                        Placa=reader.GetString(3),
                        Descripcion=reader.GetString(4),
                        FechaIngreso=reader.GetDateTime(5)

                    });
                }
            }

            conexion.Close();

            return reparaciones;
        }
        #endregion

        #region Validar
        public void Validar(decimal costo, DateTime fecha, int id)
        {
            SqlCommand comando = new SqlCommand("Update Reparacion " +
                                                "Set Estado = 1, Costo = @Costo, FechaSalida = @FechaSalida " +
                                                "Where IdReparacion = @IdReparacion");

            conexion.Open();
            comando.Parameters.AddWithValue("@Costo", costo);
            comando.Parameters.AddWithValue("@FechaSalida",fecha );
            comando.Parameters.AddWithValue("@IdReparacion", id);

            comando.Connection = conexion;
            comando.ExecuteNonQuery();

            conexion.Close();

        }
        #endregion

        #region Validadas
        public DataTable Validadas()
        {
            DataTable data = new DataTable();
            conexion = new SqlConnection(cadena);
            conexion.Open();
            SqlCommand comando = new SqlCommand("validadas",conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            adapter.Fill(data);

            conexion.Close();
            return data;
;        }
        #endregion

        #region Pendientes
        public DataTable Pendientes()
        {
            DataTable data = new DataTable();
            conexion = new SqlConnection(cadena);
            conexion.Open();
            SqlCommand comando = new SqlCommand("pendientes", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            adapter.Fill(data);

            conexion.Close();
            return data;
            ;
        }
        #endregion

        #region PendientesValidar
        public DataTable PendientesValidar()
        {
            DataTable data = new DataTable();
            conexion = new SqlConnection(cadena);
            conexion.Open();
            SqlCommand comando = new SqlCommand("pendientesValidar", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(comando);

            adapter.Fill(data);

            conexion.Close();
            return data;
            ;
        }
        #endregion


    }
}
