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

        public Conexion()
        {
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

            misComandos.CommandText = "SELECT * FROM Materias";
            miAdaptor.Fill(ds, "Materias");

            misComandos.CommandText = "SELECT * FROM docentes";
            miAdaptor.Fill(ds, "docentes");

            return ds;
        }
        public String administrarAlumnos(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO alumnos(codigo, nombre, direccion, telefono, dui) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE alumnos SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" +
                    datos[5] + "', dui='" + datos[6] + "' WHERE idAlumno=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM alumnos WHERE idAlumno=" + datos[1];
            }
            return ejecutarSQL(sql);
            {

            }
        }

        public String administrarDocentes(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO docentes(codigo, nombre, direccion, telefono, dui, email, especialidad) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "','" + datos[5] + "','" + datos[6] + "','" + datos[7]+ "','" + datos[8] + "')" ;
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE docentes SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', direccion='" + datos[4] + "', telefono='" +
                    datos[5] + "', dui='" + datos[6] + "', email='"+datos[7]+ "', especialidad='"+datos[8]+ "' WHERE idDocente=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM docentes WHERE idDocente=" + datos[1];
            }
            return ejecutarSQL(sql);
            {

            }
        }
        public String administrarMaterias(String[] datos)
        {
            String sql = "";
            if (datos[0] == "nuevo")
            {
                sql = "INSERT INTO Materias(codigo, nombre, uv) VALUES('" +
                    datos[2] + "','" + datos[3] + "','" + datos[4] + "')";
            }
            else if (datos[0] == "modificar")
            {
                sql = "UPDATE Materias SET codigo='" + datos[2] + "', nombre='" + datos[3] + "', uv='" + datos[4] +
                    "' WHERE idMateria=" + datos[1];
            }
            else if (datos[0] == "eliminar")
            {
                sql = "DELETE FROM Materias WHERE idMateria=" + datos[1];
            }
            return ejecutarSQL(sql);
        }
        private String ejecutarSQL(String sql)
        {
            try
            {
                misComandos.Connection = miConexion;
                misComandos.CommandText = sql;
                return misComandos.ExecuteNonQuery().ToString();
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }

    
}
