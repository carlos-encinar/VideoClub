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
    public partial class Clientes : Form
    {
        public Clientes()
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
            MySqlCommand comando = new MySqlCommand("SELECT DNI,Nombre FROM usuario WHERE DNI like '" + auxiliar + "%'"
                , conexion);
            MySqlDataReader resultado = comando.ExecuteReader();

            dataGridView2.Rows.Clear();

            while (resultado.Read())
            {
                String DNI = resultado.GetString(0);
                String Nombre = resultado.GetString(1);
                

                String id = "";
                if (!resultado.IsDBNull(1))
                    id = resultado.GetString(1);


                if (!resultado.IsDBNull(1)) { id = resultado.GetString(1); }
                //String film_count = resultado.GetString(4);
                //comboBox1.Items.Add(id + "      |      " + first_name + "      |      " + year + "     |      " + rank);

                dataGridView2.Rows.Add(DNI, Nombre);

            }

            conexion.Close();
        }

        private void botonBuscador2_Click(object sender, EventArgs e)
        {
            rellenaBuscador();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal v = new VentanaPrincipal();
            v.Visible = true;
        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {
            rellenaBuscador();
        }
    }
}
