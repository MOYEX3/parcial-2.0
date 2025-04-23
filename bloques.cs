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
    public partial class bloques : Form
    {
        DatabaseManager Jugadores;
        string? bloquesRareza;
        JugadorService serviciosJugador;
        public bloques()
        {
            InitializeComponent();
            Jugadores = new DatabaseManager();
            serviciosJugador = new JugadorService(Jugadores);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string rarezaSeleccionada = comboBox1.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(rarezaSeleccionada))
            {
                MessageBox.Show("Por favor, seleccione una rareza.");
                return;
            }

            // Obtener los bloques según la rareza seleccionada
            List<string> bloques = Jugadores.ObtenerBloquesPorRareza(rarezaSeleccionada);

            // Limpiar el ListBox y agregar los bloques
            listBox1.Items.Clear();
            foreach (string bloque in bloques)
            {
                listBox1.Items.Add(bloque);
            }
        }

        private void bloques_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Común");
            comboBox1.Items.Add("Raro");
            comboBox1.Items.Add("Épico");
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonreturn_Click(object sender, EventArgs e)
        {
            Form newform = new menu();
            newform.Show();
            this.Hide();
        }
    }
}
