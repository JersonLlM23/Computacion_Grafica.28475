namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class CutLinesLiangB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CutLinesLiangB));
            this.picturebxCL2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPaint = new System.Windows.Forms.GroupBox();
            this.btnResetCL2 = new System.Windows.Forms.Button();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnCortar2 = new System.Windows.Forms.Button();
            this.btnLinea2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCL2)).BeginInit();
            this.groupBoxPaint.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturebxCL2
            // 
            this.picturebxCL2.Location = new System.Drawing.Point(5, 24);
            this.picturebxCL2.Name = "picturebxCL2";
            this.picturebxCL2.Size = new System.Drawing.Size(654, 514);
            this.picturebxCL2.TabIndex = 0;
            this.picturebxCL2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 35);
            this.label1.TabIndex = 42;
            this.label1.Text = "Algoritmo de corte:  Liang–Barsky";
            // 
            // groupBoxPaint
            // 
            this.groupBoxPaint.Controls.Add(this.picturebxCL2);
            this.groupBoxPaint.Location = new System.Drawing.Point(11, 48);
            this.groupBoxPaint.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Name = "groupBoxPaint";
            this.groupBoxPaint.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Size = new System.Drawing.Size(664, 571);
            this.groupBoxPaint.TabIndex = 41;
            this.groupBoxPaint.TabStop = false;
            this.groupBoxPaint.Text = "Lienzo";
            // 
            // btnResetCL2
            // 
            this.btnResetCL2.Location = new System.Drawing.Point(61, 78);
            this.btnResetCL2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnResetCL2.Name = "btnResetCL2";
            this.btnResetCL2.Size = new System.Drawing.Size(64, 34);
            this.btnResetCL2.TabIndex = 6;
            this.btnResetCL2.Text = "Resetear";
            this.btnResetCL2.UseVisualStyleBackColor = true;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnCortar2);
            this.groupBoxButtons.Controls.Add(this.btnLinea2);
            this.groupBoxButtons.Controls.Add(this.btnResetCL2);
            this.groupBoxButtons.Location = new System.Drawing.Point(695, 13);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Size = new System.Drawing.Size(174, 120);
            this.groupBoxButtons.TabIndex = 43;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Botones";
            // 
            // btnCortar2
            // 
            this.btnCortar2.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCortar2.Location = new System.Drawing.Point(91, 21);
            this.btnCortar2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCortar2.Name = "btnCortar2";
            this.btnCortar2.Size = new System.Drawing.Size(64, 34);
            this.btnCortar2.TabIndex = 9;
            this.btnCortar2.Text = "Cortar";
            this.btnCortar2.UseVisualStyleBackColor = false;
            // 
            // btnLinea2
            // 
            this.btnLinea2.BackColor = System.Drawing.Color.Aquamarine;
            this.btnLinea2.Location = new System.Drawing.Point(16, 21);
            this.btnLinea2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnLinea2.Name = "btnLinea2";
            this.btnLinea2.Size = new System.Drawing.Size(64, 34);
            this.btnLinea2.TabIndex = 8;
            this.btnLinea2.Text = "Líneas";
            this.btnLinea2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(695, 286);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(304, 160);
            this.textBox2.TabIndex = 47;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Funcionamiento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(695, 175);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(304, 75);
            this.textBox1.TabIndex = 44;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Definición:";
            // 
            // CutLinesLiangB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1040, 628);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPaint);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CutLinesLiangB";
            this.Text = "CutLinesLiangB";
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCL2)).EndInit();
            this.groupBoxPaint.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebxCL2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPaint;
        private System.Windows.Forms.Button btnResetCL2;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnCortar2;
        private System.Windows.Forms.Button btnLinea2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}