namespace Prueba2_NET_BernarditaAntilaf_2018 {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.txtContadorAutos = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrarAutomovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAutomovilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autos Registrados:";
            // 
            // txtContadorAutos
            // 
            this.txtContadorAutos.Location = new System.Drawing.Point(270, 146);
            this.txtContadorAutos.Name = "txtContadorAutos";
            this.txtContadorAutos.ReadOnly = true;
            this.txtContadorAutos.Size = new System.Drawing.Size(100, 20);
            this.txtContadorAutos.TabIndex = 1;
            this.txtContadorAutos.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAutomovilToolStripMenuItem,
            this.buscarAutomovilToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(602, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarAutomovilToolStripMenuItem
            // 
            this.registrarAutomovilToolStripMenuItem.Name = "registrarAutomovilToolStripMenuItem";
            this.registrarAutomovilToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.registrarAutomovilToolStripMenuItem.Text = "Registrar Automovil";
            this.registrarAutomovilToolStripMenuItem.Click += new System.EventHandler(this.registrarAutomovilToolStripMenuItem_Click);
            // 
            // buscarAutomovilToolStripMenuItem
            // 
            this.buscarAutomovilToolStripMenuItem.Name = "buscarAutomovilToolStripMenuItem";
            this.buscarAutomovilToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.buscarAutomovilToolStripMenuItem.Text = "Buscar Automovil";
            this.buscarAutomovilToolStripMenuItem.Click += new System.EventHandler(this.buscarAutomovilToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 265);
            this.Controls.Add(this.txtContadorAutos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContadorAutos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarAutomovilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAutomovilToolStripMenuItem;
    }
}

