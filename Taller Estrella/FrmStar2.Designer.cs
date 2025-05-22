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
            this.grbCanvas.Location = new System.Drawing.Point(273, 50);
            this.grbCanvas.Name = "grbCanvas";
            this.grbCanvas.Size = new System.Drawing.Size(487, 409);
            this.grbCanvas.TabIndex = 26;
            this.grbCanvas.TabStop = false;
            this.grbCanvas.Text = "Gráfico";
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(0, 19);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(481, 384);
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
            this.grp_Options.Location = new System.Drawing.Point(30, 58);
            this.grp_Options.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_Options.Name = "grp_Options";
            this.grp_Options.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grp_Options.Size = new System.Drawing.Size(226, 394);
            this.grp_Options.TabIndex = 26;
            this.grp_Options.TabStop = false;
            this.grp_Options.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "escala";
            // 
            // txt_val
            // 
            this.txt_val.Enabled = false;
            this.txt_val.Location = new System.Drawing.Point(75, 188);
            this.txt_val.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_val.Name = "txt_val";
            this.txt_val.Size = new System.Drawing.Size(76, 20);
            this.txt_val.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Deslizar";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 212);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(196, 45);
            this.trackBar1.TabIndex = 29;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_escale
            // 
            this.lbl_escale.AutoSize = true;
            this.lbl_escale.Location = new System.Drawing.Point(73, 135);
            this.lbl_escale.Name = "lbl_escale";
            this.lbl_escale.Size = new System.Drawing.Size(49, 13);
            this.lbl_escale.TabIndex = 28;
            this.lbl_escale.Text = "Escalar";
            // 
            // btnTurnRigth
            // 
            this.btnTurnRigth.Location = new System.Drawing.Point(110, 73);
            this.btnTurnRigth.Name = "btnTurnRigth";
            this.btnTurnRigth.Size = new System.Drawing.Size(75, 23);
            this.btnTurnRigth.TabIndex = 27;
            this.btnTurnRigth.Text = "→";
            this.btnTurnRigth.UseVisualStyleBackColor = true;
            this.btnTurnRigth.Click += new System.EventHandler(this.btnTurnRigth_Click);
            // 
            // btnTurnLeft
            // 
            this.btnTurnLeft.Location = new System.Drawing.Point(17, 73);
            this.btnTurnLeft.Name = "btnTurnLeft";
            this.btnTurnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnTurnLeft.TabIndex = 26;
            this.btnTurnLeft.Text = "←";
            this.btnTurnLeft.UseVisualStyleBackColor = true;
            this.btnTurnLeft.Click += new System.EventHandler(this.btnTurnLeft_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Girar";
            // 
            // FrmStar2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 508);
            this.Controls.Add(this.grp_Options);
            this.Controls.Add(this.grbCanvas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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