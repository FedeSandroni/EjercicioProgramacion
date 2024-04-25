using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlDataAdapter = Microsoft.Data.SqlClient.SqlDataAdapter;

namespace Motor
{
    public class Globals
    {
        /// <summary>
        /// EJEMPLO DE CONNECTIONSTRING A BASE DE DATOS
        /// </summary>

        public static readonly string connectionString = "Data Source=test.ct6qkoeayvxd.us-east-2.rds.amazonaws.com,1433;Database=GestionEmpleados;User Id=Bilog;Password=BilogTest1234;TrustServerCertificate=true";


        /// <summary>
        /// Para ejecutar UPDATE, INSERT EN SQL, DEVUELVE LA CANTIDAD DE FILAS AFECTADAS
        /// </summary>
        /// <param Name="query"></param>
        /// <returns></returns>

        public static int ExecuteNonQuery(string query)
        {
            int b;
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            SqlCommand com = new SqlCommand(query, conexion);
            b = com.ExecuteNonQuery();
            com.Dispose();
            conexion.Close();
            conexion.Dispose();

            return b;
        }


        /// <summary>
        ///  DEVUELVE UN ENTERO, SIRVE PARA INSERTAR SOLO NUMEROS EN BASE DE DATOS (ES MÁS RAPIDA QUE UNA QUERY NORMAL. TIENE UN TRY POR SI ENVIAN CONSULTA NORMAL EN CASO DE QUE ARROJE ERROR Y NO PODER INSERTAR NADA DEVUELVE -1)
        /// </summary>
        /// <param Name="query"></param>
        /// <returns></returns>
        public static int CommandExecuteQueryScalar(string query)
        {
            int result = 0;
            try
            {

                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.CommandType = CommandType.Text;
                result = Convert.ToInt32(cmd.ExecuteScalar());
                cmd.Dispose();
                conexion.Close();
                conexion.Dispose();
            }
            catch
            {
                return -1;
            }

            return result;
        }

        /// <summary>
        /// SE RECOMIENDA CONTAR ROWS ANTES DE HACER ALGO DEVUELVE TABLA VACIA SI LA QUERY ESTA MAL O NO HAY DATOS
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string query)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            SqlDataAdapter adapter = null;
            DataSet dtSet = new DataSet();
            conexion.Open();
            adapter = new SqlDataAdapter(query, conexion);

            try
            {
                adapter.Fill(dtSet, "table");
            }
            catch
            {
            }

            DataTable table = dtSet.Tables.Count > 0 ? dtSet.Tables[0] : new DataTable("table");
            adapter.Dispose();
            conexion.Close();
            conexion.Dispose();
            return table;
        }
    }
}
