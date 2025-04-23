using Microsoft.Data.SqlClient;
using MinecraftManager.Models;
using MinecraftManager.Services;
using MinecraftManager.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_parcial
{
    public partial class inventario : Form
    {
        DatabaseManager Jugadores;
        string? bloquesRareza;
        JugadorService serviciosJugador;
        public inventario()
        {
            InitializeComponent();
            Jugadores = new DatabaseManager();
            serviciosJugador = new JugadorService(Jugadores);
        }


        private void inventario_Load(object sender, EventArgs e)
        {
            List<Jugador> listaJugadores = serviciosJugador.ObtenerTodos();
            comboBox1.DataSource = listaJugadores;
            comboBox1.DisplayMember = "Nombre"; // Mostrar el nombre del jugador
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue is int jugadorId)
            {
                // Obtener el inventario del jugador seleccionado
                List<InventarioItem> inventario = ObtenerInventarioPorJugador(jugadorId);

                // Mostrar el inventario en el DataGridView
                dataGridView1.DataSource = inventario;
            }
        }
        private List<InventarioItem> ObtenerInventarioPorJugador(int jugadorId)
        {
            List<InventarioItem> inventario = new List<InventarioItem>();

            using (SqlConnection connection = Jugadores.GetConnection())
            {
                string query = @"
                SELECT i.Id, i.BloqueId, i.Cantidad
                FROM Inventario i
                WHERE i.JugadorId = @JugadorId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@JugadorId", jugadorId);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        inventario.Add(new InventarioItem
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            BloqueId = reader["BloqueId"].ToString(),
                            Cantidad = Convert.ToInt32(reader["Cantidad"])
                        });
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al obtener el inventario: {ex.Message}");
                }
            }

            return inventario;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void buttonregresar_Click(object sender, EventArgs e)
        {
            Form newform = new menu();
            newform.Show();
            this.Close();
        }
    }
    public class InventarioItem
    {
        public int Id { get; set; } // Corresponde a la columna "Id" de la tabla Inventario
        public string BloqueId { get; set; } // Corresponde a la columna "BloqueId"
        public int Cantidad { get; set; } // Corresponde a la columna "Cantidad"
    }
}

