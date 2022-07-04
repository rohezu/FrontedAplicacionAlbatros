namespace FrontedAplicacionAlbatros.Modulo_Facturas
{
    partial class BusquedaFacturas
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
            this.dataGridClientesListado = new System.Windows.Forms.DataGridView();
            this.labelLIstaFacturas = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesListado)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridClientesListado
            // 
            this.dataGridClientesListado.AllowUserToAddRows = false;
            this.dataGridClientesListado.AllowUserToDeleteRows = false;
            this.dataGridClientesListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridClientesListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClientesListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientesListado.Location = new System.Drawing.Point(12, 45);
            this.dataGridClientesListado.Name = "dataGridClientesListado";
            this.dataGridClientesListado.ReadOnly = true;
            this.dataGridClientesListado.Size = new System.Drawing.Size(776, 393);
            this.dataGridClientesListado.TabIndex = 1;
            // 
            // labelLIstaFacturas
            // 
            this.labelLIstaFacturas.AutoSize = true;
            this.labelLIstaFacturas.Location = new System.Drawing.Point(12, 19);
            this.labelLIstaFacturas.Name = "labelLIstaFacturas";
            this.labelLIstaFacturas.Size = new System.Drawing.Size(88, 13);
            this.labelLIstaFacturas.TabIndex = 2;
            this.labelLIstaFacturas.Text = "Lista de Facturas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(558, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Doble Click en la Factura para ver sus detalles";
            // 
            // BusquedaFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLIstaFacturas);
            this.Controls.Add(this.dataGridClientesListado);
            this.Name = "BusquedaFacturas";
            this.Text = "Busqueda de Facturas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BusquedaFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridClientesListado;
        private System.Windows.Forms.Label labelLIstaFacturas;
        private System.Windows.Forms.Label label1;
    }
}