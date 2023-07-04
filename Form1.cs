using System;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SisAsitencia
{
    public partial class Form1 : Form, IFormCommunication
    {
        private SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();

            string connectionString = $"Data Source={Program.databaseFilePath};Version=3;";
            connection = new SQLiteConnection(connectionString);
            connection.Open();

            if (Program.VerificarExistenciaTabla("T_colegio", connection) && Program.VerificarExistenciaRegistrosTabla("T_colegio", connection))
            {
                byte[] escudoBytes = ObtenerEscudoBytesDeT_Colegio();
                SetEscudoImagen(escudoBytes);

                // Mostrar los valores de v_nombre_colegio y v_año en las etiquetas correspondientes
                string selectQuery = "SELECT v_nombre_colegio, v_año FROM T_colegio LIMIT 1";
                using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Etiqueta_Titulo2.Text = reader["v_nombre_colegio"].ToString();
                            Etiqueta_Titulo3.Text = reader["v_año"].ToString();
                            Etiqueta_Titulo2.Visible = true;
                            Etiqueta_Titulo3.Visible = true;
                        }
                    }
                }
            }

            this.Load += Form1_Load;
            this.Resize += Form1_Resize;
        }

        private byte[] ObtenerEscudoBytesDeT_Colegio()
        {
            // Obtener el valor de v_escudo del primer registro
            string selectQuery = "SELECT v_escudo FROM T_colegio LIMIT 1";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        byte[] escudo = (byte[])reader["v_escudo"];
                        return escudo;
                    }
                }
            }

            return null;
        }

        private void SetEscudoImagen(byte[] escudoBytes)
        {
            if (escudoBytes == null) return;
            using (var stream = new MemoryStream(escudoBytes))
            {
                Escudo_imag.Image = Image.FromStream(stream);
                Escudo_imag.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        // Implementación de IFormCommunication
        public void SetMainForm(Form1 mainForm)
        {
            // No es necesario implementar, Form1 ya es el formulario principal
        }

        public void ShowFormInMainPanel(Form form)
        {
            // Limpia el panel principal primero
            Panel_principal.Controls.Clear();

            // Ajusta el formulario para que se ajuste al panel
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            // Añade el formulario al panel y lo muestra
            Panel_principal.Controls.Add(form);
            form.Show();
        }

        private void bot_ingresar_Click(object sender, EventArgs e)
        {
            string usuario = textBox_usuario.Text;
            string contraseña = textBox_contraseña.Text;

            string selectQuery = "SELECT COUNT(*) FROM T_usuarios WHERE v_usuario = @Usuario AND v_contraseña = @Contraseña";
            using (SQLiteCommand command = new SQLiteCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);

                int count = Convert.ToInt32(command.ExecuteScalar());

                if (count > 0)
                {
                    Panel_principal.Visible = true;

                    if (Program.VerificarExistenciaTabla("T_colegio", connection) && Program.VerificarExistenciaRegistrosTabla("T_colegio", connection))
                    {
                        Form3 form3 = new Form3();
                        form3.SetMainForm(this); // Configura el formulario principal en form3
                        ShowFormInMainPanel(form3); // Mostrar Form3 en el panel principal
                    }
                    else
                    {
                        Form2 form2 = new Form2();
                        form2.SetMainForm(this); // Configura el formulario principal en form2
                        ShowFormInMainPanel(form2); // Mostrar Form2 en el panel principal
                    }
                }
            }
        }

        private void Panel_principal_Paint(object sender, PaintEventArgs e)
        {
            // No es necesario implementar aquí
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CenterLabels();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            CenterLabels();
        }

        private void CenterLabels()
        {
            // Centrar las etiquetas en la ventana principal
            int windowWidth = this.Width;
            int windowHeight = this.Height;

            CenterLabel(Etiqueta_Titulo, windowWidth);
            CenterLabel(Etiqueta_Titulo2, windowWidth);
            CenterLabel(Etiqueta_Titulo3, windowWidth);
        }

        private void CenterLabel(Label label, int windowWidth)
        {
            int labelWidth = label.Width;
            int labelX = (windowWidth - labelWidth) / 2;
            label.Location = new Point(labelX, label.Location.Y);
        }
    }
}
