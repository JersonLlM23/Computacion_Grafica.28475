namespace TAR1_VENTANASNAV_AREAS
{
    partial class romboide
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Romboide = new System.Windows.Forms.Button();
            this.txt_baseRomboide = new System.Windows.Forms.TextBox();
            this.txt_alturaRomboide = new System.Windows.Forms.TextBox();
            this.pictureBox_romboide = new System.Windows.Forms.PictureBox();
            this.lbl_perimetro_romboide = new System.Windows.Forms.Label();
            this.lbl_area_romboide = new System.Windows.Forms.Label();
            this.lbl_def_romboide = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_romboide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "FIGURA: ROMBOIDE";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área y Perímetro del romboide.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century", 12F);
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingresa la base del romboide:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century", 12F);
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(236, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ingresa la altura del romboide:";
            // 
            // btn_Romboide
            // 
            this.btn_Romboide.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Romboide.Location = new System.Drawing.Point(32, 188);
            this.btn_Romboide.Name = "btn_Romboide";
            this.btn_Romboide.Size = new System.Drawing.Size(95, 26);
            this.btn_Romboide.TabIndex = 4;
            this.btn_Romboide.Text = "Calcular";
            this.btn_Romboide.UseVisualStyleBackColor = false;
            this.btn_Romboide.Click += new System.EventHandler(this.btn_Romboide_Click);
            // 
            // txt_baseRomboide
            // 
            this.txt_baseRomboide.Location = new System.Drawing.Point(266, 113);
            this.txt_baseRomboide.Name = "txt_baseRomboide";
            this.txt_baseRomboide.Size = new System.Drawing.Size(100, 20);
            this.txt_baseRomboide.TabIndex = 5;
            // 
            // txt_alturaRomboide
            // 
            this.txt_alturaRomboide.Location = new System.Drawing.Point(266, 148);
            this.txt_alturaRomboide.Name = "txt_alturaRomboide";
            this.txt_alturaRomboide.Size = new System.Drawing.Size(100, 20);
            this.txt_alturaRomboide.TabIndex = 6;
            // 
            // pictureBox_romboide
            // 
            this.pictureBox_romboide.Location = new System.Drawing.Point(454, 46);
            this.pictureBox_romboide.Name = "pictureBox_romboide";
            this.pictureBox_romboide.Size = new System.Drawing.Size(300, 182);
            this.pictureBox_romboide.TabIndex = 7;
            this.pictureBox_romboide.TabStop = false;
            // 
            // lbl_perimetro_romboide
            // 
            this.lbl_perimetro_romboide.AutoSize = true;
            this.lbl_perimetro_romboide.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_perimetro_romboide.Location = new System.Drawing.Point(296, 298);
            this.lbl_perimetro_romboide.Name = "lbl_perimetro_romboide";
            this.lbl_perimetro_romboide.Size = new System.Drawing.Size(307, 30);
            this.lbl_perimetro_romboide.TabIndex = 20;
            this.lbl_perimetro_romboide.Text = "Perímetro: 2 × (base + lado)";
            // 
            // lbl_area_romboide
            // 
            this.lbl_area_romboide.AutoSize = true;
            this.lbl_area_romboide.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_romboide.Location = new System.Drawing.Point(20, 298);
            this.lbl_area_romboide.Name = "lbl_area_romboide";
            this.lbl_area_romboide.Size = new System.Drawing.Size(218, 30);
            this.lbl_area_romboide.TabIndex = 19;
            this.lbl_area_romboide.Text = "Área: base × altura";
            // 
            // lbl_def_romboide
            // 
            this.lbl_def_romboide.AutoSize = true;
            this.lbl_def_romboide.Font = new System.Drawing.Font("Century", 12F);
            this.lbl_def_romboide.Location = new System.Drawing.Point(16, 260);
            this.lbl_def_romboide.Name = "lbl_def_romboide";
            this.lbl_def_romboide.Size = new System.Drawing.Size(518, 20);
            this.lbl_def_romboide.TabIndex = 18;
            this.lbl_def_romboide.Text = "El romboide es un cuadrilátero con lados opuestos iguales y paralelos.";
            // 
            // romboide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_perimetro_romboide);
            this.Controls.Add(this.lbl_area_romboide);
            this.Controls.Add(this.lbl_def_romboide);
            this.Controls.Add(this.pictureBox_romboide);
            this.Controls.Add(this.txt_alturaRomboide);
            this.Controls.Add(this.txt_baseRomboide);
            this.Controls.Add(this.btn_Romboide);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "romboide";
            this.Text = "romboide";
            this.Load += new System.EventHandler(this.romboide_Load);
            this.Shown += new System.EventHandler(this.romboide_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_romboide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Romboide;
        private System.Windows.Forms.TextBox txt_baseRomboide;
        private System.Windows.Forms.TextBox txt_alturaRomboide;
        private System.Windows.Forms.PictureBox pictureBox_romboide;
        private System.Windows.Forms.Label lbl_perimetro_romboide;
        private System.Windows.Forms.Label lbl_area_romboide;
        private System.Windows.Forms.Label lbl_def_romboide;
    }
}