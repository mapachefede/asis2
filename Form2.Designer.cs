namespace SisAsitencia
{
    partial class Form2
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
            this.Etiqueta_Titulo2 = new System.Windows.Forms.Label();
            this.Etiqueta_nombre_colegio = new System.Windows.Forms.Label();
            this.Etiqueta_año = new System.Windows.Forms.Label();
            this.textBox_nombre_colegio = new System.Windows.Forms.TextBox();
            this.textBox_año = new System.Windows.Forms.TextBox();
            this.button_Examinar = new System.Windows.Forms.Button();
            this.Etiqueta_Escudo = new System.Windows.Forms.Label();
            this.button_continuar = new System.Windows.Forms.Button();
            this.textBox_ruta_imagen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Etiqueta_Titulo2
            // 
            this.Etiqueta_Titulo2.AutoSize = true;
            this.Etiqueta_Titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Titulo2.Location = new System.Drawing.Point(350, 9);
            this.Etiqueta_Titulo2.Name = "Etiqueta_Titulo2";
            this.Etiqueta_Titulo2.Size = new System.Drawing.Size(279, 33);
            this.Etiqueta_Titulo2.TabIndex = 3;
            this.Etiqueta_Titulo2.Text = "Configuración Inicial";
            // 
            // Etiqueta_nombre_colegio
            // 
            this.Etiqueta_nombre_colegio.AutoSize = true;
            this.Etiqueta_nombre_colegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_nombre_colegio.Location = new System.Drawing.Point(60, 109);
            this.Etiqueta_nombre_colegio.Name = "Etiqueta_nombre_colegio";
            this.Etiqueta_nombre_colegio.Size = new System.Drawing.Size(260, 31);
            this.Etiqueta_nombre_colegio.TabIndex = 4;
            this.Etiqueta_nombre_colegio.Text = "Nombre del Colegio:";
            // 
            // Etiqueta_año
            // 
            this.Etiqueta_año.AutoSize = true;
            this.Etiqueta_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_año.Location = new System.Drawing.Point(60, 199);
            this.Etiqueta_año.Name = "Etiqueta_año";
            this.Etiqueta_año.Size = new System.Drawing.Size(70, 31);
            this.Etiqueta_año.TabIndex = 5;
            this.Etiqueta_año.Text = "Año:";
            // 
            // textBox_nombre_colegio
            // 
            this.textBox_nombre_colegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_nombre_colegio.Location = new System.Drawing.Point(356, 109);
            this.textBox_nombre_colegio.Name = "textBox_nombre_colegio";
            this.textBox_nombre_colegio.Size = new System.Drawing.Size(469, 31);
            this.textBox_nombre_colegio.TabIndex = 6;
            this.textBox_nombre_colegio.TextChanged += new System.EventHandler(this.textBox_nombre_colegio_TextChanged);
            // 
            // textBox_año
            // 
            this.textBox_año.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_año.Location = new System.Drawing.Point(356, 199);
            this.textBox_año.Name = "textBox_año";
            this.textBox_año.Size = new System.Drawing.Size(232, 31);
            this.textBox_año.TabIndex = 7;
            this.textBox_año.TextChanged += new System.EventHandler(this.textBox_año_TextChanged);
            // 
            // button_Examinar
            // 
            this.button_Examinar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Examinar.Location = new System.Drawing.Point(356, 278);
            this.button_Examinar.Name = "button_Examinar";
            this.button_Examinar.Size = new System.Drawing.Size(232, 35);
            this.button_Examinar.TabIndex = 8;
            this.button_Examinar.Text = "Examinar";
            this.button_Examinar.UseVisualStyleBackColor = true;
            this.button_Examinar.Click += new System.EventHandler(this.button_examinar_Click);
            // 
            // Etiqueta_Escudo
            // 
            this.Etiqueta_Escudo.AutoSize = true;
            this.Etiqueta_Escudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Escudo.Location = new System.Drawing.Point(60, 282);
            this.Etiqueta_Escudo.Name = "Etiqueta_Escudo";
            this.Etiqueta_Escudo.Size = new System.Drawing.Size(255, 31);
            this.Etiqueta_Escudo.TabIndex = 9;
            this.Etiqueta_Escudo.Text = "Escudo del Colegio:";
            // 
            // button_continuar
            // 
            this.button_continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_continuar.Location = new System.Drawing.Point(719, 399);
            this.button_continuar.Name = "button_continuar";
            this.button_continuar.Size = new System.Drawing.Size(232, 35);
            this.button_continuar.TabIndex = 10;
            this.button_continuar.Text = "Continuar";
            this.button_continuar.UseVisualStyleBackColor = true;
            this.button_continuar.Click += new System.EventHandler(this.button_continuar_Click);
            // 
            // textBox_ruta_imagen
            // 
            this.textBox_ruta_imagen.Location = new System.Drawing.Point(356, 364);
            this.textBox_ruta_imagen.Name = "textBox_ruta_imagen";
            this.textBox_ruta_imagen.Size = new System.Drawing.Size(232, 20);
            this.textBox_ruta_imagen.TabIndex = 11;
            this.textBox_ruta_imagen.TextChanged += new System.EventHandler(this.textBox_ruta_imagen_TextChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.textBox_ruta_imagen);
            this.Controls.Add(this.button_continuar);
            this.Controls.Add(this.Etiqueta_Escudo);
            this.Controls.Add(this.button_Examinar);
            this.Controls.Add(this.textBox_año);
            this.Controls.Add(this.textBox_nombre_colegio);
            this.Controls.Add(this.Etiqueta_año);
            this.Controls.Add(this.Etiqueta_nombre_colegio);
            this.Controls.Add(this.Etiqueta_Titulo2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Etiqueta_Titulo2;
        private System.Windows.Forms.Label Etiqueta_nombre_colegio;
        private System.Windows.Forms.Label Etiqueta_año;
        private System.Windows.Forms.TextBox textBox_nombre_colegio;
        private System.Windows.Forms.TextBox textBox_año;
        private System.Windows.Forms.Button button_Examinar;
        private System.Windows.Forms.Label Etiqueta_Escudo;
        private System.Windows.Forms.Button button_continuar;
        private System.Windows.Forms.TextBox textBox_ruta_imagen;
    }
}