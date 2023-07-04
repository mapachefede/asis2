using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SisAsitencia
{
    public partial class Form3 : Form, IFormCommunication
    {
        private Form1 mainForm;

        public Form3()
        {
            InitializeComponent();
        }

        // Implementación de IFormCommunication
        public void SetMainForm(Form1 mainForm)
        {
            this.mainForm = mainForm;
        }

        public void ShowFormInMainPanel(Form form)
        {
            mainForm.ShowFormInMainPanel(form);
        }

        // Define the Form3_Load method here:
        private void Form3_Load(object sender, EventArgs e)
        {
            // Tu código aquí
        }

        

        private void Escudo_imag_Click(object sender, EventArgs e)
        {
            // Tu código aquí
        }

        // El resto del código...
    }
}
