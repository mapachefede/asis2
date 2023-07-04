using System;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Drawing;

namespace SisAsitencia
{
    public partial class Form2 : Form, IFormCommunication
    {
        private Form1 mainForm;

        public void SetMainForm(Form1 mainForm)
        {
            this.mainForm = mainForm;
        }

        public void ShowFormInMainPanel(Form form)
        {
            mainForm.ShowFormInMainPanel(form);
        }

        public Form2()
        {
            InitializeComponent();
            button_continuar.Enabled = false; // Deshabilita el botón al inicio
        }

        private void button_examinar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Imágenes|*.bmp;*.gif;*.jpg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaImagen = openFileDialog.FileName;
                textBox_ruta_imagen.Text = rutaImagen;

                try
                {
                    // Carga la imagen en el PictureBox y ajusta el tamaño
                    //}Escudo_imag.Image = Image.FromFile(rutaImagen);
                    //Escudo_imag.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_continuar_Click(object sender, EventArgs e)
        {
            string nombreColegio = textBox_nombre_colegio.Text;
            int año = int.Parse(textBox_año.Text);

            if (!string.IsNullOrEmpty(textBox_ruta_imagen.Text))
            {
                byte[] escudo;
                using (FileStream fileStream = new FileStream(textBox_ruta_imagen.Text, FileMode.Open, FileAccess.Read))
                {
                    using (BinaryReader binaryReader = new BinaryReader(fileStream))
                    {
                        escudo = binaryReader.ReadBytes((int)fileStream.Length);
                    }
                }

                string connectionString = $"Data Source={Program.databaseFilePath};Version=3;";
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = "INSERT INTO T_colegio (v_nombre_colegio, v_año, v_escudo) VALUES (@NombreColegio, @Año, @Escudo)";
                    using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NombreColegio", nombreColegio);
                        command.Parameters.AddWithValue("@Año", año);
                        command.Parameters.AddWithValue("@Escudo", escudo);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Mostrar Form3 en el panel principal utilizando ShowFormInMainPanel
                Form3 form3 = new Form3();
                form3.SetMainForm(this.mainForm);
                ShowFormInMainPanel(form3);

                this.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una imagen del escudo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_nombre_colegio_TextChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }

        private void textBox_año_TextChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }

        private void textBox_ruta_imagen_TextChanged(object sender, EventArgs e)
        {
            CheckInputs();
        }

        private void CheckInputs()
        {
            if (!string.IsNullOrEmpty(textBox_nombre_colegio.Text) &&
                !string.IsNullOrEmpty(textBox_año.Text) &&
                !string.IsNullOrEmpty(textBox_ruta_imagen.Text))
            {
                button_continuar.Enabled = true;
            }
            else
            {
                button_continuar.Enabled = false;
            }
        }
    }
}
