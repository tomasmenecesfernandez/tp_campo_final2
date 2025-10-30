using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class acceso
    {
        //SqlConnection conexion = new SqlConnection(@"Data Source=.;Initial Catalog=base_3_año;Integrated Security=True");
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-4FV7E1T\SQLEXPRESS;Initial Catalog=base_3_año;Integrated Security=True");
        SqlCommand comando;
        SqlTransaction transaction;
        public void abrir()
        {
            conexion.Open();
        }
        public void escribir(string consulta, Hashtable hdatos)
        {
            abrir();
            comando = new SqlCommand();
            transaction = conexion.BeginTransaction();
            comando = new SqlCommand(consulta, conexion, transaction);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                if (hdatos != null)
                {
                    foreach (string datos in hdatos.Keys)
                    {
                        comando.Parameters.AddWithValue(datos, hdatos[datos]);
                    }
                }
                comando.ExecuteNonQuery();
                transaction.Commit();
            }
            catch (SqlException ex)
            {
                transaction.Rollback();
                throw ex;
            }
            finally { conexion.Close(); }

        }
        public DataTable leer_tabla(string consulta, Hashtable parametros)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adactador;
            comando = new SqlCommand(consulta, conexion);
            comando.CommandType = CommandType.StoredProcedure;
            try
            {
                adactador = new SqlDataAdapter(comando);

                if (parametros != null)
                {

                    foreach (string dato in parametros.Keys)
                    {
                        comando.Parameters.AddWithValue(dato, parametros[dato]);
                    }

                }
            }
            catch (SqlException ex)
            { throw ex; }
            catch (Exception ex)
            { throw ex; }
            adactador.Fill(tabla);
            return tabla;



        }
    }
}
