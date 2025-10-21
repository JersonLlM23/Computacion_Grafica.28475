namespace TAR1_VENTANASNAV_AREAS
{
    partial class cuadrado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cuadrado));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cuadrado = new System.Windows.Forms.Label();
            this.txt_lado_cuadrado = new System.Windows.Forms.TextBox();
            this.btn_Cuadrado = new System.Windows.Forms.Button();
            this.picFigura_cuadrado = new System.Windows.Forms.PictureBox();
            this.lbl_def_cuadrado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_area_cuadrado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFigura_cuadrado)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Área y Perímetro del cuadrado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "FIGURA: CUADRADO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_cuadrado
            // 
            this.lbl_cuadrado.AutoSize = true;
            this.lbl_cuadrado.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cuadrado.Location = new System.Drawing.Point(16, 127);
            this.lbl_cuadrado.Name = "lbl_cuadrado";
            this.lbl_cuadrado.Size = new System.Drawing.Size(276, 20);
            this.lbl_cuadrado.TabIndex = 3;
            this.lbl_cuadrado.Text = "Ingrese cualquier lado del cuadrado:";
            // 
            // txt_lado_cuadrado
            // 
            this.txt_lado_cuadrado.Location = new System.Drawing.Point(298, 127);
            this.txt_lado_cuadrado.Multiline = true;
            this.txt_lado_cuadrado.Name = "txt_lado_cuadrado";
            this.txt_lado_cuadrado.Size = new System.Drawing.Size(100, 20);
            this.txt_lado_cuadrado.TabIndex = 4;
            // 
            // btn_Cuadrado
            // 
            this.btn_Cuadrado.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_Cuadrado.Location = new System.Drawing.Point(20, 166);
            this.btn_Cuadrado.Name = "btn_Cuadrado";
            this.btn_Cuadrado.Size = new System.Drawing.Size(102, 23);
            this.btn_Cuadrado.TabIndex = 5;
            this.btn_Cuadrado.Text = "Calcular";
            this.btn_Cuadrado.UseVisualStyleBackColor = false;
            this.btn_Cuadrado.Click += new System.EventHandler(this.btn_Cuadrado_Click);
            // 
            // picFigura_cuadrado
            // 
            this.picFigura_cuadrado.Image = ((System.Drawing.Image)(resources.GetObject("picFigura_cuadrado.Image")));
            this.picFigura_cuadrado.Location = new System.Drawing.Point(492, 59);
            this.picFigura_cuadrado.Name = "picFigura_cuadrado";
            this.picFigura_cuadrado.Size = new System.Drawing.Size(273, 211);
            this.picFigura_cuadrado.TabIndex = 6;
            this.picFigura_cuadrado.TabStop = false;
            // 
            // lbl_def_cuadrado
            // 
            this.lbl_def_cuadrado.AutoSize = true;
            this.lbl_def_cuadrado.Font = new System.Drawing.Font("Century", 12F);
            this.lbl_def_cuadrado.Location = new System.Drawing.Point(16, 292);
            this.lbl_def_cuadrado.Name = "lbl_def_cuadrado";
            this.lbl_def_cuadrado.Size = new System.Drawing.Size(632, 20);
            this.lbl_def_cuadrado.TabIndex = 7;
            this.lbl_def_cuadrado.Text = "El cuadrado es una figura geométrica de cuatro lados iguales y cuatro ángulos rec" +
    "tos.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Área: lado × lado";
            // 
            // lbl_area_cuadrado
            // 
            this.lbl_area_cuadrado.AutoSize = true;
            this.lbl_area_cuadrado.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_area_cuadrado.Location = new System.Drawing.Point(231, 321);
            this.lbl_area_cuadrado.Name = "lbl_area_cuadrado";
            this.lbl_area_cuadrado.Size = new System.Drawing.Size(214, 30);
            this.lbl_area_cuadrado.TabIndex = 9;
            this.lbl_area_cuadrado.Text = "Perímetro: 4 × lado";
            // 
            // cuadrado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_area_cuadrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_def_cuadrado);
            this.Controls.Add(this.picFigura_cuadrado);
            this.Controls.Add(this.btn_Cuadrado);
            this.Controls.Add(this.txt_lado_cuadrado);
            this.Controls.Add(this.lbl_cuadrado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "cuadrado";
            this.Text = "Cuadrado";
            this.Load += new System.EventHandler(this.cuadrado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFigura_cuadrado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cuadrado;
        private System.Windows.Forms.TextBox txt_lado_cuadrado;
        private System.Windows.Forms.Button btn_Cuadrado;
        private System.Windows.Forms.PictureBox picFigura_cuadrado;
        private System.Windows.Forms.Label lbl_def_cuadrado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_area_cuadrado;
    }
}