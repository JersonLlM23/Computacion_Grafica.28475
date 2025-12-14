namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class RellenoFloodFillBFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RellenoFloodFillBFS));
            this.pictureBoxPaint2 = new System.Windows.Forms.PictureBox();
            this.timerPaint2 = new System.Windows.Forms.Timer(this.components);
            this.listBoxCalculos2 = new System.Windows.Forms.ListBox();
            this.groupBoxCalculos = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxPaint = new System.Windows.Forms.GroupBox();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnRellenar2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint2)).BeginInit();
            this.groupBoxCalculos.SuspendLayout();
            this.groupBoxPaint.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPaint2
            // 
            this.pictureBoxPaint2.Location = new System.Drawing.Point(5, 24);
            this.pictureBoxPaint2.Name = "pictureBoxPaint2";
            this.pictureBoxPaint2.Size = new System.Drawing.Size(654, 514);
            this.pictureBoxPaint2.TabIndex = 0;
            this.pictureBoxPaint2.TabStop = false;
            // 
            // listBoxCalculos2
            // 
            this.listBoxCalculos2.FormattingEnabled = true;
            this.listBoxCalculos2.Location = new System.Drawing.Point(7, 41);
            this.listBoxCalculos2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.listBoxCalculos2.Name = "listBoxCalculos2";
            this.listBoxCalculos2.Size = new System.Drawing.Size(174, 160);
            this.listBoxCalculos2.TabIndex = 10;
            // 
            // groupBoxCalculos
            // 
            this.groupBoxCalculos.Controls.Add(this.listBoxCalculos2);
            this.groupBoxCalculos.Location = new System.Drawing.Point(702, 84);
            this.groupBoxCalculos.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxCalculos.Name = "groupBoxCalculos";
            this.groupBoxCalculos.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxCalculos.Size = new System.Drawing.Size(200, 211);
            this.groupBoxCalculos.TabIndex = 27;
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
            this.label1.Size = new System.Drawing.Size(289, 35);
            this.label1.TabIndex = 25;
            this.label1.Text = "PAINT 1.2.0 - FloodFill BFS";
            // 
            // groupBoxPaint
            // 
            this.groupBoxPaint.Controls.Add(this.pictureBoxPaint2);
            this.groupBoxPaint.Location = new System.Drawing.Point(22, 48);
            this.groupBoxPaint.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Name = "groupBoxPaint";
            this.groupBoxPaint.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Size = new System.Drawing.Size(664, 545);
            this.groupBoxPaint.TabIndex = 24;
            this.groupBoxPaint.TabStop = false;
            this.groupBoxPaint.Text = "Lienzo";
            // 
            // btnReset2
            // 
            this.btnReset2.Location = new System.Drawing.Point(79, 21);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(64, 34);
            this.btnReset2.TabIndex = 6;
            this.btnReset2.Text = "Resetear";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click_1);
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnRellenar2);
            this.groupBoxButtons.Controls.Add(this.btnReset2);
            this.groupBoxButtons.Location = new System.Drawing.Point(733, 13);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Size = new System.Drawing.Size(147, 63);
            this.groupBoxButtons.TabIndex = 26;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Botones";
            // 
            // btnRellenar2
            // 
            this.btnRellenar2.BackColor = System.Drawing.Color.Yellow;
            this.btnRellenar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRellenar2.Location = new System.Drawing.Point(11, 21);
            this.btnRellenar2.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnRellenar2.Name = "btnRellenar2";
            this.btnRellenar2.Size = new System.Drawing.Size(64, 34);
            this.btnRellenar2.TabIndex = 7;
            this.btnRellenar2.Text = "Rellenar";
            this.btnRellenar2.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(709, 433);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(287, 160);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(710, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "Funcionamiento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(709, 309);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(287, 75);
            this.textBox1.TabIndex = 33;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(705, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 34;
            this.label2.Text = "Definición:";
            // 
            // RellenoFloodFillBFS
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
            this.Name = "RellenoFloodFillBFS";
            this.Text = "FloodFillBFS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint2)).EndInit();
            this.groupBoxCalculos.ResumeLayout(false);
            this.groupBoxPaint.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPaint2;
        private System.Windows.Forms.Timer timerPaint2;
        private System.Windows.Forms.ListBox listBoxCalculos2;
        private System.Windows.Forms.GroupBox groupBoxCalculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxPaint;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnRellenar2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}