namespace Taller_Estrella
{
    partial class FrmHome
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.estrellasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estrellaPrincipal = new System.Windows.Forms.ToolStripMenuItem();
            this.estrellaLineasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estrellasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // estrellasToolStripMenuItem
            // 
            this.estrellasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estrellaPrincipal,
            this.estrellaLineasToolStripMenuItem});
            this.estrellasToolStripMenuItem.Name = "estrellasToolStripMenuItem";
            this.estrellasToolStripMenuItem.Size = new System.Drawing.Size(77, 26);
            this.estrellasToolStripMenuItem.Text = "Estrellas";
            // 
            // estrellaPrincipal
            // 
            this.estrellaPrincipal.Name = "estrellaPrincipal";
            this.estrellaPrincipal.Size = new System.Drawing.Size(224, 26);
            this.estrellaPrincipal.Text = "Estrella principal";
            this.estrellaPrincipal.Click += new System.EventHandler(this.estrellaPrincipal_Click);
            // 
            // estrellaLineasToolStripMenuItem
            // 
            this.estrellaLineasToolStripMenuItem.Name = "estrellaLineasToolStripMenuItem";
            this.estrellaLineasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estrellaLineasToolStripMenuItem.Text = "Estrella lineas";
            this.estrellaLineasToolStripMenuItem.Click += new System.EventHandler(this.estrellaLineasToolStripMenuItem_Click);
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 694);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHome";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem estrellasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estrellaPrincipal;
        private System.Windows.Forms.ToolStripMenuItem estrellaLineasToolStripMenuItem;
    }
}

