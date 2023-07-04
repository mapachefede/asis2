using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace SisAsitencia
{
    internal static class Program
    {
        // Ruta del archivo de base de datos
        public static string databaseFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data\\BD_asis.db");

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string connectionString = $"Data Source={databaseFilePath};Version=3;";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Verificar si la base de datos "BD_asis" existe
                if (!VerificarExistenciaBaseDatos())
                {
                    // La base de datos no existe, crearla
                    CrearBaseDatos();
                }

                // Verificar si la tabla "T_colegio" existe en la base de datos
                if (!VerificarExistenciaTabla("T_colegio", connection))
                {
                    // Crear la tabla "T_colegio"
                    CrearTablaColegio(connection);
                }
                else
                {
                    // Verificar si existe algún registro en la tabla "T_colegio"
                    if (VerificarExistenciaRegistrosTabla("T_colegio", connection))
                    {
                        // Obtener el valor de v_escudo del primer registro
                        byte[] escudo = ObtenerValorEscudo(connection);

                       
                    }
                }

                // Verificar si la tabla "T_usuarios" existe en la base de datos
                if (!VerificarExistenciaTabla("T_usuarios", connection))
                {
                    // Crear la tabla "T_usuarios"
                    CrearTablaUsuarios(connection);

                    // Insertar un registro en la tabla "T_usuarios" con valores predeterminados
                    InsertarRegistroUsuarios(connection, "1", "1");
                }

                Application.Run(new Form1());
            }
        }
        static void CrearTablaColegio(SQLiteConnection connection)
        {
            // Crear la tabla "T_colegio" en la base de datos
            string createTableColegioQuery = "CREATE TABLE T_colegio (id INTEGER PRIMARY KEY, v_nombre_colegio TEXT, v_año INTEGER, v_escudo BLOB)";
            using (SQLiteCommand command = new SQLiteCommand(createTableColegioQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }


        static bool VerificarExistenciaBaseDatos()
        {
            // Verificar si el archivo de base de datos existe
            return File.Exists(databaseFilePath);
        }

        static void CrearBaseDatos()
        {
            // Crear la base de datos SQLite
            SQLiteConnection.CreateFile(databaseFilePath);

            // Establecer la cadena de conexión
            string connectionString = $"Data Source={databaseFilePath};Version=3;";

            // Crear la conexión a la base de datos
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // Crear la tabla "T_colegio"
                string createTableColegioQuery = "CREATE TABLE IF NOT EXISTS T_colegio (id INTEGER PRIMARY KEY, v_nombre_colegio TEXT, v_año INTEGER, v_escudo BLOB)";
                using (SQLiteCommand command = new SQLiteCommand(createTableColegioQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                // Crear la tabla "T_usuarios"
                string createTableUsuariosQuery = "CREATE TABLE IF NOT EXISTS T_usuarios (id INTEGER PRIMARY KEY, v_usuario TEXT, v_contraseña TEXT)";
                using (SQLiteCommand command = new SQLiteCommand(createTableUsuariosQuery, connection))
                {

                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool VerificarExistenciaTabla(string tableName, SQLiteConnection connection)
        {
            // Verificar si la tabla existe en la base de datos
            string checkTableQuery = $"SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='{tableName}'";
            using (SQLiteCommand command = new SQLiteCommand(checkTableQuery, connection))
            {
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        static void CrearTablaUsuarios(SQLiteConnection connection)
        {
            // Crear la tabla "T_usuarios" en la base de datos
            string createTableUsuariosQuery = "CREATE TABLE T_usuarios (id INTEGER PRIMARY KEY, v_usuario TEXT, v_contraseña TEXT)";
            using (SQLiteCommand command = new SQLiteCommand(createTableUsuariosQuery, connection))
            {
                command.ExecuteNonQuery();
            }
        }

        static void InsertarRegistroUsuarios(SQLiteConnection connection, string usuario, string contraseña)
        {
            // Insertar un registro en la tabla "T_usuarios" con valores predeterminados
            string insertQuery = "INSERT INTO T_usuarios (v_usuario, v_contraseña) VALUES (@Usuario, @Contraseña)";
            using (SQLiteCommand command = new SQLiteCommand(insertQuery, connection))
            {
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Contraseña", contraseña);
                command.ExecuteNonQuery();
            }
        }

        public static bool VerificarExistenciaRegistrosTabla(string nombreTabla, SQLiteConnection connection)
        {
            // Verificar si existen registros en la tabla
            string checkRecordsQuery = $"SELECT COUNT(*) FROM {nombreTabla}";
            using (SQLiteCommand command = new SQLiteCommand(checkRecordsQuery, connection))
            {
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        public static byte[] ObtenerValorEscudo(SQLiteConnection connection)
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
    }
}
