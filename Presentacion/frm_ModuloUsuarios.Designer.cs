namespace Presentacion
{
    partial class frm_ModuloUsuarios
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_id = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_pnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_smombre = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_papellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_sapellido = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contacto = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_correo = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_direccion = new MaterialSkin.Controls.MaterialTextBox();
            this.cbx_sexo = new MaterialSkin.Controls.MaterialComboBox();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.btn_guardar = new MaterialSkin.Controls.MaterialButton();
            this.btn_actualizar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_id
            // 
            this.txt_id.AnimateReadOnly = false;
            this.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_id.Depth = 0;
            this.txt_id.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_id.Hint = "Identificación";
            this.txt_id.LeadingIcon = null;
            this.txt_id.Location = new System.Drawing.Point(12, 29);
            this.txt_id.MaxLength = 50;
            this.txt_id.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_id.Multiline = false;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(293, 50);
            this.txt_id.TabIndex = 0;
            this.txt_id.Text = "";
            this.txt_id.TrailingIcon = null;
            // 
            // txt_pnombre
            // 
            this.txt_pnombre.AnimateReadOnly = false;
            this.txt_pnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pnombre.Depth = 0;
            this.txt_pnombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_pnombre.Hint = "Primer Nombre";
            this.txt_pnombre.LeadingIcon = null;
            this.txt_pnombre.Location = new System.Drawing.Point(311, 29);
            this.txt_pnombre.MaxLength = 50;
            this.txt_pnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_pnombre.Multiline = false;
            this.txt_pnombre.Name = "txt_pnombre";
            this.txt_pnombre.Size = new System.Drawing.Size(293, 50);
            this.txt_pnombre.TabIndex = 1;
            this.txt_pnombre.Text = "";
            this.txt_pnombre.TrailingIcon = null;
            // 
            // txt_smombre
            // 
            this.txt_smombre.AnimateReadOnly = false;
            this.txt_smombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_smombre.Depth = 0;
            this.txt_smombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_smombre.Hint = "Segundo Nombre";
            this.txt_smombre.LeadingIcon = null;
            this.txt_smombre.Location = new System.Drawing.Point(610, 29);
            this.txt_smombre.MaxLength = 50;
            this.txt_smombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_smombre.Multiline = false;
            this.txt_smombre.Name = "txt_smombre";
            this.txt_smombre.Size = new System.Drawing.Size(293, 50);
            this.txt_smombre.TabIndex = 2;
            this.txt_smombre.Text = "";
            this.txt_smombre.TrailingIcon = null;
            // 
            // txt_papellido
            // 
            this.txt_papellido.AnimateReadOnly = false;
            this.txt_papellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_papellido.Depth = 0;
            this.txt_papellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_papellido.Hint = "Primer Apellido";
            this.txt_papellido.LeadingIcon = null;
            this.txt_papellido.Location = new System.Drawing.Point(12, 85);
            this.txt_papellido.MaxLength = 50;
            this.txt_papellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_papellido.Multiline = false;
            this.txt_papellido.Name = "txt_papellido";
            this.txt_papellido.Size = new System.Drawing.Size(293, 50);
            this.txt_papellido.TabIndex = 3;
            this.txt_papellido.Text = "";
            this.txt_papellido.TrailingIcon = null;
            // 
            // txt_sapellido
            // 
            this.txt_sapellido.AnimateReadOnly = false;
            this.txt_sapellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sapellido.Depth = 0;
            this.txt_sapellido.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sapellido.Hint = "Segundo Apellido";
            this.txt_sapellido.LeadingIcon = null;
            this.txt_sapellido.Location = new System.Drawing.Point(311, 85);
            this.txt_sapellido.MaxLength = 50;
            this.txt_sapellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_sapellido.Multiline = false;
            this.txt_sapellido.Name = "txt_sapellido";
            this.txt_sapellido.Size = new System.Drawing.Size(293, 50);
            this.txt_sapellido.TabIndex = 4;
            this.txt_sapellido.Text = "";
            this.txt_sapellido.TrailingIcon = null;
            // 
            // txt_contacto
            // 
            this.txt_contacto.AnimateReadOnly = false;
            this.txt_contacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contacto.Depth = 0;
            this.txt_contacto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contacto.Hint = "Contacto";
            this.txt_contacto.LeadingIcon = null;
            this.txt_contacto.Location = new System.Drawing.Point(610, 85);
            this.txt_contacto.MaxLength = 50;
            this.txt_contacto.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contacto.Multiline = false;
            this.txt_contacto.Name = "txt_contacto";
            this.txt_contacto.Size = new System.Drawing.Size(293, 50);
            this.txt_contacto.TabIndex = 5;
            this.txt_contacto.Text = "";
            this.txt_contacto.TrailingIcon = null;
            // 
            // txt_correo
            // 
            this.txt_correo.AnimateReadOnly = false;
            this.txt_correo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_correo.Depth = 0;
            this.txt_correo.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_correo.Hint = "Correo";
            this.txt_correo.LeadingIcon = null;
            this.txt_correo.Location = new System.Drawing.Point(12, 141);
            this.txt_correo.MaxLength = 50;
            this.txt_correo.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_correo.Multiline = false;
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.Size = new System.Drawing.Size(592, 50);
            this.txt_correo.TabIndex = 6;
            this.txt_correo.Text = "";
            this.txt_correo.TrailingIcon = null;
            // 
            // txt_direccion
            // 
            this.txt_direccion.AnimateReadOnly = false;
            this.txt_direccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_direccion.Depth = 0;
            this.txt_direccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_direccion.Hint = "Dirección";
            this.txt_direccion.LeadingIcon = null;
            this.txt_direccion.Location = new System.Drawing.Point(12, 197);
            this.txt_direccion.MaxLength = 50;
            this.txt_direccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_direccion.Multiline = false;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(891, 50);
            this.txt_direccion.TabIndex = 7;
            this.txt_direccion.Text = "";
            this.txt_direccion.TrailingIcon = null;
            // 
            // cbx_sexo
            // 
            this.cbx_sexo.AutoResize = false;
            this.cbx_sexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_sexo.Depth = 0;
            this.cbx_sexo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_sexo.DropDownHeight = 174;
            this.cbx_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_sexo.DropDownWidth = 121;
            this.cbx_sexo.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_sexo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_sexo.FormattingEnabled = true;
            this.cbx_sexo.IntegralHeight = false;
            this.cbx_sexo.ItemHeight = 43;
            this.cbx_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Prefiero no decirlo"});
            this.cbx_sexo.Location = new System.Drawing.Point(610, 141);
            this.cbx_sexo.MaxDropDownItems = 4;
            this.cbx_sexo.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_sexo.Name = "cbx_sexo";
            this.cbx_sexo.Size = new System.Drawing.Size(293, 49);
            this.cbx_sexo.StartIndex = 0;
            this.cbx_sexo.TabIndex = 8;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(807, 256);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 9;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_guardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_guardar.Depth = 0;
            this.btn_guardar.HighEmphasis = true;
            this.btn_guardar.Icon = null;
            this.btn_guardar.Location = new System.Drawing.Point(711, 256);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_guardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_guardar.Size = new System.Drawing.Size(88, 36);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_guardar.UseAccentColor = false;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_actualizar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_actualizar.Depth = 0;
            this.btn_actualizar.HighEmphasis = true;
            this.btn_actualizar.Icon = null;
            this.btn_actualizar.Location = new System.Drawing.Point(594, 256);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_actualizar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_actualizar.Size = new System.Drawing.Size(109, 36);
            this.btn_actualizar.TabIndex = 11;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_actualizar.UseAccentColor = false;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // frm_ModuloUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 302);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cbx_sexo);
            this.Controls.Add(this.txt_direccion);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.txt_contacto);
            this.Controls.Add(this.txt_sapellido);
            this.Controls.Add(this.txt_papellido);
            this.Controls.Add(this.txt_smombre);
            this.Controls.Add(this.txt_pnombre);
            this.Controls.Add(this.txt_id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_ModuloUsuarios";
            this.Text = "MÓDULO - REGISTRO USUARIOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_id;
        private MaterialSkin.Controls.MaterialTextBox txt_pnombre;
        private MaterialSkin.Controls.MaterialTextBox txt_smombre;
        private MaterialSkin.Controls.MaterialTextBox txt_papellido;
        private MaterialSkin.Controls.MaterialTextBox txt_sapellido;
        private MaterialSkin.Controls.MaterialTextBox txt_contacto;
        private MaterialSkin.Controls.MaterialTextBox txt_correo;
        private MaterialSkin.Controls.MaterialTextBox txt_direccion;
        private MaterialSkin.Controls.MaterialComboBox cbx_sexo;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialButton btn_guardar;
        private MaterialSkin.Controls.MaterialButton btn_actualizar;
    }
}

