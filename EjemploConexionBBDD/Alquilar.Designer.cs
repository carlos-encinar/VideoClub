namespace EjemploConexionBBDD
{
    partial class Alquilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alquilar));
            this.comboPelis = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.comboUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboPelis
            // 
            this.comboPelis.FormattingEnabled = true;
            this.comboPelis.Location = new System.Drawing.Point(477, 159);
            this.comboPelis.Name = "comboPelis";
            this.comboPelis.Size = new System.Drawing.Size(235, 21);
            this.comboPelis.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(567, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "Alquilar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(236, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Devolver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(173, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(587, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "VENID A POR PELIS HIJOS DE PUTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(397, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 24);
            this.button3.TabIndex = 5;
            this.button3.Text = "Inicio";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboUsuarios
            // 
            this.comboUsuarios.FormattingEnabled = true;
            this.comboUsuarios.Location = new System.Drawing.Point(236, 159);
            this.comboUsuarios.Name = "comboUsuarios";
            this.comboUsuarios.Size = new System.Drawing.Size(235, 21);
            this.comboUsuarios.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(352, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "¡Se ha alquilado la pelicula correctamente!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(352, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "¡Se ha devuelto la pelicula correctamente!";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Alquilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(926, 568);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboPelis);
            this.Controls.Add(this.comboUsuarios);
            this.Name = "Alquilar";
            this.Text = "Alquilar";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboPelis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}