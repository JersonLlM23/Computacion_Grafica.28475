namespace TAR2_P2_ALGORITMOS_GRAFICA
{
    partial class Home
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.trazadoDeLíneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.algoritmoDDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoPuntoMedioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trazadoDeCircunferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoEcuaciónParamétricaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoPuntoMedioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmoDeBresenhamCirculosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosDeRellenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alogirmo1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alogirmo2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alogirmo3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosDeCortesDeLíneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cohenSutherlandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liangBarskyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nichollLeeNichollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.algoritmosDeCortesDePolígonosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sutherlandHodgmanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liangBarskyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.weilerAthertonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.Azure;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trazadoDeLíneasToolStripMenuItem,
            this.trazadoDeCircunferenciasToolStripMenuItem,
            this.algoritmosDeRellenoToolStripMenuItem,
            this.algoritmosDeCortesDeLíneasToolStripMenuItem,
            this.algoritmosDeCortesDePolígonosToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(237, 435);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // trazadoDeLíneasToolStripMenuItem
            // 
            this.trazadoDeLíneasToolStripMenuItem.Checked = true;
            this.trazadoDeLíneasToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.trazadoDeLíneasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.algoritmoDDAToolStripMenuItem,
            this.algoritmoPuntoMedioToolStripMenuItem,
            this.algoritmoDeBToolStripMenuItem});
            this.trazadoDeLíneasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.trazadoDeLíneasToolStripMenuItem.Name = "trazadoDeLíneasToolStripMenuItem";
            this.trazadoDeLíneasToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trazadoDeLíneasToolStripMenuItem.Size = new System.Drawing.Size(125, 19);
            this.trazadoDeLíneasToolStripMenuItem.Text = "Trazado de líneas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // algoritmoDDAToolStripMenuItem
            // 
            this.algoritmoDDAToolStripMenuItem.Name = "algoritmoDDAToolStripMenuItem";
            this.algoritmoDDAToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.algoritmoDDAToolStripMenuItem.Text = "Algoritmo DDA";
            this.algoritmoDDAToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.algoritmoDDAToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDDAToolStripMenuItem_Click);
            // 
            // algoritmoPuntoMedioToolStripMenuItem
            // 
            this.algoritmoPuntoMedioToolStripMenuItem.Name = "algoritmoPuntoMedioToolStripMenuItem";
            this.algoritmoPuntoMedioToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.algoritmoPuntoMedioToolStripMenuItem.Text = "Algoritmo Punto Medio";
            this.algoritmoPuntoMedioToolStripMenuItem.Click += new System.EventHandler(this.algoritmoPuntoMedioToolStripMenuItem_Click);
            // 
            // algoritmoDeBToolStripMenuItem
            // 
            this.algoritmoDeBToolStripMenuItem.Name = "algoritmoDeBToolStripMenuItem";
            this.algoritmoDeBToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.algoritmoDeBToolStripMenuItem.Text = "Algoritmo de Bresenham";
            this.algoritmoDeBToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeBToolStripMenuItem_Click);
            // 
            // trazadoDeCircunferenciasToolStripMenuItem
            // 
            this.trazadoDeCircunferenciasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.algoritmoEcuaciónParamétricaToolStripMenuItem,
            this.algoritmoPuntoMedioToolStripMenuItem1,
            this.algoritmoDeBresenhamCirculosToolStripMenuItem});
            this.trazadoDeCircunferenciasToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trazadoDeCircunferenciasToolStripMenuItem.Name = "trazadoDeCircunferenciasToolStripMenuItem";
            this.trazadoDeCircunferenciasToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trazadoDeCircunferenciasToolStripMenuItem.Size = new System.Drawing.Size(183, 19);
            this.trazadoDeCircunferenciasToolStripMenuItem.Text = "Trazado de Circunferencias";
            this.trazadoDeCircunferenciasToolStripMenuItem.Click += new System.EventHandler(this.trazadoDeCircunferenciasToolStripMenuItem_Click);
            // 
            // algoritmoEcuaciónParamétricaToolStripMenuItem
            // 
            this.algoritmoEcuaciónParamétricaToolStripMenuItem.Name = "algoritmoEcuaciónParamétricaToolStripMenuItem";
            this.algoritmoEcuaciónParamétricaToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.algoritmoEcuaciónParamétricaToolStripMenuItem.Text = "Algoritmo ecuación Paramétrica";
            this.algoritmoEcuaciónParamétricaToolStripMenuItem.Click += new System.EventHandler(this.algoritmoEcuaciónParamétricaToolStripMenuItem_Click);
            // 
            // algoritmoPuntoMedioToolStripMenuItem1
            // 
            this.algoritmoPuntoMedioToolStripMenuItem1.Name = "algoritmoPuntoMedioToolStripMenuItem1";
            this.algoritmoPuntoMedioToolStripMenuItem1.Size = new System.Drawing.Size(288, 22);
            this.algoritmoPuntoMedioToolStripMenuItem1.Text = "Algoritmo Punto Medio  (Circulos)";
            this.algoritmoPuntoMedioToolStripMenuItem1.Click += new System.EventHandler(this.algoritmoPuntoMedioToolStripMenuItem1_Click);
            // 
            // algoritmoDeBresenhamCirculosToolStripMenuItem
            // 
            this.algoritmoDeBresenhamCirculosToolStripMenuItem.Name = "algoritmoDeBresenhamCirculosToolStripMenuItem";
            this.algoritmoDeBresenhamCirculosToolStripMenuItem.Size = new System.Drawing.Size(288, 22);
            this.algoritmoDeBresenhamCirculosToolStripMenuItem.Text = "Algoritmo de Bresenham (Circulos)";
            this.algoritmoDeBresenhamCirculosToolStripMenuItem.Click += new System.EventHandler(this.algoritmoDeBresenhamCirculosToolStripMenuItem_Click);
            // 
            // algoritmosDeRellenoToolStripMenuItem
            // 
            this.algoritmosDeRellenoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alogirmo1ToolStripMenuItem,
            this.alogirmo2ToolStripMenuItem,
            this.alogirmo3ToolStripMenuItem});
            this.algoritmosDeRellenoToolStripMenuItem.Name = "algoritmosDeRellenoToolStripMenuItem";
            this.algoritmosDeRellenoToolStripMenuItem.Size = new System.Drawing.Size(152, 19);
            this.algoritmosDeRellenoToolStripMenuItem.Text = "Algoritmos de Relleno";
            // 
            // alogirmo1ToolStripMenuItem
            // 
            this.alogirmo1ToolStripMenuItem.Name = "alogirmo1ToolStripMenuItem";
            this.alogirmo1ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.alogirmo1ToolStripMenuItem.Text = "Flood Fill DFS";
            this.alogirmo1ToolStripMenuItem.Click += new System.EventHandler(this.alogirmo1ToolStripMenuItem_Click);
            // 
            // alogirmo2ToolStripMenuItem
            // 
            this.alogirmo2ToolStripMenuItem.Name = "alogirmo2ToolStripMenuItem";
            this.alogirmo2ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.alogirmo2ToolStripMenuItem.Text = "Flood Fill BFS";
            this.alogirmo2ToolStripMenuItem.Click += new System.EventHandler(this.alogirmo2ToolStripMenuItem_Click);
            // 
            // alogirmo3ToolStripMenuItem
            // 
            this.alogirmo3ToolStripMenuItem.Name = "alogirmo3ToolStripMenuItem";
            this.alogirmo3ToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.alogirmo3ToolStripMenuItem.Text = "Boundary Fill";
            this.alogirmo3ToolStripMenuItem.Click += new System.EventHandler(this.alogirmo3ToolStripMenuItem_Click);
            // 
            // algoritmosDeCortesDeLíneasToolStripMenuItem
            // 
            this.algoritmosDeCortesDeLíneasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cohenSutherlandToolStripMenuItem,
            this.liangBarskyToolStripMenuItem,
            this.nichollLeeNichollToolStripMenuItem});
            this.algoritmosDeCortesDeLíneasToolStripMenuItem.Name = "algoritmosDeCortesDeLíneasToolStripMenuItem";
            this.algoritmosDeCortesDeLíneasToolStripMenuItem.Size = new System.Drawing.Size(204, 19);
            this.algoritmosDeCortesDeLíneasToolStripMenuItem.Text = "Algoritmos de Cortes de Líneas";
            // 
            // cohenSutherlandToolStripMenuItem
            // 
            this.cohenSutherlandToolStripMenuItem.Name = "cohenSutherlandToolStripMenuItem";
            this.cohenSutherlandToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cohenSutherlandToolStripMenuItem.Text = "Cohen-Sutherland";
            this.cohenSutherlandToolStripMenuItem.Click += new System.EventHandler(this.cohenSutherlandToolStripMenuItem_Click);
            // 
            // liangBarskyToolStripMenuItem
            // 
            this.liangBarskyToolStripMenuItem.Name = "liangBarskyToolStripMenuItem";
            this.liangBarskyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.liangBarskyToolStripMenuItem.Text = "Liang–Barsky";
            this.liangBarskyToolStripMenuItem.Click += new System.EventHandler(this.liangBarskyToolStripMenuItem_Click);
            // 
            // nichollLeeNichollToolStripMenuItem
            // 
            this.nichollLeeNichollToolStripMenuItem.Name = "nichollLeeNichollToolStripMenuItem";
            this.nichollLeeNichollToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nichollLeeNichollToolStripMenuItem.Text = "Nicholl–Lee–Nicholl";
            this.nichollLeeNichollToolStripMenuItem.Click += new System.EventHandler(this.nichollLeeNichollToolStripMenuItem_Click);
            // 
            // algoritmosDeCortesDePolígonosToolStripMenuItem
            // 
            this.algoritmosDeCortesDePolígonosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sutherlandHodgmanToolStripMenuItem,
            this.liangBarskyToolStripMenuItem1,
            this.weilerAthertonToolStripMenuItem});
            this.algoritmosDeCortesDePolígonosToolStripMenuItem.Name = "algoritmosDeCortesDePolígonosToolStripMenuItem";
            this.algoritmosDeCortesDePolígonosToolStripMenuItem.Size = new System.Drawing.Size(223, 19);
            this.algoritmosDeCortesDePolígonosToolStripMenuItem.Text = "Algoritmos de Cortes de Polígonos";
            // 
            // sutherlandHodgmanToolStripMenuItem
            // 
            this.sutherlandHodgmanToolStripMenuItem.Name = "sutherlandHodgmanToolStripMenuItem";
            this.sutherlandHodgmanToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.sutherlandHodgmanToolStripMenuItem.Text = "Sutherland Hodgman";
            this.sutherlandHodgmanToolStripMenuItem.Click += new System.EventHandler(this.sutherlandHodgmanToolStripMenuItem_Click);
            // 
            // liangBarskyToolStripMenuItem1
            // 
            this.liangBarskyToolStripMenuItem1.Name = "liangBarskyToolStripMenuItem1";
            this.liangBarskyToolStripMenuItem1.Size = new System.Drawing.Size(206, 22);
            this.liangBarskyToolStripMenuItem1.Text = "Liang Barsky";
            this.liangBarskyToolStripMenuItem1.Click += new System.EventHandler(this.liangBarskyToolStripMenuItem1_Click);
            // 
            // weilerAthertonToolStripMenuItem
            // 
            this.weilerAthertonToolStripMenuItem.Name = "weilerAthertonToolStripMenuItem";
            this.weilerAthertonToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.weilerAthertonToolStripMenuItem.Text = "Weiler Atherton";
            this.weilerAthertonToolStripMenuItem.Click += new System.EventHandler(this.weilerAthertonToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 435);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Home";
            this.Text = "Página Principal";
            this.Load += new System.EventHandler(this.Home_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem trazadoDeLíneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trazadoDeCircunferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosDeRellenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosDeCortesDeLíneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmosDeCortesDePolígonosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoPuntoMedioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoEcuaciónParamétricaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem algoritmoPuntoMedioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem algoritmoDeBresenhamCirculosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alogirmo1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alogirmo2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alogirmo3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cohenSutherlandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liangBarskyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nichollLeeNichollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sutherlandHodgmanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liangBarskyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem weilerAthertonToolStripMenuItem;
    }
}

