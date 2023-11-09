using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Negocio
{
    public class cls_ModuloUsuarios
    {
        private String str_id;
        private String str_pnombre;
        private String str_snombre;
        private String str_papellido;
        private String str_sapellido;
        private String str_contacto;
        private String str_correo;
        private String str_direccion;
        private String str_sexo;
        cls_Conexion objConectar = new cls_Conexion();
        public void fnt_guardar(String id, String p_nombre,String s_nombre, String p_apellido, String s_apellido, String contacto,
            String correo, String direccion, String sexo)
        {
            if(id.Equals("") || p_nombre.Equals("") || s_nombre.Equals("") || p_apellido.Equals("") || s_apellido.Equals("") ||
                contacto.Equals("") || correo.Equals("") || direccion.Equals(""))
            {
                MessageBox.Show("Debe ingresar todos los datos","Registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                SqlCommand con = new SqlCommand("SP_RegistrarPersonas", objConectar.connection);
                con.CommandType = CommandType.StoredProcedure;
                con.Parameters.AddWithValue("@id", id);
                con.Parameters.AddWithValue("@p_nombre", p_nombre);
                con.Parameters.AddWithValue("@s_nombre", s_nombre);
                con.Parameters.AddWithValue("@p_apellido", p_apellido);
                con.Parameters.AddWithValue("@s_apellido", s_apellido);
                con.Parameters.AddWithValue("@contacto", contacto);
                con.Parameters.AddWithValue("@correo", correo);
                con.Parameters.AddWithValue("@direccion", direccion);
                con.Parameters.AddWithValue("@sexo", sexo);
                objConectar.connection.Open();
                con.ExecuteNonQuery();
                objConectar.connection.Close();
                MessageBox.Show("Persona registrada con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}