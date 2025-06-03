using System;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class EventosDatos
    {
        //Cadena de conexion a SQL Server 
        public string CadenaConexion = "Server=.;Database=Eventos;Integrated Security=true" + " ;TrustServerCertificate=True;";
        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(CadenaConexion);
        }
    }

}
