using System;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Data; // Necesario para DataTable y SqlDataReader

namespace CapaDatos
{
    public class EventosDatos
    {
        //OPCION #2 Cadena de conexion a SQL Server 
        private readonly string CadenaConexion = "Server=.;Database=Nexus;Integrated Security=true" + " ;TrustServerCertificate=True;";
        public string ObtenerConexion()
        {
            return CadenaConexion;
        }


        //OPCION #1 Cadena de conexion a SQL Server (conectando a una base de datos llamada Nexus)
        /*private SqlConnection CadenaConexion = new SqlConnection("Server=.;Database=Nexus;Integrated Security=true" + " ;TrustServerCertificate=True;");

        public SqlConnection AbrirConexion()
        {
            if (CadenaConexion.State == ConnectionState.Closed)
            {
                CadenaConexion.Open();
            }
            return CadenaConexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (CadenaConexion.State == ConnectionState.Open)
            {
                CadenaConexion.Close();
            }
            return CadenaConexion;
        }*/
    }

}
