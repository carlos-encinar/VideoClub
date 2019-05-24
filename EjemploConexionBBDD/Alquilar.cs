using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploConexionBBDD
{
    public partial class Alquilar : Form
    {
        public Alquilar()
        {
            InitializeComponent();
            rellenaComboUsuarios();
            rellenaComboPeliculas();
        }

        //codigo para que al cerrar este form, se cierre la app completa
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void rellenaComboUsuarios()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando =
                new MySqlCommand("Select * from usuario order by Nombre", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String first_name = resultado.GetString("Nombre");
                String last_name = resultado.GetString("Apellido");
                comboUsuarios.Items.Add(id + "      " + first_name + "      " + last_name);
            }
            conexion.Close();
        }

        private void rellenaComboPeliculas()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando =
                new MySqlCommand("Select * from movies order by name", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String first_name = resultado.GetString("name");
                comboPelis.Items.Add(id + "      " + first_name + "      ");
            }
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal v = new VentanaPrincipal();
            v.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando =
                new MySqlCommand("INSERT INTO `prestamos` (`id_usuario`, `id_peliculas`) VALUES('"+comboUsuarios.Text +"', '"+comboPelis.Text +"');", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            rellenaGrid();
        }

        private void rellenaGrid()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando =
                new MySqlCommand("select * from prestamos", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (resultado.Read())
            {
                String id_usuario = resultado.GetString("id_usuario");
                String id_peliculas = resultado.GetString("id_peliculas");
                dataGridView1.Rows.Add(id_usuario, id_peliculas);
            }
            conexion.Close();
        }
    }
}
