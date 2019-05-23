using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void botonBuscador2_Click(object sender, EventArgs e)
        {
            if (buscador.Text != "")
            {
                dataGridView2.CurrentCell = null;

                foreach (DataGridViewRow r in dataGridView2.Rows)
                {
                    r.Visible = false;
                }

                foreach (DataGridViewRow r in dataGridView2.Rows)
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if ((c.Value.ToString().ToUpper()).IndexOf(buscador.Text.ToUpper()) == 0)
                        {
                            r.Visible = true;
                            break;
                        }
                    }
            }
            else
            {
                dataGridView2.DataSource = ConexionBBDD.consulta2();
            }
        }

        private void botonBuscador_Click(object sender, EventArgs e)
        {
            //ConexionBBDD.probarConexion();
            dataGridView2.DataSource = ConexionBBDD.consulta2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            VentanaPrincipal v = new VentanaPrincipal();
            v.Visible = true;
        }
    }
}
