namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class CirculoBresenham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CirculoBresenham));
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYC3 = new System.Windows.Forms.TextBox();
            this.lblDDA0 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRC3 = new System.Windows.Forms.TextBox();
            this.txtXC3 = new System.Windows.Forms.TextBox();
            this.lblDDAf = new System.Windows.Forms.Label();
            this.pictureBoxBC = new System.Windows.Forms.PictureBox();
            this.lblPM = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnResetBC = new System.Windows.Forms.Button();
            this.btnGraficarBC = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Botones = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBC)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.Botones.SuspendLayout();
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
            // txtYC3
            // 
            this.txtYC3.Location = new System.Drawing.Point(189, 53);
            this.txtYC3.Name = "txtYC3";
            this.txtYC3.Size = new System.Drawing.Size(76, 30);
            this.txtYC3.TabIndex = 3;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtRC3);
            this.groupBox1.Controls.Add(this.txtYC3);
            this.groupBox1.Controls.Add(this.txtXC3);
            this.groupBox1.Controls.Add(this.lblDDAf);
            this.groupBox1.Controls.Add(this.lblDDA0);
            this.groupBox1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 170);
            this.groupBox1.TabIndex = 29;
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
            // txtRC3
            // 
            this.txtRC3.Location = new System.Drawing.Point(58, 123);
            this.txtRC3.Name = "txtRC3";
            this.txtRC3.Size = new System.Drawing.Size(76, 30);
            this.txtRC3.TabIndex = 4;
            // 
            // txtXC3
            // 
            this.txtXC3.Location = new System.Drawing.Point(58, 53);
            this.txtXC3.Name = "txtXC3";
            this.txtXC3.Size = new System.Drawing.Size(76, 30);
            this.txtXC3.TabIndex = 2;
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
            // pictureBoxBC
            // 
            this.pictureBoxBC.Location = new System.Drawing.Point(6, 29);
            this.pictureBoxBC.Name = "pictureBoxBC";
            this.pictureBoxBC.Size = new System.Drawing.Size(1005, 532);
            this.pictureBoxBC.TabIndex = 0;
            this.pictureBoxBC.TabStop = false;
            // 
            // lblPM
            // 
            this.lblPM.AutoSize = true;
            this.lblPM.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPM.Location = new System.Drawing.Point(16, 17);
            this.lblPM.Name = "lblPM";
            this.lblPM.Size = new System.Drawing.Size(262, 28);
            this.lblPM.TabIndex = 32;
            this.lblPM.Text = "Algoritmo de Bresenham";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBoxBC);
            this.groupBox3.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.groupBox3.Location = new System.Drawing.Point(321, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 579);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfica:";
            // 
            // btnResetBC
            // 
            this.btnResetBC.BackColor = System.Drawing.SystemColors.Control;
            this.btnResetBC.Location = new System.Drawing.Point(168, 43);
            this.btnResetBC.Name = "btnResetBC";
            this.btnResetBC.Size = new System.Drawing.Size(87, 33);
            this.btnResetBC.TabIndex = 1;
            this.btnResetBC.Text = "Resetear";
            this.btnResetBC.UseVisualStyleBackColor = false;
            this.btnResetBC.Click += new System.EventHandler(this.btnResetBC_Click);
            // 
            // btnGraficarBC
            // 
            this.btnGraficarBC.BackColor = System.Drawing.SystemColors.Control;
            this.btnGraficarBC.Location = new System.Drawing.Point(22, 43);
            this.btnGraficarBC.Name = "btnGraficarBC";
            this.btnGraficarBC.Size = new System.Drawing.Size(97, 33);
            this.btnGraficarBC.TabIndex = 0;
            this.btnGraficarBC.Text = "Graficar";
            this.btnGraficarBC.UseVisualStyleBackColor = false;
            this.btnGraficarBC.Click += new System.EventHandler(this.btnGraficarBC_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Definición:";
            // 
            // Botones
            // 
            this.Botones.Controls.Add(this.btnResetBC);
            this.Botones.Controls.Add(this.btnGraficarBC);
            this.Botones.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.Botones.Location = new System.Drawing.Point(16, 235);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(287, 79);
            this.Botones.TabIndex = 30;
            this.Botones.TabStop = false;
            this.Botones.Text = "Botones:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Funcionamiento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 343);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(287, 75);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 467);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(287, 160);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // CirculoBresenham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1346, 645);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblPM);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CirculoBresenham";
            this.Text = "CirculoBresenham";
            this.Load += new System.EventHandler(this.CirculoBresenham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBC)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.Botones.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYC3;
        private System.Windows.Forms.Label lblDDA0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRC3;
        private System.Windows.Forms.TextBox txtXC3;
        private System.Windows.Forms.Label lblDDAf;
        private System.Windows.Forms.PictureBox pictureBoxBC;
        private System.Windows.Forms.Label lblPM;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnResetBC;
        private System.Windows.Forms.Button btnGraficarBC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Botones;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}