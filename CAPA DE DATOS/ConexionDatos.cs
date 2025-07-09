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
            // Define la cadena de conexión que usarán todas las clases que hereden de esta
            connectionString = "Server=.;Database=Nexus;Integrated Security=true;TrustServerCertificate=True;";
        }

        // El método 'protected' significa que solo esta clase y las clases que hereden de ella (como UserKey y CRUD) pueden usarlo
        protected SqlConnection GetConnection() => new SqlConnection(connectionString); // Este método crea y devuelve un nuevo objeto de conexión listo para ser usado

    }
}




//OPCION #1 Cadena de conexion a SQL Server 
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