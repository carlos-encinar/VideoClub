using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploConexionBBDD
{
    public partial class Login : Form
    {
        int intentos = 0;

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("" +
                "Select * FROM usuarios WHERE " +
                "usuario = '" +  textBox1.Text +
                "'And pass = '" + textBox2.Text +
                "';'", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            
            if (resultado.Read())
            {
                String Usuario = textBox1.Text;
                String Contraseña = textBox2.Text;
                if (Usuario.Contains(" ") && Usuario.Contains("'") 
                    || Contraseña.Contains(" ") && Contraseña.Contains("'"))
                {
                    MessageBox.Show("No introduzca comandos por favor", "Error de comando");
                    this.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Acceso Correcto", "Usuario OK");
                    this.Visible = false;//oculta la ventana de login
                    VentanaPrincipal v = new VentanaPrincipal();
                    v.Visible = true;// o tamb v.show = true;
                }
                
            }
            else
            {
                intentos++;
                if (intentos < 3)
                {
                    MessageBox.Show("Usuario Y/O contrseña incorrecto(s)", "ERROR");
                }
                if (intentos == 3)
                {
                    MessageBox.Show("Has agotado el número de intentos (3), por favor, espere 5 segundos y vuelva a intentarlo.");
                    intentos = 0;
                    button1.Enabled = false;
                    timer1.Start();
                }
            }
                            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            timer1.Stop();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
