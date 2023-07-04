using System;
using System.Windows.Forms; // Agregado para reconocer el tipo 'Form'
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAsitencia
{
    public interface IFormCommunication
    {
        void SetMainForm(Form1 mainForm);
        void ShowFormInMainPanel(Form form);
    }

    public class FormCommunication : IFormCommunication
    {
        private Form1 mainForm; // Necesitamos una referencia al formulario principal para mostrar otros formularios

        public void SetMainForm(Form1 mainForm)
        {
            this.mainForm = mainForm;
        }

        public void ShowFormInMainPanel(Form form)
        {
            if (mainForm == null) return;

            mainForm.ShowFormInMainPanel(form); // Llamamos al método del formulario principal
        }
    }
}
