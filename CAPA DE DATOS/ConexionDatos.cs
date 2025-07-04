using System;
using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;
using System.Data; // Necesario para DataTable y SqlDataReader

namespace CapaDatos
{
   
    public abstract class  ConnectionToSql
    {
        private readonly string connectionString;
        public ConnectionToSql()
        { 
          connectionString = "Server=.;Database=Nexus;Integrated Security=true;TrustServerCertificate=True;";
        }

        // El método 'protected' significa que solo esta clase y las clases que hereden de ella (como UserKey) pueden usarlo
        protected SqlConnection GetConnection()
        {
            // Este método crea y devuelve un nuevo objeto de conexión listo para ser usado
            return new SqlConnection(connectionString);
        }
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
