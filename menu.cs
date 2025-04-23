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
    public partial class menu : Form
    {
        DatabaseManager Jugadores;
        string? bloquesRareza;
        JugadorService serviciosJugador;
        string? nombreJugador;
        string? idJugador;
        string? nivelJugador;
        public menu()
        {
            InitializeComponent();
            Jugadores = new DatabaseManager();
        }

        private void buttonexportar_Click(object sender, EventArgs e)
        {
            string nombreJugador = textBoxexportar.Text;

            if (string.IsNullOrWhiteSpace(nombreJugador))
            {
                MessageBox.Show("Por favor, ingrese el nombre del jugador.");
                return;
            }

            // Obtener el Id del jugador
            int? jugadorId = Jugadores.ObtenerIdJugadorPorNombre(nombreJugador);

            if (jugadorId == null)
            {
                MessageBox.Show("No se encontró un jugador con ese nombre.");
                return;
            }

            // Ruta donde se guardará el archivo Excel editarla a su gusto 
            string rutaArchivo = $"C:\\Users\\Erick\\Desktop\\tarea\\progra 1\\Inventario_" + nombreJugador + ".xlsx";

            // Llamar a la función de exportación
            if (Jugadores.ExportarInventarioAExcel(jugadorId.ToString(), rutaArchivo))
            {
                MessageBox.Show($"El inventario de {nombreJugador} se exportó correctamente a {rutaArchivo}.");
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            nombreJugador = txtnombre.Text;
            idJugador = txtid.Text;
            nivelJugador = txtnivel.Text;
            if (string.IsNullOrWhiteSpace(nombreJugador) || string.IsNullOrWhiteSpace(idJugador) || string.IsNullOrWhiteSpace(nivelJugador))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Jugadores.EliminarJugador(idJugador);
            MessageBox.Show($"El jugador {nombreJugador} ha sido eliminado.");
            txtnombre.Clear();
            txtid.Clear();
            txtnivel.Clear();

        }

        private void buttonañadir_Click(object sender, EventArgs e)
        {
            nombreJugador = txtnombre.Text;
            idJugador = txtid.Text;
            nivelJugador = txtnivel.Text;
            if (string.IsNullOrWhiteSpace(nombreJugador) || string.IsNullOrWhiteSpace(nivelJugador))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Jugadores.AgregarJugador(nombreJugador, nivelJugador);
            MessageBox.Show($"El jugador {nombreJugador} ha sido añadido.");
            txtnombre.Clear();
            txtid.Clear();
            txtnivel.Clear();

        }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            nombreJugador = txtnombre.Text;
            idJugador = txtid.Text;
            nivelJugador = txtnivel.Text;
            if (string.IsNullOrWhiteSpace(nombreJugador) || string.IsNullOrWhiteSpace(idJugador) || string.IsNullOrWhiteSpace(nivelJugador))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }
            Jugadores.ActualizarJugador(idJugador, nombreJugador, nivelJugador);
            MessageBox.Show($"El jugador {nombreJugador} ha sido actualizado.");
            txtnombre.Clear();
            txtid.Clear();
            txtnivel.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newform = new bloques();
            newform.Show();
            this.Hide();
        }

        private void buttoninevntario_Click(object sender, EventArgs e)
        {
            Form newform = new inventario();
            newform.Show();
            this.Hide();
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
