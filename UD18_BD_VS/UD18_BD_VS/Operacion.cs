using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace UD18_BD_VS
{
    public class Operacion
    {
        SqlConnection conexion;

        public void CrearBD(string nombreBD) {
            string cadena = "CREATE DATABASE " + nombreBD;

            try
            {
                conexion = new SqlConnection("server=192.168.1.40; database=EJ18; User id=sa; Password=PASS");
                conexion.Open();

                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("BD creado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
        }

        public void ConectarBD(string nombreBD)
        {
            try
            {
                conexion = new SqlConnection("server=192.168.1.40; Database=" + nombreBD + "; User id=sa; Password=PASS");
                conexion.Open();
                Console.WriteLine("Conectado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DesconectarBD()
        {
            try
            {
                conexion.Close();
                Console.WriteLine("Desconectado");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Ejecutar(string cadena)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("comando ejecutado correctamente");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void Leer(string cadena)
        {
            try
            {
                SqlCommand comando = new SqlCommand(cadena, conexion);
                SqlDataReader registros = comando.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(registros);

                foreach (DataRow dr in dt.Rows)
                {
                    int i = 0;
                    foreach (DataColumn dc in dt.Columns)
                    {
                        Console.WriteLine("{0}: {1}", dc.ColumnName, dr[i]);
                        i++;
                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }

    }
}
