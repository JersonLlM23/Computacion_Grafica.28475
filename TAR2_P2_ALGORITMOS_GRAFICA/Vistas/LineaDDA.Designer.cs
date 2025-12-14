namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class LineaDDA
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LineaDDA));
            this.lblDDA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxYf = new System.Windows.Forms.TextBox();
            this.txtBoxXf = new System.Windows.Forms.TextBox();
            this.txtBoxYo = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnResetDDA = new System.Windows.Forms.Button();
            this.btnGraficarDDA = new System.Windows.Forms.Button();
            this.txtBoxXo = new System.Windows.Forms.TextBox();
            this.lblDDAf = new System.Windows.Forms.Label();
            this.lblDDA0 = new System.Windows.Forms.Label();
            this.Botones = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.timerDDA = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Botones.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDDA
            // 
            this.lblDDA.AutoSize = true;
            this.lblDDA.Font = new System.Drawing.Font("Bodoni MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDDA.Location = new System.Drawing.Point(12, 9);
            this.lblDDA.Name = "lblDDA";
            this.lblDDA.Size = new System.Drawing.Size(502, 28);
            this.lblDDA.TabIndex = 7;
            this.lblDDA.Text = "Algoritmo Analizador Diferencial Digital (DDA)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Yf";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Xf";
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
            // txtBoxYf
            // 
            this.txtBoxYf.Location = new System.Drawing.Point(189, 123);
            this.txtBoxYf.Name = "txtBoxYf";
            this.txtBoxYf.Size = new System.Drawing.Size(76, 30);
            this.txtBoxYf.TabIndex = 5;
            // 
            // txtBoxXf
            // 
            this.txtBoxXf.Location = new System.Drawing.Point(58, 123);
            this.txtBoxXf.Name = "txtBoxXf";
            this.txtBoxXf.Size = new System.Drawing.Size(76, 30);
            this.txtBoxXf.TabIndex = 4;
            // 
            // txtBoxYo
            // 
            this.txtBoxYo.Location = new System.Drawing.Point(189, 53);
            this.txtBoxYo.Name = "txtBoxYo";
            this.txtBoxYo.Size = new System.Drawing.Size(76, 30);
            this.txtBoxYo.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.groupBox3.Location = new System.Drawing.Point(317, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1017, 579);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Gráfica:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1005, 532);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnResetDDA
            // 
            this.btnResetDDA.Location = new System.Drawing.Point(166, 53);
            this.btnResetDDA.Name = "btnResetDDA";
            this.btnResetDDA.Size = new System.Drawing.Size(87, 33);
            this.btnResetDDA.TabIndex = 1;
            this.btnResetDDA.Text = "Resetear";
            this.btnResetDDA.UseVisualStyleBackColor = true;
            this.btnResetDDA.Click += new System.EventHandler(this.btnResetDDA_Click_1);
            // 
            // btnGraficarDDA
            // 
            this.btnGraficarDDA.Location = new System.Drawing.Point(22, 53);
            this.btnGraficarDDA.Name = "btnGraficarDDA";
            this.btnGraficarDDA.Size = new System.Drawing.Size(97, 33);
            this.btnGraficarDDA.TabIndex = 0;
            this.btnGraficarDDA.Text = "Graficar";
            this.btnGraficarDDA.UseVisualStyleBackColor = true;
            this.btnGraficarDDA.Click += new System.EventHandler(this.btnGraficarDDA_Click);
            // 
            // txtBoxXo
            // 
            this.txtBoxXo.Location = new System.Drawing.Point(58, 53);
            this.txtBoxXo.Name = "txtBoxXo";
            this.txtBoxXo.Size = new System.Drawing.Size(76, 30);
            this.txtBoxXo.TabIndex = 2;
            // 
            // lblDDAf
            // 
            this.lblDDAf.AutoSize = true;
            this.lblDDAf.Location = new System.Drawing.Point(6, 98);
            this.lblDDAf.Name = "lblDDAf";
            this.lblDDAf.Size = new System.Drawing.Size(259, 22);
            this.lblDDAf.TabIndex = 1;
            this.lblDDAf.Text = "Ingresa las coordenadas finales";
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
            // Botones
            // 
            this.Botones.Controls.Add(this.btnResetDDA);
            this.Botones.Controls.Add(this.btnGraficarDDA);
            this.Botones.Font = new System.Drawing.Font("High Tower Text", 14.25F);
            this.Botones.Location = new System.Drawing.Point(12, 227);
            this.Botones.Name = "Botones";
            this.Botones.Size = new System.Drawing.Size(287, 112);
            this.Botones.TabIndex = 5;
            this.Botones.TabStop = false;
            this.Botones.Text = "Botones:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxYf);
            this.groupBox1.Controls.Add(this.txtBoxXf);
            this.groupBox1.Controls.Add(this.txtBoxYo);
            this.groupBox1.Controls.Add(this.txtBoxXo);
            this.groupBox1.Controls.Add(this.lblDDAf);
            this.groupBox1.Controls.Add(this.lblDDA0);
            this.groupBox1.Font = new System.Drawing.Font("High Tower Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 170);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entradas:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(17, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(287, 75);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Definición:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 466);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Funcionamiento:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(17, 488);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(287, 184);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // LineaDDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 684);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblDDA);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Botones);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LineaDDA";
            this.Text = "LineaDDA";
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Botones.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDDA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxYf;
        private System.Windows.Forms.TextBox txtBoxXf;
        private System.Windows.Forms.TextBox txtBoxYo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnResetDDA;
        private System.Windows.Forms.Button btnGraficarDDA;
        private System.Windows.Forms.TextBox txtBoxXo;
        private System.Windows.Forms.Label lblDDAf;
        private System.Windows.Forms.Label lblDDA0;
        private System.Windows.Forms.GroupBox Botones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerDDA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
    }
}