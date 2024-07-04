namespace InventarioCSharp
{
    partial class Form1
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
            this.cuentadanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarCuentadanteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionarProveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentadanteToolStripMenuItem,
            this.equipoToolStripMenuItem,
            this.partesToolStripMenuItem,
            this.proveedorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(918, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cuentadanteToolStripMenuItem
            // 
            this.cuentadanteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarCuentadanteToolStripMenuItem});
            this.cuentadanteToolStripMenuItem.Name = "cuentadanteToolStripMenuItem";
            this.cuentadanteToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cuentadanteToolStripMenuItem.Text = "Cuentadante";
            // 
            // gestionarCuentadanteToolStripMenuItem
            // 
            this.gestionarCuentadanteToolStripMenuItem.Name = "gestionarCuentadanteToolStripMenuItem";
            this.gestionarCuentadanteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.gestionarCuentadanteToolStripMenuItem.Text = "Gestionar Cuentadante";
            this.gestionarCuentadanteToolStripMenuItem.Click += new System.EventHandler(this.gestionarCuentadanteToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarEquipoToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // gestionarEquipoToolStripMenuItem
            // 
            this.gestionarEquipoToolStripMenuItem.Name = "gestionarEquipoToolStripMenuItem";
            this.gestionarEquipoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.gestionarEquipoToolStripMenuItem.Text = "Gestionar Equipo";
            // 
            // partesToolStripMenuItem
            // 
            this.partesToolStripMenuItem.Name = "partesToolStripMenuItem";
            this.partesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.partesToolStripMenuItem.Text = "Partes";
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionarProveedorToolStripMenuItem});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.proveedorToolStripMenuItem.Text = "Proveedor";
            // 
            // gestionarProveedorToolStripMenuItem
            // 
            this.gestionarProveedorToolStripMenuItem.Name = "gestionarProveedorToolStripMenuItem";
            this.gestionarProveedorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.gestionarProveedorToolStripMenuItem.Text = "Gestionar_Proveedor";
            this.gestionarProveedorToolStripMenuItem.Click += new System.EventHandler(this.gestionarProveedorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cuentadanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarCuentadanteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionarProveedorToolStripMenuItem;
    }
}

