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
            this.SuspendLayout();
            // 
            // desplegableActores1
            // 
            this.desplegableActores1.FormattingEnabled = true;
            this.desplegableActores1.Location = new System.Drawing.Point(45, 62);
            this.desplegableActores1.Name = "desplegableActores1";
            this.desplegableActores1.Size = new System.Drawing.Size(268, 21);
            this.desplegableActores1.TabIndex = 0;
            // 
            // VentanaPrincipal
            // 
            this.ClientSize = new System.Drawing.Size(645, 402);
            this.Controls.Add(this.desplegableActores1);
            this.Name = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox desplegableAutores;
        private System.Windows.Forms.ComboBox desplegableActores1;
    }
}