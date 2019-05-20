namespace EjemploConexionBBDD
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.botonBuscador = new System.Windows.Forms.Button();
            this.buscador = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.desplegableActores1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(187, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENID A POR PELIS HIJOS DE PUTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // botonBuscador
            // 
            this.botonBuscador.Location = new System.Drawing.Point(502, 129);
            this.botonBuscador.Name = "botonBuscador";
            this.botonBuscador.Size = new System.Drawing.Size(116, 21);
            this.botonBuscador.TabIndex = 2;
            this.botonBuscador.Text = "Buscar";
            this.botonBuscador.UseVisualStyleBackColor = true;
            this.botonBuscador.Click += new System.EventHandler(this.botonBuscador_Click);
            // 
            // buscador
            // 
            this.buscador.Location = new System.Drawing.Point(240, 129);
            this.buscador.Name = "buscador";
            this.buscador.Size = new System.Drawing.Size(246, 20);
            this.buscador.TabIndex = 3;
            this.buscador.Text = "Busca aqui";
            this.buscador.TextChanged += new System.EventHandler(this.buscador_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(465, 223);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // desplegableActores1
            // 
            this.desplegableActores1.BackColor = System.Drawing.Color.White;
            this.desplegableActores1.FormattingEnabled = true;
            this.desplegableActores1.Location = new System.Drawing.Point(210, 415);
            this.desplegableActores1.Name = "desplegableActores1";
            this.desplegableActores1.Size = new System.Drawing.Size(522, 21);
            this.desplegableActores1.TabIndex = 0;
            this.desplegableActores1.SelectedIndexChanged += new System.EventHandler(this.desplegableActores1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(643, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 49);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(939, 567);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buscador);
            this.Controls.Add(this.botonBuscador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegableActores1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VentanaPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonBuscador;
        private System.Windows.Forms.TextBox buscador;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox desplegableActores1;
        private System.Windows.Forms.Button button1;
    }
}