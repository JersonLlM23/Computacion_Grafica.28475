namespace TAR1_P2_VELOCIMETRO
{
    partial class Velocimetro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxVelocimetro = new System.Windows.Forms.PictureBox();
            this.timerVelocimetro = new System.Windows.Forms.Timer(this.components);
            this.labelVelocidad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVelocimetro)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxVelocimetro
            // 
            this.pictureBoxVelocimetro.Location = new System.Drawing.Point(425, 25);
            this.pictureBoxVelocimetro.Name = "pictureBoxVelocimetro";
            this.pictureBoxVelocimetro.Size = new System.Drawing.Size(363, 397);
            this.pictureBoxVelocimetro.TabIndex = 0;
            this.pictureBoxVelocimetro.TabStop = false;
            this.pictureBoxVelocimetro.Click += new System.EventHandler(this.pictureBoxVelocimetro_Click);
            this.pictureBoxVelocimetro.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxVelocimetro_Paint);
            // 
            // labelVelocidad
            // 
            this.labelVelocidad.AutoSize = true;
            this.labelVelocidad.Font = new System.Drawing.Font("Century Schoolbook", 66F, System.Drawing.FontStyle.Bold);
            this.labelVelocidad.Location = new System.Drawing.Point(23, 201);
            this.labelVelocidad.Name = "labelVelocidad";
            this.labelVelocidad.Size = new System.Drawing.Size(95, 103);
            this.labelVelocidad.TabIndex = 1;
            this.labelVelocidad.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "VELOCIDAD (Km/h):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 25.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 41);
            this.label2.TabIndex = 3;
            this.label2.Text = "VELOCÍMETRO:";
            // 
            // Velocimetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelVelocidad);
            this.Controls.Add(this.pictureBoxVelocimetro);
            this.Name = "Velocimetro";
            this.Text = "Velocímetro";
            this.Load += new System.EventHandler(this.Velocimetro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Velocimetro_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVelocimetro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxVelocimetro;
        private System.Windows.Forms.Timer timerVelocimetro;
        private System.Windows.Forms.Label labelVelocidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

