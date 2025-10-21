namespace TAR1_VENTANASNAV_AREAS
{
    partial class circulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_radioCirculo = new System.Windows.Forms.TextBox();
            this.btn_Circulo = new System.Windows.Forms.Button();
            this.pictureBox_circulo = new System.Windows.Forms.PictureBox();
            this.lbl_perimetro_circulo = new System.Windows.Forms.Label();
            this.lbl_area_circulo = new System.Windows.Forms.Label();
            this.lbl_def_circulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_circulo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIGURA: CÍRCULO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área y Perímetro del círculo.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F);
            this.label3.Location = new System.Drawing.Point(17, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa el radio:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_radioCirculo
            // 
            this.txt_radioCirculo.Location = new System.Drawing.Point(184, 115);
            this.txt_radioCirculo.Name = "txt_radioCirculo";
            this.txt_radioCirculo.Size = new System.Drawing.Size(100, 20);
            this.txt_radioCirculo.TabIndex = 4;
            // 
            // btn_Circulo
            // 
            this.btn_Circulo.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Circulo.Location = new System.Drawing.Point(20, 156);
            this.btn_Circulo.Name = "btn_Circulo";
            this.btn_Circulo.Size = new System.Drawing.Size(92, 24);
            this.btn_Circulo.TabIndex = 5;
            this.btn_Circulo.Text = "Calcular";
            this.btn_Circulo.UseVisualStyleBackColor = false;
            this.btn_Circulo.Click += new System.EventHandler(this.btn_Circulo_Click);
            // 
            // pictureBox_circulo
            // 
            this.pictureBox_circulo.Location = new System.Drawing.Point(449, 45);
            this.pictureBox_circulo.Name = "pictureBox_circulo";
            this.pictureBox_circulo.Size = new System.Drawing.Size(258, 171);
            this.pictureBox_circulo.TabIndex = 6;
            this.pictureBox_circulo.TabStop = false;
            // 
            // lbl_perimetro_circulo
            // 
            this.lbl_perimetro_circulo.AutoSize = true;
            this.lbl_perimetro_circulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perimetro_circulo.Location = new System.Drawing.Point(311, 288);
            this.lbl_perimetro_circulo.Name = "lbl_perimetro_circulo";
            this.lbl_perimetro_circulo.Size = new System.Drawing.Size(438, 30);
            this.lbl_perimetro_circulo.TabIndex = 26;
            this.lbl_perimetro_circulo.Text = "Perímetro (circunferencia): 2 × π × radio";
            // 
            // lbl_area_circulo
            // 
            this.lbl_area_circulo.AutoSize = true;
            this.lbl_area_circulo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_circulo.Location = new System.Drawing.Point(16, 288);
            this.lbl_area_circulo.Name = "lbl_area_circulo";
            this.lbl_area_circulo.Size = new System.Drawing.Size(273, 30);
            this.lbl_area_circulo.TabIndex = 25;
            this.lbl_area_circulo.Text = "Área: π × (radio × radio)";
            // 
            // lbl_def_circulo
            // 
            this.lbl_def_circulo.AutoSize = true;
            this.lbl_def_circulo.Font = new System.Drawing.Font("Century", 12F);
            this.lbl_def_circulo.Location = new System.Drawing.Point(12, 251);
            this.lbl_def_circulo.Name = "lbl_def_circulo";
            this.lbl_def_circulo.Size = new System.Drawing.Size(653, 20);
            this.lbl_def_circulo.TabIndex = 24;
            this.lbl_def_circulo.Text = "Es una figura plana y redonda cuyos puntos están todos a la misma distancia del c" +
    "entro.";
            // 
            // circulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.lbl_perimetro_circulo);
            this.Controls.Add(this.lbl_area_circulo);
            this.Controls.Add(this.lbl_def_circulo);
            this.Controls.Add(this.pictureBox_circulo);
            this.Controls.Add(this.btn_Circulo);
            this.Controls.Add(this.txt_radioCirculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "circulo";
            this.Text = "circulo";
            this.Load += new System.EventHandler(this.circulo_Load);
            this.Shown += new System.EventHandler(this.circulo_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_circulo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_radioCirculo;
        private System.Windows.Forms.Button btn_Circulo;
        private System.Windows.Forms.PictureBox pictureBox_circulo;
        private System.Windows.Forms.Label lbl_perimetro_circulo;
        private System.Windows.Forms.Label lbl_area_circulo;
        private System.Windows.Forms.Label lbl_def_circulo;
    }
}