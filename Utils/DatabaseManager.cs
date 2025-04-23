using System;
using Microsoft.Data.SqlClient;
using MinecraftManager.Models;
using OfficeOpenXml;
using OfficeOpenXml; // Necesario para EPPlus
using System.IO;

namespace MinecraftManager.Utils
{
    public class DatabaseManager
    {

        private readonly string _connectionString;



        public DatabaseManager()
        {
            _connectionString = "Server=DESKTOP-21B0LCS\\SQLEXPRESS;Database=parcial2;Integrated Security=True; TrustServerCertificate=True;";
        }

        public SqlConnection GetConnection()
        {
            var connection = new SqlConnection(_connectionString);
            return connection;
        }

        public bool ValidarUsuarioEnBaseDeDatos(string usuario)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT COUNT(*) FROM Jugadores WHERE Nombre = @Usuario";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);

                try
                {
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Si existe al menos un registro, el usuario es válido
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al validar el usuario: {ex.Message}");
                    return false;
                }
            }
        }

        public bool TestConnection()
        {
            try
            {
                using var connection = GetConnection();
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error de conexión: {ex.Message}");
                return false;
            }
        }

        //public string? ObtenerBloquesPorRareza(string rareza)
        //{
        //    using (SqlConnection connection = new SqlConnection(_connectionString))
        //    {
        //        string query = "SELECT Nombre FROM Bloques WHERE Rareza = @Rareza";
        //        try
        //        {
        //            SqlCommand command = new SqlCommand(query, connection);
        //            command.Parameters.AddWithValue("@Rareza", rareza);
        //            connection.Open();
        //            SqlDataReader reader = command.ExecuteReader();

        //            if (reader.Read())
        //            {
        //                return reader["Nombre"].ToString();
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //    return null;
        //}
        public int? ObtenerIdJugadorPorNombre(string nombre)
        {
            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Id FROM Jugadores WHERE Nombre = @Nombre";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nombre", nombre);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    return result != null ? (int?)Convert.ToInt32(result) : null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el Id del jugador: {ex.Message}");
                    return null;
                }
            }
        }



        public bool ExportarInventarioAExcel(string jugadorId, string rutaArchivo)
        {
            using (SqlConnection connection = GetConnection())
            {
                // Consulta SQL actualizada con los nombres correctos de las columnas
                string query = "SELECT Id, BloqueId, Cantidad FROM Inventario WHERE JugadorId = @JugadorId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JugadorId", jugadorId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No se encontraron datos para el jugador especificado.");
                        return false;
                    }



                    // Crear el archivo Excel
                    using (ExcelPackage excel = new ExcelPackage())
                    {
                        var hoja = excel.Workbook.Worksheets.Add("Inventario");

                        // Escribir encabezados
                        hoja.Cells[1, 1].Value = "Id";
                        hoja.Cells[1, 2].Value = "BloqueId";
                        hoja.Cells[1, 3].Value = "Cantidad";

                        // Escribir datos
                        int fila = 2;
                        while (reader.Read())
                        {
                            hoja.Cells[fila, 1].Value = reader["Id"];
                            hoja.Cells[fila, 2].Value = reader["BloqueId"];
                            hoja.Cells[fila, 3].Value = reader["Cantidad"];
                            fila++;
                        }

                        // Guardar el archivo
                        FileInfo archivo = new FileInfo(rutaArchivo);
                        excel.SaveAs(archivo);
                    }

                    MessageBox.Show("Inventario exportado exitosamente a Excel.");
                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al exportar el inventario: {ex.Message}");
                    return false;
                }
            }   }  
                public string? AgregarJugador(string nombre, string nivel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Insert into Jugadores (Nombre, Nivel) values (@Nombre, @Nivel)";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Nivel", nivel);

                    command.ExecuteNonQuery();
                    Console.WriteLine("Jugador agregado correctamente");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
            return null;
        }

        public string? ActualizarJugador(string id, string nombre, string nivel)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Update Jugadores set Nombre = @Nombre, Nivel = @Nivel where id = @id";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Nivel", nivel);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Alumno actualizado" : "No se encontró el alumno");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
            return null;
        }

        public void EliminarJugador(string id)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "Delete from Jugadores where id = @id";
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    int filas = command.ExecuteNonQuery();
                    Console.WriteLine(filas > 0 ? "Alumno eliminado" : "No se encontró el alumno");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Revisa y averigua el error, Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public List<string> ObtenerBloquesPorRareza(string rareza)
        {
            List<string> bloques = new List<string>();

            using (SqlConnection connection = GetConnection())
            {
                string query = "SELECT Nombre FROM Bloques WHERE Rareza = @Rareza";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rareza", rareza);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        bloques.Add(reader["Nombre"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener los bloques: {ex.Message}");
                }
            }

            return bloques;
        }


    }
}



    


