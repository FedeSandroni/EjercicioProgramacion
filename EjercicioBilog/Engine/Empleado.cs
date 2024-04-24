using Engine;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Azure.Core.HttpHeader;

namespace Motor
{
    public class Empleado
    {
        public string ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }

        public int AgregarEmeplado(Empleado empleado)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.CommandText = "SP_AgregarEmpleado";
                command.Parameters.Add("ID", SqlDbType.VarChar).Value = empleado.ID;
                command.Parameters.Add("Nombre", SqlDbType.VarChar).Value = empleado.nombre;
                command.Parameters.Add("Apellido", SqlDbType.VarChar).Value = empleado.apellido;

                using (SqlConnection connection = new SqlConnection(Globals.connectionString))
                {
                    int counterRowsAffected = 0;
                    command.Connection = connection;
                    connection.Open();
                    counterRowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return counterRowsAffected;
                }
            }
        }
    }
}
