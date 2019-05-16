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
            rellenaComboAutores();
        }

        //codigo para que al cerrar este form, se cierre la app completa
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void rellenaComboAutores()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = 
              new MySqlCommand("Select * from actors order by first_name", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();
            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String first_name = resultado.GetString("first_name");
                String last_name = resultado.GetString("last_name");
                String gender = resultado.GetString("gender");
                String film_count = resultado.GetString("film_count");
                //para que no de fallo cuando un campo sea nulo
                //if (!resultado.IsDBNull(3)) { rank = resultado.GetString(3); }
                desplegableActores1.Items.Add(id + "--" + first_name + "--" + last_name);
            }
            conexion.Close();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void desplegableActores1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buscador_TextChanged(object sender, EventArgs e)
        {
            if (buscador.Text != "")    
            {
                dataGridView1.CurrentCell = null;
                
                foreach (DataGridViewRow r in dataGridView1.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dataGridView1.Rows)
                    foreach (DataGridViewCell c in r.Cells)
                {
                        if ((c.Value.ToString().ToUpper()).IndexOf(buscador.Text.ToUpper()) == 0){
                            r.Visible = true;
                            break;
                        }
                }
            }
            else
            {
               dataGridView1.DataSource= ConexionBBDD.consulta();

            }
        }

        private void botonBuscador_Click(object sender, EventArgs e)
        {
            //ConexionBBDD.probarConexion();
            dataGridView1.DataSource = ConexionBBDD.consulta();
        }
    }
}
