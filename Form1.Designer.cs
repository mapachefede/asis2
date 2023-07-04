namespace SisAsitencia
{
    partial class Form1
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
            this.Etiqueta_Titulo = new System.Windows.Forms.Label();
            this.Escudo_imag = new System.Windows.Forms.PictureBox();
            this.Etiqueta_usuario = new System.Windows.Forms.Label();
            this.Etiqueta_contraseña = new System.Windows.Forms.Label();
            this.textBox_contraseña = new System.Windows.Forms.TextBox();
            this.bot_ingresar = new System.Windows.Forms.Button();
            this.textBox_usuario = new System.Windows.Forms.TextBox();
            this.Panel_principal = new System.Windows.Forms.Panel();
            this.Etiqueta_Titulo2 = new System.Windows.Forms.Label();
            this.Etiqueta_Titulo3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Escudo_imag)).BeginInit();
            this.SuspendLayout();
            // 
            // Etiqueta_Titulo
            // 
            this.Etiqueta_Titulo.AutoSize = true;
            this.Etiqueta_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Titulo.Location = new System.Drawing.Point(253, 12);
            this.Etiqueta_Titulo.Name = "Etiqueta_Titulo";
            this.Etiqueta_Titulo.Size = new System.Drawing.Size(492, 39);
            this.Etiqueta_Titulo.TabIndex = 0;
            this.Etiqueta_Titulo.Text = "Sistema General de Asistencia";
            // 
            // Escudo_imag
            // 
            this.Escudo_imag.ErrorImage = null;
            this.Escudo_imag.Location = new System.Drawing.Point(37, 12);
            this.Escudo_imag.Name = "Escudo_imag";
            this.Escudo_imag.Size = new System.Drawing.Size(108, 108);
            this.Escudo_imag.TabIndex = 1;
            this.Escudo_imag.TabStop = false;
            // 
            // Etiqueta_usuario
            // 
            this.Etiqueta_usuario.AutoSize = true;
            this.Etiqueta_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_usuario.Location = new System.Drawing.Point(195, 192);
            this.Etiqueta_usuario.Name = "Etiqueta_usuario";
            this.Etiqueta_usuario.Size = new System.Drawing.Size(116, 31);
            this.Etiqueta_usuario.TabIndex = 2;
            this.Etiqueta_usuario.Text = "Usuario:";
            // 
            // Etiqueta_contraseña
            // 
            this.Etiqueta_contraseña.AutoSize = true;
            this.Etiqueta_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_contraseña.Location = new System.Drawing.Point(195, 295);
            this.Etiqueta_contraseña.Name = "Etiqueta_contraseña";
            this.Etiqueta_contraseña.Size = new System.Drawing.Size(163, 31);
            this.Etiqueta_contraseña.TabIndex = 3;
            this.Etiqueta_contraseña.Text = "Contraseña:";
            // 
            // textBox_contraseña
            // 
            this.textBox_contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_contraseña.Location = new System.Drawing.Point(391, 295);
            this.textBox_contraseña.Name = "textBox_contraseña";
            this.textBox_contraseña.PasswordChar = '*';
            this.textBox_contraseña.Size = new System.Drawing.Size(232, 31);
            this.textBox_contraseña.TabIndex = 5;
            // 
            // bot_ingresar
            // 
            this.bot_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bot_ingresar.Location = new System.Drawing.Point(391, 379);
            this.bot_ingresar.Name = "bot_ingresar";
            this.bot_ingresar.Size = new System.Drawing.Size(232, 35);
            this.bot_ingresar.TabIndex = 6;
            this.bot_ingresar.Text = "Ingresar";
            this.bot_ingresar.UseVisualStyleBackColor = true;
            this.bot_ingresar.Click += new System.EventHandler(this.bot_ingresar_Click);
            // 
            // textBox_usuario
            // 
            this.textBox_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_usuario.Location = new System.Drawing.Point(391, 192);
            this.textBox_usuario.Name = "textBox_usuario";
            this.textBox_usuario.Size = new System.Drawing.Size(232, 31);
            this.textBox_usuario.TabIndex = 4;
            // 
            // Panel_principal
            // 
            this.Panel_principal.Location = new System.Drawing.Point(0, 123);
            this.Panel_principal.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Panel_principal.Name = "Panel_principal";
            this.Panel_principal.Size = new System.Drawing.Size(982, 486);
            this.Panel_principal.TabIndex = 7;
            this.Panel_principal.Visible = false;
            this.Panel_principal.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel_principal_Paint);
            // 
            // Etiqueta_Titulo2
            // 
            this.Etiqueta_Titulo2.AutoSize = true;
            this.Etiqueta_Titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Titulo2.Location = new System.Drawing.Point(389, 51);
            this.Etiqueta_Titulo2.Name = "Etiqueta_Titulo2";
            this.Etiqueta_Titulo2.Size = new System.Drawing.Size(206, 31);
            this.Etiqueta_Titulo2.TabIndex = 8;
            this.Etiqueta_Titulo2.Text = "nombre_colegio";
            this.Etiqueta_Titulo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Etiqueta_Titulo2.Visible = false;
            // 
            // Etiqueta_Titulo3
            // 
            this.Etiqueta_Titulo3.AutoSize = true;
            this.Etiqueta_Titulo3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Titulo3.Location = new System.Drawing.Point(469, 90);
            this.Etiqueta_Titulo3.Name = "Etiqueta_Titulo3";
            this.Etiqueta_Titulo3.Size = new System.Drawing.Size(48, 25);
            this.Etiqueta_Titulo3.TabIndex = 9;
            this.Etiqueta_Titulo3.Text = "año";
            this.Etiqueta_Titulo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Etiqueta_Titulo3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 607);
            this.Controls.Add(this.Etiqueta_Titulo3);
            this.Controls.Add(this.Panel_principal);
            this.Controls.Add(this.bot_ingresar);
            this.Controls.Add(this.textBox_contraseña);
            this.Controls.Add(this.textBox_usuario);
            this.Controls.Add(this.Etiqueta_contraseña);
            this.Controls.Add(this.Etiqueta_usuario);
            this.Controls.Add(this.Escudo_imag);
            this.Controls.Add(this.Etiqueta_Titulo);
            this.Controls.Add(this.Etiqueta_Titulo2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Iniciar Sesion";
            ((System.ComponentModel.ISupportInitialize)(this.Escudo_imag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta_Titulo;
        private System.Windows.Forms.PictureBox Escudo_imag;
        private System.Windows.Forms.Label Etiqueta_usuario;
        private System.Windows.Forms.Label Etiqueta_contraseña;
        private System.Windows.Forms.TextBox textBox_contraseña;
        private System.Windows.Forms.Button bot_ingresar;
        private System.Windows.Forms.TextBox textBox_usuario;
        private System.Windows.Forms.Panel Panel_principal;
        private System.Windows.Forms.Label Etiqueta_Titulo2;
        private System.Windows.Forms.Label Etiqueta_Titulo3;
    }
}

