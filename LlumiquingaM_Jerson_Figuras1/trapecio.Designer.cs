namespace TAR1_VENTANASNAV_AREAS
{
    partial class trapecio
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
            this.btn_Trapecio = new System.Windows.Forms.Button();
            this.txt_baseMayor_Trapecio = new System.Windows.Forms.TextBox();
            this.txt_baseMenor_Trapecio = new System.Windows.Forms.TextBox();
            this.txt_lado_Trapecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_altura_Trapecio = new System.Windows.Forms.TextBox();
            this.pictureBox_trapecio = new System.Windows.Forms.PictureBox();
            this.lbl_perimetro_trapecio = new System.Windows.Forms.Label();
            this.lbl_area_trapecio = new System.Windows.Forms.Label();
            this.lbl_def_trapecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trapecio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIGURA: TRAPECIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área y Perímetro del trapecio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F);
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa la base menor del trapecio:";
            // 
            // btn_Trapecio
            // 
            this.btn_Trapecio.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Trapecio.Location = new System.Drawing.Point(20, 239);
            this.btn_Trapecio.Name = "btn_Trapecio";
            this.btn_Trapecio.Size = new System.Drawing.Size(86, 26);
            this.btn_Trapecio.TabIndex = 5;
            this.btn_Trapecio.Text = "Calcular";
            this.btn_Trapecio.UseVisualStyleBackColor = false;
            this.btn_Trapecio.Click += new System.EventHandler(this.btn_Trapecio_Click);
            // 
            // txt_baseMayor_Trapecio
            // 
            this.txt_baseMayor_Trapecio.Location = new System.Drawing.Point(287, 141);
            this.txt_baseMayor_Trapecio.Name = "txt_baseMayor_Trapecio";
            this.txt_baseMayor_Trapecio.Size = new System.Drawing.Size(100, 20);
            this.txt_baseMayor_Trapecio.TabIndex = 6;
            // 
            // txt_baseMenor_Trapecio
            // 
            this.txt_baseMenor_Trapecio.Location = new System.Drawing.Point(287, 112);
            this.txt_baseMenor_Trapecio.Name = "txt_baseMenor_Trapecio";
            this.txt_baseMenor_Trapecio.Size = new System.Drawing.Size(100, 20);
            this.txt_baseMenor_Trapecio.TabIndex = 7;
            // 
            // txt_lado_Trapecio
            // 
            this.txt_lado_Trapecio.Location = new System.Drawing.Point(287, 193);
            this.txt_lado_Trapecio.Name = "txt_lado_Trapecio";
            this.txt_lado_Trapecio.Size = new System.Drawing.Size(100, 20);
            this.txt_lado_Trapecio.TabIndex = 8;
            this.txt_lado_Trapecio.TextChanged += new System.EventHandler(this.txt_lado_Trapecio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F);
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ingresa la base mayor del trapecio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century", 12F);
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(218, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ingresa un lado del trapecio:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century", 12F);
            this.label6.Location = new System.Drawing.Point(16, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Ingresa la altura del trapecio:";
            // 
            // txt_altura_Trapecio
            // 
            this.txt_altura_Trapecio.Location = new System.Drawing.Point(287, 167);
            this.txt_altura_Trapecio.Name = "txt_altura_Trapecio";
            this.txt_altura_Trapecio.Size = new System.Drawing.Size(100, 20);
            this.txt_altura_Trapecio.TabIndex = 11;
            // 
            // pictureBox_trapecio
            // 
            this.pictureBox_trapecio.Location = new System.Drawing.Point(446, 69);
            this.pictureBox_trapecio.Name = "pictureBox_trapecio";
            this.pictureBox_trapecio.Size = new System.Drawing.Size(317, 186);
            this.pictureBox_trapecio.TabIndex = 13;
            this.pictureBox_trapecio.TabStop = false;
            // 
            // lbl_perimetro_trapecio
            // 
            this.lbl_perimetro_trapecio.AutoSize = true;
            this.lbl_perimetro_trapecio.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perimetro_trapecio.Location = new System.Drawing.Point(15, 369);
            this.lbl_perimetro_trapecio.Name = "lbl_perimetro_trapecio";
            this.lbl_perimetro_trapecio.Size = new System.Drawing.Size(535, 30);
            this.lbl_perimetro_trapecio.TabIndex = 23;
            this.lbl_perimetro_trapecio.Text = "Perímetro: base mayor + base menor + lado + lado";
            // 
            // lbl_area_trapecio
            // 
            this.lbl_area_trapecio.AutoSize = true;
            this.lbl_area_trapecio.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_trapecio.Location = new System.Drawing.Point(15, 325);
            this.lbl_area_trapecio.Name = "lbl_area_trapecio";
            this.lbl_area_trapecio.Size = new System.Drawing.Size(510, 30);
            this.lbl_area_trapecio.TabIndex = 22;
            this.lbl_area_trapecio.Text = "Área: ((base mayor + base menor) × altura) ÷ 2";
            // 
            // lbl_def_trapecio
            // 
            this.lbl_def_trapecio.AutoSize = true;
            this.lbl_def_trapecio.Font = new System.Drawing.Font("Century", 12F);
            this.lbl_def_trapecio.Location = new System.Drawing.Point(11, 287);
            this.lbl_def_trapecio.Name = "lbl_def_trapecio";
            this.lbl_def_trapecio.Size = new System.Drawing.Size(567, 20);
            this.lbl_def_trapecio.TabIndex = 21;
            this.lbl_def_trapecio.Text = "El trapecio es un cuadrilátero con un par de lados opuestos paralelos (bases).";
            // 
            // trapecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_perimetro_trapecio);
            this.Controls.Add(this.lbl_area_trapecio);
            this.Controls.Add(this.lbl_def_trapecio);
            this.Controls.Add(this.pictureBox_trapecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_altura_Trapecio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_lado_Trapecio);
            this.Controls.Add(this.txt_baseMenor_Trapecio);
            this.Controls.Add(this.txt_baseMayor_Trapecio);
            this.Controls.Add(this.btn_Trapecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "trapecio";
            this.Text = "trapecio";
            this.Load += new System.EventHandler(this.trapecio_Load);
            this.Shown += new System.EventHandler(this.trapecio_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_trapecio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Trapecio;
        private System.Windows.Forms.TextBox txt_baseMayor_Trapecio;
        private System.Windows.Forms.TextBox txt_baseMenor_Trapecio;
        private System.Windows.Forms.TextBox txt_lado_Trapecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_altura_Trapecio;
        private System.Windows.Forms.PictureBox pictureBox_trapecio;
        private System.Windows.Forms.Label lbl_perimetro_trapecio;
        private System.Windows.Forms.Label lbl_area_trapecio;
        private System.Windows.Forms.Label lbl_def_trapecio;
    }
}