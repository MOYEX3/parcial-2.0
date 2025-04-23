using MinecraftManager.Services;
using MinecraftManager.Utils;

namespace proyecto_parcial
{
    public partial class Form1 : Form
    {
        
        DatabaseManager Jugadores;
        string? bloquesRareza;
        JugadorService serviciosJugador;
        public Form1()
        {
            InitializeComponent();
            Jugadores = new DatabaseManager();
            serviciosJugador = new JugadorService(Jugadores);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            textBox1.Focus();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            string usuario = textBox1.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Por favor, ingrese un nombre de usuario.");
                return;
            }

            // Validar si el usuario existe en la base de datos
            if (Jugadores.ValidarUsuarioEnBaseDeDatos(usuario))
            {
                Form newform = new menu();
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado.");
            }
        }
    }
    
}
