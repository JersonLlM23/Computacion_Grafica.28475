namespace TAR2_P2_ALGORITMOS_GRAFICA.Vistas
{
    partial class cutPoligSutherlandH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cutPoligSutherlandH));
            this.picturebxCP = new System.Windows.Forms.PictureBox();
            this.groupBoxPaint = new System.Windows.Forms.GroupBox();
            this.btnResetCP = new System.Windows.Forms.Button();
            this.groupBoxButtons = new System.Windows.Forms.GroupBox();
            this.btnCortarCP = new System.Windows.Forms.Button();
            this.btnPoligonoCP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCP)).BeginInit();
            this.groupBoxPaint.SuspendLayout();
            this.groupBoxButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // picturebxCP
            // 
            this.picturebxCP.Location = new System.Drawing.Point(5, 20);
            this.picturebxCP.Name = "picturebxCP";
            this.picturebxCP.Size = new System.Drawing.Size(654, 518);
            this.picturebxCP.TabIndex = 0;
            this.picturebxCP.TabStop = false;
            // 
            // groupBoxPaint
            // 
            this.groupBoxPaint.Controls.Add(this.picturebxCP);
            this.groupBoxPaint.Location = new System.Drawing.Point(12, 48);
            this.groupBoxPaint.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Name = "groupBoxPaint";
            this.groupBoxPaint.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxPaint.Size = new System.Drawing.Size(664, 541);
            this.groupBoxPaint.TabIndex = 51;
            this.groupBoxPaint.TabStop = false;
            this.groupBoxPaint.Text = "Lienzo";
            // 
            // btnResetCP
            // 
            this.btnResetCP.Location = new System.Drawing.Point(61, 78);
            this.btnResetCP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnResetCP.Name = "btnResetCP";
            this.btnResetCP.Size = new System.Drawing.Size(64, 34);
            this.btnResetCP.TabIndex = 6;
            this.btnResetCP.Text = "Resetear";
            this.btnResetCP.UseVisualStyleBackColor = true;
            // 
            // groupBoxButtons
            // 
            this.groupBoxButtons.Controls.Add(this.btnCortarCP);
            this.groupBoxButtons.Controls.Add(this.btnPoligonoCP);
            this.groupBoxButtons.Controls.Add(this.btnResetCP);
            this.groupBoxButtons.Location = new System.Drawing.Point(696, 27);
            this.groupBoxButtons.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Name = "groupBoxButtons";
            this.groupBoxButtons.Padding = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.groupBoxButtons.Size = new System.Drawing.Size(174, 120);
            this.groupBoxButtons.TabIndex = 52;
            this.groupBoxButtons.TabStop = false;
            this.groupBoxButtons.Text = "Botones";
            // 
            // btnCortarCP
            // 
            this.btnCortarCP.BackColor = System.Drawing.Color.BurlyWood;
            this.btnCortarCP.Location = new System.Drawing.Point(91, 21);
            this.btnCortarCP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnCortarCP.Name = "btnCortarCP";
            this.btnCortarCP.Size = new System.Drawing.Size(64, 34);
            this.btnCortarCP.TabIndex = 9;
            this.btnCortarCP.Text = "Cortar";
            this.btnCortarCP.UseVisualStyleBackColor = false;
            // 
            // btnPoligonoCP
            // 
            this.btnPoligonoCP.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPoligonoCP.Location = new System.Drawing.Point(16, 21);
            this.btnPoligonoCP.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnPoligonoCP.Name = "btnPoligonoCP";
            this.btnPoligonoCP.Size = new System.Drawing.Size(64, 34);
            this.btnPoligonoCP.TabIndex = 8;
            this.btnPoligonoCP.Text = "Polígono";
            this.btnPoligonoCP.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 35);
            this.label1.TabIndex = 57;
            this.label1.Text = "Algoritmo  Sutherland hodgman";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(696, 284);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(304, 160);
            this.textBox2.TabIndex = 56;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(697, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 19);
            this.label5.TabIndex = 55;
            this.label5.Text = "Funcionamiento:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(696, 173);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(304, 75);
            this.textBox1.TabIndex = 53;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(692, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Definición:";
            // 
            // cutPoligSutherlandH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.groupBoxPaint);
            this.Controls.Add(this.groupBoxButtons);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cutPoligSutherlandH";
            this.Text = "cutPoligSutherlandH";
            ((System.ComponentModel.ISupportInitialize)(this.picturebxCP)).EndInit();
            this.groupBoxPaint.ResumeLayout(false);
            this.groupBoxButtons.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picturebxCP;
        private System.Windows.Forms.GroupBox groupBoxPaint;
        private System.Windows.Forms.Button btnResetCP;
        private System.Windows.Forms.GroupBox groupBoxButtons;
        private System.Windows.Forms.Button btnCortarCP;
        private System.Windows.Forms.Button btnPoligonoCP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}