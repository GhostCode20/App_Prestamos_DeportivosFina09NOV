namespace Presentacion
{
    partial class frm_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_usuario = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_contraseña = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_cancelar = new MaterialSkin.Controls.MaterialButton();
            this.btn_ingresar = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // txt_usuario
            // 
            this.txt_usuario.AnimateReadOnly = false;
            this.txt_usuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_usuario.Depth = 0;
            this.txt_usuario.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_usuario.Hint = "Usuario";
            this.txt_usuario.LeadingIcon = null;
            this.txt_usuario.Location = new System.Drawing.Point(41, 14);
            this.txt_usuario.MaxLength = 50;
            this.txt_usuario.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_usuario.Multiline = false;
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.Size = new System.Drawing.Size(402, 50);
            this.txt_usuario.TabIndex = 0;
            this.txt_usuario.Text = "";
            this.txt_usuario.TrailingIcon = null;
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.AnimateReadOnly = false;
            this.txt_contraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_contraseña.Depth = 0;
            this.txt_contraseña.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_contraseña.Hint = "Contraseña";
            this.txt_contraseña.LeadingIcon = null;
            this.txt_contraseña.Location = new System.Drawing.Point(41, 70);
            this.txt_contraseña.MaxLength = 50;
            this.txt_contraseña.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_contraseña.Multiline = false;
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.Password = true;
            this.txt_contraseña.Size = new System.Drawing.Size(402, 50);
            this.txt_contraseña.TabIndex = 1;
            this.txt_contraseña.Text = "";
            this.txt_contraseña.TrailingIcon = null;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_cancelar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_cancelar.Depth = 0;
            this.btn_cancelar.HighEmphasis = true;
            this.btn_cancelar.Icon = null;
            this.btn_cancelar.Location = new System.Drawing.Point(347, 124);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_cancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_cancelar.Size = new System.Drawing.Size(96, 36);
            this.btn_cancelar.TabIndex = 2;
            this.btn_cancelar.Text = "cancelar";
            this.btn_cancelar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_cancelar.UseAccentColor = false;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ingresar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_ingresar.Depth = 0;
            this.btn_ingresar.HighEmphasis = true;
            this.btn_ingresar.Icon = null;
            this.btn_ingresar.Location = new System.Drawing.Point(248, 124);
            this.btn_ingresar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_ingresar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_ingresar.Size = new System.Drawing.Size(91, 36);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_ingresar.UseAccentColor = false;
            this.btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(490, 175);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTextBox txt_usuario;
        private MaterialSkin.Controls.MaterialTextBox txt_contraseña;
        private MaterialSkin.Controls.MaterialButton btn_cancelar;
        private MaterialSkin.Controls.MaterialButton btn_ingresar;
    }
}