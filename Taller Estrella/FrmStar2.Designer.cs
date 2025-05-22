namespace Taller_Estrella
{
    partial class FrmStar2
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
            this.grbCanvas = new System.Windows.Forms.GroupBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.grp_Options = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_val = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_escale = new System.Windows.Forms.Label();
            this.btnTurnRigth = new System.Windows.Forms.Button();
            this.btnTurnLeft = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grbCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.grp_Options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // grbCanvas
            // 
            this.grbCanvas.Controls.Add(this.picCanvas);
            this.grbCanvas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCanvas.Location = new System.Drawing.Point(364, 61);
            this.grbCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Padding = new System.Windows.Forms.Padding(4);
            this.grbCanvas.Size = new System.Drawing.Size(649, 503);
            this.grbCanvas.TabIndex = 26;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(0, 23);
            this.picCanvas.Margin = new System.Windows.Forms.Padding(4);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(641, 473);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // grp_Options
            // 
            this.grp_Options.Controls.Add(this.label3);
            this.grp_Options.Controls.Add(this.txt_val);
            this.grp_Options.Controls.Add(this.label2);
            this.grp_Options.Controls.Add(this.trackBar1);
            this.grp_Options.Controls.Add(this.lbl_escale);
            this.grp_Options.Controls.Add(this.btnTurnRigth);
            this.grp_Options.Controls.Add(this.btnTurnLeft);
            this.grp_Options.Controls.Add(this.label1);
            this.grp_Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.grp_Options.Location = new System.Drawing.Point(40, 72);
            this.grp_Options.Name = "grp_Options";
            this.grp_Options.Size = new System.Drawing.Size(302, 485);
            this.grp_Options.TabIndex = 26;
            this.grp_Options.TabStop = false;
            this.grp_Options.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 32;
            this.label3.Text = "escala";
            // 
            // txt_val
            // 
            this.txt_val.Enabled = false;
            this.txt_val.Location = new System.Drawing.Point(100, 232);
            this.txt_val.Name = "txt_val";
            this.txt_val.Size = new System.Drawing.Size(100, 23);
            this.txt_val.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Deslizar";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(6, 261);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(261, 56);
            this.trackBar1.TabIndex = 29;
            // 
            // lbl_escale
            // 
            this.lbl_escale.AutoSize = true;
            this.lbl_escale.Location = new System.Drawing.Point(97, 166);
            this.lbl_escale.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_escale.Name = "lbl_escale";
            this.lbl_escale.Size = new System.Drawing.Size(62, 17);
            this.lbl_escale.TabIndex = 28;
            this.lbl_escale.Text = "Escalar";
            // 
            // btnTurnRigth
            // 
            this.btnTurnRigth.Location = new System.Drawing.Point(146, 90);
            this.btnTurnRigth.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnRigth.Name = "btnTurnRigth";
            this.btnTurnRigth.Size = new System.Drawing.Size(100, 28);
            this.btnTurnRigth.TabIndex = 27;
            this.btnTurnRigth.Text = "→";
            this.btnTurnRigth.UseVisualStyleBackColor = true;
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Location = new System.Drawing.Point(23, 90);
            this.btnTurnLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(100, 28);
            this.btnTurnLeft.TabIndex = 26;
            this.btnTurnLeft.Text = "←";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Girar";
            // 
            // FrmStar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 625);
            this.Controls.Add(this.grp_Options);
            this.Controls.Add(this.grbCanvas);
            this.Name = "FrmStar2";
            this.Text = "Estrella ";
            this.Load += new System.EventHandler(this.FrmStar2_Load);
            this.grbCanvas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.grp_Options.ResumeLayout(false);
            this.grp_Options.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbCanvas;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.GroupBox grp_Options;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_escale;
        private System.Windows.Forms.Button btnTurnRigth;
        private System.Windows.Forms.Button btnTurnLeft;
        private System.Windows.Forms.Label label1;
    }
}