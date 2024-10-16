using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academica
{
    public partial class frm_usuario : Form
    {
        Conexion objConexion = new Conexion();
        DataSet ds = new DataSet();
        DataTable miTabla = new DataTable();

        public int posicion = 0;
        String accion = "nuevo";
        public frm_usuario()
        {
            InitializeComponent();
        }

        private void btnPrimerUsuario_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatosUsuarios();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            actualizarDs();
        }

        private void actualizarDs()
        {
            ds.Clear();
            ds = objConexion.obtenerdatos();
            miTabla = ds.Tables["usuarios"];
            miTabla.PrimaryKey = new DataColumn[] { miTabla.Columns["idUsuario"] };
            grdDatosUsuario.DataSource = miTabla;
            mostrarDatosUsuarios();
        }

        private void mostrarDatosUsuarios()
        {
            if (miTabla.Rows.Count > 0)
            {
                txtUsuario.Text = miTabla.Rows[posicion].ItemArray[1].ToString();
                txtClaveUsuario.Text = miTabla.Rows[posicion].ItemArray[2].ToString();
                txtNombreUsuario.Text = miTabla.Rows[posicion].ItemArray[3].ToString();
                txtDireccionUsuario.Text = miTabla.Rows[posicion].ItemArray[4].ToString();
                txtTelefonoUsuario.Text = miTabla.Rows[posicion].ItemArray[5].ToString();

                lblRegistrosUsuarios.Text = (posicion + 1) + "de" + miTabla.Rows.Count;
            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatosUsuarios();
            }
            else
            {
                MessageBox.Show("Esta en el primer registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < miTabla.Rows.Count - 1)
            {
                posicion++;
                mostrarDatosUsuarios();
            }
            else
            {
                MessageBox.Show("Esta en el ultimo registro", "Navegacion de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            posicion = miTabla.Rows.Count - 1;
            mostrarDatosUsuarios();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {

            if (btnAgregarUsuario.Text == "Agregar")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "cancelar";
                accion = "agregar"; ;
                estadoControles(true);
                limpiarcajas();

                
            }
            else
            {//Guardar
                String[] usuarios = {
                    accion, miTabla.Rows[posicion].ItemArray[0].ToString(),
                    txtUsuario.Text, txtClaveUsuario.Text, txtNombreUsuario.Text, txtDireccionUsuario.Text, txtTelefonoUsuario.Text
                };
                String respuesta = objConexion.administrarUsuarios(usuarios);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnAgregarUsuario.Text = "Agregar";
                    btnModificarUsuario.Text = "Modificar";
                    estadoControles(false);
                    actualizarDs();
                }
            }
           
        }

        private bool ValidarContraseña(string contraseña, string confirmación)
        {
            if (contraseña != confirmación)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!ContieneLetraYNumero(contraseña))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra y un número.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool ContieneLetraYNumero(string contraseña)
        {
            bool tieneLetra = contraseña.Any(char.IsLetter);
            bool tieneNumero = contraseña.Any(char.IsDigit);
            return tieneLetra && tieneNumero;
        }

        private void estadoControles(Boolean estado)
        {
            grbDatosUsuario.Enabled = estado;
            grbNavegacionUsuario.Enabled = !estado;
            btnEliminarUsuario.Enabled = !estado;
        }

        void limpiarcajas()
        {
            txtUsuario.Text = "";
            txtClaveUsuario.Text = "";
            txtNombreUsuario.Text = "";
            txtDireccionUsuario.Text = "";
            txtTelefonoUsuario.Text = "";
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "cancelar";
                accion = "modificar";
                estadoControles(true);
            }
            else
            {//Cancelar
                mostrarDatosUsuarios();
                btnAgregarUsuario.Text = "Agregar";
                btnModificarUsuario.Text = "Modificar";
                estadoControles(false);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar a " + txtNombreUsuario.Text.Trim() + "?", "Eliminar usuario", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String[] usuario = {
                    "eliminar", miTabla.Rows[posicion].ItemArray[0].ToString()
                };
                String respuesta = objConexion.administrarUsuarios(usuario);
                if (respuesta != "1")
                {
                    MessageBox.Show(respuesta, "Error en el registro de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    posicion = 0;
                    actualizarDs();
                    mostrarDatosUsuarios();
                }
        

        }   }
        private void filtrarDatos(String filtro)
        {
            DataView dv = miTabla.DefaultView;
            dv.RowFilter = "usuario like '%" + filtro + "%' OR nombre like '%" + filtro + "%'";
            grdDatosUsuario.DataSource = dv;
        }

        private void txtBuscarUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            filtrarDatos(txtBuscarUsuario.Text);
            seleccionarUsuario();
        }

        private void seleccionarUsuario()
        {
            try
            {
                posicion = miTabla.Rows.IndexOf(miTabla.Rows.Find(grdDatosUsuario.CurrentRow.Cells["idUsuario"].Value.ToString()));
                mostrarDatosUsuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Registro NO encontrado", "Error en la seleccion de usuario", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void grdDatosUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            seleccionarUsuario();
        }

        private void txtClaveUsuario_KeyUp(object sender, KeyEventArgs e)
        {
            string clave = txtClaveUsuario.Text;
            string confirmacion = txtClaveUsuario.Text;

            if (ValidarContraseña(clave, confirmacion))
            {
                MessageBox.Show("Contraseña guardada con éxito.");
            }
        }
    }
}
