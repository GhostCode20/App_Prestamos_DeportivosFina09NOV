using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class frm_prestamos : Form
    {
        public frm_prestamos()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_cantidad_prestamo.Clear();
            txt_codigo.Clear();
            txt_descripcion.Clear();
            txt_existencias.Clear();
            txt_id.Clear();
            txt_nombre.Clear();
            txt_nombre_implemento.Clear();
            txt_observaciones.Clear();
            dtg_prestamo.DataSource = null;
            txt_id.Focus();
        }

        private void txt_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cls_prestamos objConsultarP = new cls_prestamos();
                objConsultarP.fnt_consultar(txt_id.Text);
                txt_nombre.Text = objConsultarP.getNombre();
            }
        }

        private void txt_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                cls_prestamos objConsultar = new cls_prestamos();
                objConsultar.fnt_consultar_implemento(txt_codigo.Text);
                txt_existencias.Text = ""+objConsultar.getCantidad();
                txt_nombre_implemento.Text = objConsultar.get_NombreImplemento();
                txt_descripcion.Text = objConsultar.get_Especificaciones();
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt16(txt_cantidad_prestamo.Text) <= Convert.ToInt16(txt_existencias.Text))
            {
                dtg_prestamo.Rows.Add(
                txt_codigo.Text, txt_cantidad_prestamo.Text);
            }
            else
            {
                MessageBox.Show("No puedes superar la cantidad de existencias","Agregar",
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btn_prestamo_Click(object sender, EventArgs e)
        {
            cls_prestamos obj_prestar = new cls_prestamos();
            obj_prestar.fnt_prestamo(txt_id.Text, "123.DULFRANMONTAÑO");
            for(int i = 0; i < dtg_prestamo.RowCount; i++)
            {
                obj_prestar.fnt_det_prestamo(Convert.ToString(dtg_prestamo.Rows[i].Cells[0].Value),
                    Convert.ToInt16(dtg_prestamo.Rows[i].Cells[1].Value));
            }
        }
    }
}