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
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();

        }

        //codigo para que al cerrar este form, se cierre la app completa
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void rellenaBuscador()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            String auxiliar = buscador.Text;
            MySqlCommand comando = new MySqlCommand("SELECT * FROM movies WHERE name like '" + auxiliar + "%'"
                , conexion);
            MySqlDataReader resultado = comando.ExecuteReader();

            dataGridView1.Rows.Clear();

            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String first_name = resultado.GetString(1);
                String year = resultado.GetString(2);

                String rank = "";
                if (!resultado.IsDBNull(3))
                    rank = resultado.GetString(3);


                if (!resultado.IsDBNull(3)) { rank = resultado.GetString(3); }
                //String film_count = resultado.GetString(4);
                //comboBox1.Items.Add(id + "      |      " + first_name + "      |      " + year + "     |      " + rank);

                dataGridView1.Rows.Add(id, first_name, year, rank);

            }

            conexion.Close();
        }


        private void rellenaBuscadorActores()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            String auxiliar = buscador.Text;
            dataGridView2.Rows.Clear();
            MySqlCommand comando = new MySqlCommand("SELECT actors.id, actors.first_name, actors.last_name, actors.gender, actors.film_count" +
                                                 " FROM actors where first_name like '" + auxiliar + "%' "
                , conexion);
            MySqlDataReader resultado = comando.ExecuteReader();



            while (resultado.Read())
            {
                String id = resultado.GetString("id");
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");
                String gender = resultado.GetString("gender");
                String film_count = resultado.GetString("film_count");


                dataGridView2.Rows.Add(id, first_name, last_name, gender, film_count);
            }

            conexion.Close();
        }


        private void rellenaBuscadorDirectores()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            String auxiliar = buscador.Text;
            dataGridView3.Rows.Clear();
            MySqlCommand comando = new MySqlCommand("SELECT directors.id, directors.first_name, directors.last_name" +
                                                    " FROM directors where first_name like '" + auxiliar + "%' "
                , conexion);
            MySqlDataReader resultado = comando.ExecuteReader();

            while (resultado.Read())
            {
                String id = resultado.GetString("id");
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");

                dataGridView3.Rows.Add(id, first_name, last_name);
            }
            conexion.Close();
        }



        private void rellenaBuscadorGeneros()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            String auxiliar = buscador.Text;
            dataGridView4.Rows.Clear();
            MySqlCommand comando = new MySqlCommand("SELECT movies_genres.movie_id, movies_genres.genre" +
                                                 " FROM movies_genres where genre like '" + auxiliar + "%' "
                , conexion);
            MySqlDataReader resultado = comando.ExecuteReader();



            while (resultado.Read())
            {
                String movie_id = resultado.GetString("movie_id");
                String genre = resultado.GetString("genre");

                dataGridView4.Rows.Add(movie_id, genre);
            }

            conexion.Close();
        }

        private void botonBuscador_Click(object sender, EventArgs e)
        {
            if (desplegable.SelectedIndex == 0)
            {
                rellenaBuscador();
            }

            if (desplegable.SelectedIndex == 1)
            {
                rellenaBuscadorActores();
            }
            if (desplegable.SelectedIndex == 2)
            {
                rellenaBuscadorDirectores();
            }


            if (desplegable.SelectedIndex == 3)
            {
                rellenaBuscadorGeneros();
            }
        }

        private void desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Movies seleccionado
            if (desplegable.SelectedIndex == 0)
            {
                dataGridView2.Visible = false;
                dataGridView3.Visible = false;
                dataGridView1.Visible = true;
                dataGridView4.Visible = false;
            }

            // Actores seleccionado
            if (desplegable.SelectedIndex == 1)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
                dataGridView4.Visible = false;
            }

            // Directores seleccionado
            if (desplegable.SelectedIndex == 2)
            {
                dataGridView1.Visible = false;
                dataGridView2.Visible = false;
                dataGridView3.Visible = true;
                dataGridView4.Visible = false;
            }

            // generos seleccionado
            if (desplegable.SelectedIndex == 3)
            {
                dataGridView1.Visible = false;
                dataGridView3.Visible = false;
                dataGridView2.Visible = false;
                dataGridView4.Visible = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Clientes c = new Clientes();
            c.Visible = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Alquilar a = new Alquilar();
            a.Visible = true;
        }
    }
}
