namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class RellenoFloodFill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RellenoFloodFill));
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.timerPaint = new System.Windows.Forms.Timer(this.components);
            this.listBoxCalculos = new System.Windows.Forms.ListBox();
            this.groupBoxCalculos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPaint = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnRellenar = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.groupBoxCalculos.SuspendLayout();
            this.groupBoxPaint.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.Location = new System.Drawing.Point(5, 24);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(654, 514);
            this.pictureBoxPaint.TabIndex = 0;
            this.pictureBoxPaint.TabStop = false;
            // 
            // listBoxCalculos
            // 
            this.listBoxCalculos.FormattingEnabled = true;
            this.listBoxCalculos.Location = new System.Drawing.Point(4, 21);
            this.listBoxCalculos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listBoxCalculos.Name = "listBoxCalculos";
            this.listBoxCalculos.Size = new System.Drawing.Size(174, 160);
            this.listBoxCalculos.TabIndex = 10;
            // 
            // groupBoxCalculos
            // 
            this.groupBoxCalculos.Controls.Add(this.listBoxCalculos);
            this.groupBoxCalculos.Location = new System.Drawing.Point(702, 84);
            this.groupBoxCalculos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxCalculos.Name = "groupBoxCalculos";
            this.groupBoxCalculos.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxCalculos.Size = new System.Drawing.Size(200, 191);
            this.groupBoxCalculos.TabIndex = 23;
            this.groupBoxCalculos.TabStop = false;
            this.groupBoxCalculos.Text = "Cálculos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 35);
            this.label1.TabIndex = 15;
            this.label1.Text = "PAINT 1.0.0 - FloodFill DFS";
            // 
            // groupBoxPaint
            // 
            this.groupBoxPaint.Controls.Add(this.pictureBoxPaint);
            this.groupBoxPaint.Location = new System.Drawing.Point(22, 48);
            this.groupBoxPaint.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Name = "groupBoxPaint";
            this.groupBoxPaint.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Size = new System.Drawing.Size(664, 545);
            this.groupBoxPaint.TabIndex = 12;
            this.groupBoxPaint.TabStop = false;
            this.groupBoxPaint.Text = "Lienzo";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(79, 21);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 34);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnRellenar);
            this.groupBoxButtons.Controls.Add(this.btnReset);
            this.groupBoxButtons.Location = new System.Drawing.Point(733, 13);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Size = new System.Drawing.Size(147, 63);
            this.groupBoxButtons.TabIndex = 18;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Botones";
            // 
            // btnRellenar
            // 
            this.btnRellenar.BackColor = System.Drawing.Color.Yellow;
            this.btnRellenar.Location = new System.Drawing.Point(11, 21);
            this.btnRellenar.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnRellenar.Name = "btnRellenar";
            this.btnRellenar.Size = new System.Drawing.Size(64, 34);
            this.btnRellenar.TabIndex = 7;
            this.btnRellenar.Text = "Rellenar";
            this.btnRellenar.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(706, 416);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(304, 160);
            this.textBox2.TabIndex = 32;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(707, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 31;
            this.label5.Text = "Funcionamiento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(706, 292);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(304, 75);
            this.textBox1.TabIndex = 29;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(702, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Definición:";
            // 
            // RellenoFloodFill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 606);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxCalculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxPaint);
            this.Controls.Add(this.groupBoxButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RellenoFloodFill";
            this.Text = "Algoritmo 1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.groupBoxCalculos.ResumeLayout(false);
            this.groupBoxPaint.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.Timer timerPaint;
        private System.Windows.Forms.ListBox listBoxCalculos;
        private System.Windows.Forms.GroupBox groupBoxCalculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPaint;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnRellenar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}