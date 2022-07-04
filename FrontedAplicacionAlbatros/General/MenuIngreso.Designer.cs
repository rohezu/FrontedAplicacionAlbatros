namespace FrontedAplicacionAlbatros.General
{
    partial class MenuIngreso
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
            this.menuGeneral = new System.Windows.Forms.MenuStrip();
            this.gestionDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busquedaDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creaciónDeFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuGeneral
            // 
            this.menuGeneral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDeClientesToolStripMenuItem,
            this.gestionDeItemsToolStripMenuItem,
            this.facturaciónToolStripMenuItem});
            this.menuGeneral.Location = new System.Drawing.Point(0, 0);
            this.menuGeneral.Name = "menuGeneral";
            this.menuGeneral.Size = new System.Drawing.Size(800, 24);
            this.menuGeneral.TabIndex = 0;
            this.menuGeneral.Text = "menuStrip1";
            // 
            // gestionDeClientesToolStripMenuItem
            // 
            this.gestionDeClientesToolStripMenuItem.Name = "gestionDeClientesToolStripMenuItem";
            this.gestionDeClientesToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.gestionDeClientesToolStripMenuItem.Text = "Gestion de Clientes";
            this.gestionDeClientesToolStripMenuItem.Click += new System.EventHandler(this.gestionDeClientesToolStripMenuItem_Click);
            // 
            // gestionDeItemsToolStripMenuItem
            // 
            this.gestionDeItemsToolStripMenuItem.Name = "gestionDeItemsToolStripMenuItem";
            this.gestionDeItemsToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.gestionDeItemsToolStripMenuItem.Text = "Gestion de Items";
            this.gestionDeItemsToolStripMenuItem.Click += new System.EventHandler(this.gestionDeItemsToolStripMenuItem_Click);
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.busquedaDeFacturasToolStripMenuItem,
            this.creaciónDeFacturasToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // busquedaDeFacturasToolStripMenuItem
            // 
            this.busquedaDeFacturasToolStripMenuItem.Name = "busquedaDeFacturasToolStripMenuItem";
            this.busquedaDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.busquedaDeFacturasToolStripMenuItem.Text = "Busqueda de Facturas";
            this.busquedaDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.busquedaDeFacturasToolStripMenuItem_Click);
            // 
            // creaciónDeFacturasToolStripMenuItem
            // 
            this.creaciónDeFacturasToolStripMenuItem.Name = "creaciónDeFacturasToolStripMenuItem";
            this.creaciónDeFacturasToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.creaciónDeFacturasToolStripMenuItem.Text = "Creación de Facturas";
            this.creaciónDeFacturasToolStripMenuItem.Click += new System.EventHandler(this.creaciónDeFacturasToolStripMenuItem_Click);
            // 
            // MenuIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuGeneral);
            this.MainMenuStrip = this.menuGeneral;
            this.Name = "MenuIngreso";
            this.Text = "MenuIngreso";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuGeneral.ResumeLayout(false);
            this.menuGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuGeneral;
        private System.Windows.Forms.ToolStripMenuItem gestionDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDeItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busquedaDeFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creaciónDeFacturasToolStripMenuItem;
    }
}