namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class CirculoParametrico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CirculoParametrico));
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYC1 = new System.Windows.Forms.TextBox();
            this.txtXC1 = new System.Windows.Forms.TextBox();
            this.lblDDA0 = new System.Windows.Forms.Label();
            this.btnResetEcP = new System.Windows.Forms.Button();
            this.btnGraficarEcP = new System.Windows.Forms.Button();
            this.Botones = new System.Windows.Forms.GroupBox();
            this.pictureBoxEcP = new System.Windows.Forms.PictureBox();
            this.lblPM = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRC1 = new System.Windows.Forms.TextBox();
            this.lblDDAf = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Botones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcP)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(149, 56);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(36, 22);
            this.lbl.TabIndex = 7;
            this.lbl.Text = "Yo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Xo";
            // 
            // txtYC1
            // 
            this.txtYC1.Location = new System.Drawing.Point(189, 53);
            this.txtYC1.Name = "txtYC1";
            this.txtYC1.Size = new System.Drawing.Size(76, 30);
            this.txtYC1.TabIndex = 3;
            // 
            // txtXC1
            // 
            this.txtXC1.Location = new System.Drawing.Point(58, 53);
            this.txtXC1.Name = "txtXC1";
            this.txtXC1.Size = new System.Drawing.Size(76, 30);
            this.txtXC1.TabIndex = 2;
            // 
            // lblDDA0
            // 
            this.lblDDA0.AutoSize = true;
            this.lblDDA0.Location = new System.Drawing.Point(6, 27);
            this.lblDDA0.Name = "lblDDA0";
            this.lblDDA0.Size = new System.Drawing.Size(277, 22);
            this.lblDDA0.TabIndex = 0;
            this.lblDDA0.Text = "Ingresa las coordenadas iniciales:";
            // 
            // btnResetEcP
            // 
            this.btnResetEcP.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetEcP.Location = new System.Drawing.Point(168, 43);
            this.btnResetEcP.Name = "btnResetEcP";
            this.btnResetEcP.Size = new System.Drawing.Size(87, 33);
            this.btnResetEcP.TabIndex = 1;
            this.btnResetEcP.Text = "Resetear";
            this.btnResetEcP.UseVisualStyleBackColor = false;
            this.btnResetEcP.Click += new System.EventHandler(this.btnResetEcP_Click);
            // 
            // btnGraficarEcP
            // 
            this.btnGraficarEcP.BackColor = System.Drawing.SystemColors.Control;
            this.btnGraficarEcP.Location = new System.Drawing.Point(22, 43);
            this.btnGraficarEcP.Name = "btnGraficarEcP";
            this.btnGraficarEcP.Size = new System.Drawing.Size(97, 33);
            this.btnGraficarEcP.TabIndex = 0;
            this.btnGraficarEcP.Text = "Graficar";
            this.btnGraficarEcP.UseVisualStyleBackColor = false;
            this.btnGraficarEcP.Click += new System.EventHandler(this.btnGraficarEcP_Click);
            // 
            // Botones
            // 
            this.Botones.Controls.Add(this.btnResetEcP);
            this.Botones.Controls.Add(this.btnGraficarEcP);
            this.Botones.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.Botones.Location = new System.Drawing.Point(22, 236);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(287, 79);
            this.Botones.TabIndex = 9;
            this.Botones.TabStop = false;
            this.Botones.Text = "Botones:";
            // 
            // pictureBoxEcP
            // 
            this.pictureBoxEcP.Location = new System.Drawing.Point(6, 29);
            this.pictureBoxEcP.Name = "pictureBoxEcP";
            this.pictureBoxEcP.Size = new System.Drawing.Size(1005, 532);
            this.pictureBoxEcP.TabIndex = 0;
            this.pictureBoxEcP.TabStop = false;
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPM.Location = new System.Drawing.Point(22, 18);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(284, 28);
            this.lblPM.TabIndex = 11;
            this.lblPM.Text = "Algoritmo Ec. Paramétrica";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxEcP);
            this.groupBox3.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.groupBox3.Location = new System.Drawing.Point(327, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 579);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfica:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRC1);
            this.groupBox1.Controls.Add(this.txtYC1);
            this.groupBox1.Controls.Add(this.txtXC1);
            this.groupBox1.Controls.Add(this.lblDDAf);
            this.groupBox1.Controls.Add(this.lblDDA0);
            this.groupBox1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "r";
            // 
            // txtRC1
            // 
            this.txtRC1.Location = new System.Drawing.Point(58, 123);
            this.txtRC1.Name = "txtRC1";
            this.txtRC1.Size = new System.Drawing.Size(76, 30);
            this.txtRC1.TabIndex = 4;
            // 
            // lblDDAf
            // 
            this.lblDDAf.AutoSize = true;
            this.lblDDAf.Location = new System.Drawing.Point(6, 98);
            this.lblDDAf.Name = "lblDDAf";
            this.lblDDAf.Size = new System.Drawing.Size(140, 22);
            this.lblDDAf.TabIndex = 1;
            this.lblDDAf.Text = "Ingresa el radio:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(18, 468);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(287, 184);
            this.textBox2.TabIndex = 20;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Funcionamiento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Definición:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(18, 344);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(287, 75);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // CirculoParametrico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1362, 684);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CirculoParametrico";
            this.Text = "CirculoParametrico";
            this.Load += new System.EventHandler(this.CirculoParametrico_Load);
            this.Botones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYC1;
        private System.Windows.Forms.TextBox txtXC1;
        private System.Windows.Forms.Label lblDDA0;
        private System.Windows.Forms.Button btnResetEcP;
        private System.Windows.Forms.Button btnGraficarEcP;
        private System.Windows.Forms.GroupBox Botones;
        private System.Windows.Forms.PictureBox pictureBoxEcP;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRC1;
        private System.Windows.Forms.Label lblDDAf;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}