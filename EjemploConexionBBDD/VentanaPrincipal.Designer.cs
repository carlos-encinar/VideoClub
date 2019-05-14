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
            this.desplegableActores1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // desplegableActores1
            // 
            this.desplegableActores1.BackColor = System.Drawing.Color.White;
            this.desplegableActores1.FormattingEnabled = true;
            this.desplegableActores1.Location = new System.Drawing.Point(12, 81);
            this.desplegableActores1.Name = "desplegableActores1";
            this.desplegableActores1.Size = new System.Drawing.Size(224, 21);
            this.desplegableActores1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 57);
            this.label1.TabIndex = 2;
            this.label1.Text = "VENID A POR PELIS HIJOS DE PUTA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VentanaPrincipal
            // 
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.desplegableActores1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "VentanaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableAutores;
        private System.Windows.Forms.ComboBox desplegableActores1;
        private System.Windows.Forms.Label label1;
    }
}