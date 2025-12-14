namespace TAR3_P2_ALGORITMOS_CURVAS.Vistas
{
    partial class frmCurvas
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
            this.timerBEZIER = new System.Windows.Forms.Timer(this.components);
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pictureBoxCurva = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.cmbGrado = new System.Windows.Forms.ComboBox();
            this.btnAnimarBezier = new System.Windows.Forms.Button();
            this.txtCurvas = new System.Windows.Forms.TextBox();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.txtAlgoritmo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDibujarBSpline = new System.Windows.Forms.Button();
            this.btnDibujarBeziers = new System.Windows.Forms.Button();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnPausaBezier = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.btnAnimarBS = new System.Windows.Forms.Button();
            this.btnPausarBS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.timerBspline = new System.Windows.Forms.Timer(this.components);
            this.pnlMid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurva)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.pnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.pictureBoxCurva);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(90, 53);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(746, 562);
            this.pnlMid.TabIndex = 7;
            // 
            // pictureBoxCurva
            // 
            this.pictureBoxCurva.BackColor = System.Drawing.Color.White;
            this.pictureBoxCurva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCurva.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCurva.Name = "pictureBoxCurva";
            this.pictureBoxCurva.Size = new System.Drawing.Size(746, 562);
            this.pictureBoxCurva.TabIndex = 0;
            this.pictureBoxCurva.TabStop = false;
            this.pictureBoxCurva.Click += new System.EventHandler(this.pictureBoxCurva_Click);
            this.pictureBoxCurva.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxCurva_Paint_1);
            this.pictureBoxCurva.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxCurva_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.label3.Location = new System.Drawing.Point(46, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.txtDescripcion.Location = new System.Drawing.Point(15, 174);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescripcion.Size = new System.Drawing.Size(165, 358);
            this.txtDescripcion.TabIndex = 2;
            // 
            // cmbGrado
            // 
            this.cmbGrado.FormattingEnabled = true;
            this.cmbGrado.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbGrado.Location = new System.Drawing.Point(3, 168);
            this.cmbGrado.Name = "cmbGrado";
            this.cmbGrado.Size = new System.Drawing.Size(84, 21);
            this.cmbGrado.TabIndex = 6;
            // 
            // btnAnimarBezier
            // 
            this.btnAnimarBezier.BackColor = System.Drawing.Color.Khaki;
            this.btnAnimarBezier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimarBezier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAnimarBezier.Location = new System.Drawing.Point(9, 192);
            this.btnAnimarBezier.Name = "btnAnimarBezier";
            this.btnAnimarBezier.Size = new System.Drawing.Size(72, 32);
            this.btnAnimarBezier.TabIndex = 4;
            this.btnAnimarBezier.Text = "Animar";
            this.btnAnimarBezier.UseVisualStyleBackColor = false;
            this.btnAnimarBezier.Click += new System.EventHandler(this.btnDibujarCurva_Click_1);
            // 
            // txtCurvas
            // 
            this.txtCurvas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCurvas.Enabled = false;
            this.txtCurvas.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurvas.Location = new System.Drawing.Point(9, 18);
            this.txtCurvas.Multiline = true;
            this.txtCurvas.Name = "txtCurvas";
            this.txtCurvas.ReadOnly = true;
            this.txtCurvas.Size = new System.Drawing.Size(87, 47);
            this.txtCurvas.TabIndex = 3;
            this.txtCurvas.Text = "Selecciona una Curva:";
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Coral;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCerrar.Location = new System.Drawing.Point(9, 518);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(72, 32);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnResetCurvas_Click);
            // 
            // txtAlgoritmo
            // 
            this.txtAlgoritmo.Enabled = false;
            this.txtAlgoritmo.Font = new System.Drawing.Font("Book Antiqua", 12F);
            this.txtAlgoritmo.Location = new System.Drawing.Point(15, 54);
            this.txtAlgoritmo.Multiline = true;
            this.txtAlgoritmo.Name = "txtAlgoritmo";
            this.txtAlgoritmo.ReadOnly = true;
            this.txtAlgoritmo.Size = new System.Drawing.Size(165, 62);
            this.txtAlgoritmo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 13F);
            this.label4.Location = new System.Drawing.Point(46, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Algoritmo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnDibujarBSpline
            // 
            this.btnDibujarBSpline.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDibujarBSpline.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujarBSpline.Location = new System.Drawing.Point(9, 284);
            this.btnDibujarBSpline.Name = "btnDibujarBSpline";
            this.btnDibujarBSpline.Size = new System.Drawing.Size(72, 72);
            this.btnDibujarBSpline.TabIndex = 1;
            this.btnDibujarBSpline.Text = "B-Spline";
            this.btnDibujarBSpline.UseVisualStyleBackColor = false;
            this.btnDibujarBSpline.Click += new System.EventHandler(this.btnDibujarBSpline_Click);
            // 
            // btnDibujarBeziers
            // 
            this.btnDibujarBeziers.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDibujarBeziers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDibujarBeziers.Location = new System.Drawing.Point(9, 71);
            this.btnDibujarBeziers.Name = "btnDibujarBeziers";
            this.btnDibujarBeziers.Size = new System.Drawing.Size(72, 72);
            this.btnDibujarBeziers.TabIndex = 0;
            this.btnDibujarBeziers.Text = "Bézier";
            this.btnDibujarBeziers.UseVisualStyleBackColor = false;
            this.btnDibujarBeziers.Click += new System.EventHandler(this.btnDibujarBeziers_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.label5);
            this.pnlLeft.Controls.Add(this.btnPausarBS);
            this.pnlLeft.Controls.Add(this.btnAnimarBS);
            this.pnlLeft.Controls.Add(this.btnPausaBezier);
            this.pnlLeft.Controls.Add(this.cmbGrado);
            this.pnlLeft.Controls.Add(this.btnAnimarBezier);
            this.pnlLeft.Controls.Add(this.txtCurvas);
            this.pnlLeft.Controls.Add(this.btnCerrar);
            this.pnlLeft.Controls.Add(this.btnDibujarBSpline);
            this.pnlLeft.Controls.Add(this.btnDibujarBeziers);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 53);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(90, 562);
            this.pnlLeft.TabIndex = 5;
            // 
            // btnPausaBezier
            // 
            this.btnPausaBezier.BackColor = System.Drawing.Color.Khaki;
            this.btnPausaBezier.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPausaBezier.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPausaBezier.Location = new System.Drawing.Point(9, 230);
            this.btnPausaBezier.Name = "btnPausaBezier";
            this.btnPausaBezier.Size = new System.Drawing.Size(72, 32);
            this.btnPausaBezier.TabIndex = 7;
            this.btnPausaBezier.Text = "Pausar";
            this.btnPausaBezier.UseVisualStyleBackColor = false;
            this.btnPausaBezier.Click += new System.EventHandler(this.btnPausa_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Controls.Add(this.txtAlgoritmo);
            this.pnlRight.Controls.Add(this.label4);
            this.pnlRight.Controls.Add(this.label3);
            this.pnlRight.Controls.Add(this.txtDescripcion);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Location = new System.Drawing.Point(836, 53);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(192, 562);
            this.pnlRight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Paint 1.4.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curvas Bézier y curva B-Spline";
            // 
            // pnlUp
            // 
            this.pnlUp.Controls.Add(this.label2);
            this.pnlUp.Controls.Add(this.label1);
            this.pnlUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUp.Location = new System.Drawing.Point(0, 0);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(1028, 53);
            this.pnlUp.TabIndex = 4;
            this.pnlUp.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlUp_Paint);
            // 
            // btnAnimarBS
            // 
            this.btnAnimarBS.BackColor = System.Drawing.Color.Khaki;
            this.btnAnimarBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAnimarBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnAnimarBS.Location = new System.Drawing.Point(9, 362);
            this.btnAnimarBS.Name = "btnAnimarBS";
            this.btnAnimarBS.Size = new System.Drawing.Size(72, 32);
            this.btnAnimarBS.TabIndex = 8;
            this.btnAnimarBS.Text = "Animar";
            this.btnAnimarBS.UseVisualStyleBackColor = false;
            this.btnAnimarBS.Click += new System.EventHandler(this.btnAnimarBS_Click);
            // 
            // btnPausarBS
            // 
            this.btnPausarBS.BackColor = System.Drawing.Color.Khaki;
            this.btnPausarBS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPausarBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnPausarBS.Location = new System.Drawing.Point(9, 400);
            this.btnPausarBS.Name = "btnPausarBS";
            this.btnPausarBS.Size = new System.Drawing.Size(72, 32);
            this.btnPausarBS.TabIndex = 9;
            this.btnPausarBS.Text = "Pausar";
            this.btnPausarBS.UseVisualStyleBackColor = false;
            this.btnPausarBS.Click += new System.EventHandler(this.btnPausarBS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9F);
            this.label5.Location = new System.Drawing.Point(25, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Grado:";
            // 
            // frmCurvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 615);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlUp);
            this.Name = "frmCurvas";
            this.Text = "Home";
            this.pnlMid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCurva)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlUp.ResumeLayout(false);
            this.pnlUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerBEZIER;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.ComboBox cmbGrado;
        private System.Windows.Forms.Button btnAnimarBezier;
        private System.Windows.Forms.TextBox txtCurvas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.TextBox txtAlgoritmo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDibujarBSpline;
        private System.Windows.Forms.Button btnDibujarBeziers;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.PictureBox pictureBoxCurva;
        private System.Windows.Forms.Button btnPausaBezier;
        private System.Windows.Forms.Button btnAnimarBS;
        private System.Windows.Forms.Button btnPausarBS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerBspline;
    }
}