namespace UI
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarListasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaAutosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarAutoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBMToolStripMenuItem,
            this.mostrarListasToolStripMenuItem,
            this.asignarAutoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1140, 33);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personasToolStripMenuItem,
            this.autosToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(66, 29);
            this.aBMToolStripMenuItem.Text = "ABM";
            // 
            // personasToolStripMenuItem
            // 
            this.personasToolStripMenuItem.Name = "personasToolStripMenuItem";
            this.personasToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.personasToolStripMenuItem.Text = "Personas";
            this.personasToolStripMenuItem.Click += new System.EventHandler(this.personasToolStripMenuItem_Click);
            // 
            // autosToolStripMenuItem
            // 
            this.autosToolStripMenuItem.Name = "autosToolStripMenuItem";
            this.autosToolStripMenuItem.Size = new System.Drawing.Size(184, 34);
            this.autosToolStripMenuItem.Text = "Autos";
            this.autosToolStripMenuItem.Click += new System.EventHandler(this.autosToolStripMenuItem_Click);
            // 
            // mostrarListasToolStripMenuItem
            // 
            this.mostrarListasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaAutosToolStripMenuItem,
            this.listaPersonasToolStripMenuItem,
            this.listaAutosToolStripMenuItem1});
            this.mostrarListasToolStripMenuItem.Name = "mostrarListasToolStripMenuItem";
            this.mostrarListasToolStripMenuItem.Size = new System.Drawing.Size(138, 29);
            this.mostrarListasToolStripMenuItem.Text = "Mostrar Listas";
            // 
            // listaAutosToolStripMenuItem
            // 
            this.listaAutosToolStripMenuItem.Name = "listaAutosToolStripMenuItem";
            this.listaAutosToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.listaAutosToolStripMenuItem.Text = "Personas / Autos";
            // 
            // listaPersonasToolStripMenuItem
            // 
            this.listaPersonasToolStripMenuItem.Name = "listaPersonasToolStripMenuItem";
            this.listaPersonasToolStripMenuItem.Size = new System.Drawing.Size(248, 34);
            this.listaPersonasToolStripMenuItem.Text = "Lista Personas";
            // 
            // listaAutosToolStripMenuItem1
            // 
            this.listaAutosToolStripMenuItem1.Name = "listaAutosToolStripMenuItem1";
            this.listaAutosToolStripMenuItem1.Size = new System.Drawing.Size(248, 34);
            this.listaAutosToolStripMenuItem1.Text = "Lista Autos";
            // 
            // asignarAutoToolStripMenuItem
            // 
            this.asignarAutoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarAutoToolStripMenuItem1});
            this.asignarAutoToolStripMenuItem.Name = "asignarAutoToolStripMenuItem";
            this.asignarAutoToolStripMenuItem.Size = new System.Drawing.Size(115, 29);
            this.asignarAutoToolStripMenuItem.Text = "Asignación";
            // 
            // asignarAutoToolStripMenuItem1
            // 
            this.asignarAutoToolStripMenuItem1.Name = "asignarAutoToolStripMenuItem1";
            this.asignarAutoToolStripMenuItem1.Size = new System.Drawing.Size(218, 34);
            this.asignarAutoToolStripMenuItem1.Text = "Asignar Auto";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarAutoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarListasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaAutosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

