using System;
using System.Windows.Forms;
using Negocio;
namespace Presentacion
{
    public partial class frm_implementos : Form
    {
        public frm_implementos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_cantidad.Clear();
            txt_codigo.Clear();
            txt_descripcion.Clear();
            txt_nombre.Clear();
            txt_valor.Clear();
            txt_codigo.Focus();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            cls_implementos obj_guardar = new cls_implementos();
            obj_guardar.fnt_registrar(
                txt_codigo.Text,
                txt_nombre.Text,
                txt_descripcion.Text,
                Convert.ToDouble(txt_valor.Text),
                Convert.ToInt16(txt_cantidad.Text));
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cls_implementos objConsultar = new cls_implementos();
                objConsultar.fnt_consultar(txt_codigo.Text);
                txt_nombre.Text = objConsultar.getNombre();
                txt_descripcion.Text = objConsultar.getDescripcion();
                txt_cantidad.Text = Convert.ToString(objConsultar.getCantidad());
                txt_valor.Text = Convert.ToString(objConsultar.getValor());
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            cls_implementos objActualizar = new cls_implementos();
            objActualizar.fnt_actualizar(txt_codigo.Text, txt_nombre.Text, txt_descripcion.Text,
                Convert.ToDouble(txt_valor.Text), Convert.ToInt16(txt_cantidad.Text));
        }
    }
}