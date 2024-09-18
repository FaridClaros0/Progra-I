using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;// Esta libreria nos servira para conectarnos a la BD.
using System.Data.SqlClient; // Libreria necesaria para conectarnos a sql server.


namespace Academica
{
    internal class Conexion
    {
        SqlConnection miConexion = new SqlConnection(); //Conectarme a la BD.
        SqlCommand misComandos = new SqlCommand(); // Ejecutar SQL
        SqlDataAdapter miAdaptor = new SqlDataAdapter(); // Intermediario entre mi BD y la aplicacion.
        DataSet ds = new DataSet();// es la representacion grafica de la DB en memoria.

        public Conexion(){
            string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db_academica.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadenaConexion;
            miConexion.Open();
        }

        public DataSet obtenerdatos()
        {
            ds.Clear();
            misComandos.Connection = miConexion;
            misComandos.CommandText = "SELECT * FROM alumnos";
            miAdaptor.SelectCommand = misComandos;
            miAdaptor.Fill(ds, "alumnos");

            return ds;
        }
    }

    
}
