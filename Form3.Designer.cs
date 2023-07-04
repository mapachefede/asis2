namespace SisAsitencia
{
    partial class Form3
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
            this.SuspendLayout();
            // 
            // Etiqueta_Titulo2
            // 
            this.Etiqueta_Titulo2.AutoSize = true;
            this.Etiqueta_Titulo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Etiqueta_Titulo2.Location = new System.Drawing.Point(383, 9);
            this.Etiqueta_Titulo2.Name = "Etiqueta_Titulo2";
            this.Etiqueta_Titulo2.Size = new System.Drawing.Size(208, 33);
            this.Etiqueta_Titulo2.TabIndex = 6;
            this.Etiqueta_Titulo2.Text = "Menú Principal";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.Etiqueta_Titulo2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Etiqueta_Titulo2;
    }
}