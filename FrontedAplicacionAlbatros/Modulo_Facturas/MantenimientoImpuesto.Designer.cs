namespace FrontedAplicacionAlbatros.Modulo_Facturas
{
    partial class MantenimientoImpuesto
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
            this.tabBusqueda = new System.Windows.Forms.TabPage();
            this.dataGridClientesListado = new System.Windows.Forms.DataGridView();
            this.tabControlImpuestos = new System.Windows.Forms.TabControl();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupImpuestos = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesListado)).BeginInit();
            this.tabControlImpuestos.SuspendLayout();
            this.groupImpuestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBusqueda
            // 
            this.tabBusqueda.Controls.Add(this.groupImpuestos);
            this.tabBusqueda.Controls.Add(this.dataGridClientesListado);
            this.tabBusqueda.Location = new System.Drawing.Point(4, 22);
            this.tabBusqueda.Name = "tabBusqueda";
            this.tabBusqueda.Padding = new System.Windows.Forms.Padding(3);
            this.tabBusqueda.Size = new System.Drawing.Size(792, 424);
            this.tabBusqueda.TabIndex = 0;
            this.tabBusqueda.Text = "Gestion de Impuestos";
            this.tabBusqueda.UseVisualStyleBackColor = true;
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
            this.dataGridClientesListado.Location = new System.Drawing.Point(8, 161);
            this.dataGridClientesListado.Name = "dataGridClientesListado";
            this.dataGridClientesListado.ReadOnly = true;
            this.dataGridClientesListado.Size = new System.Drawing.Size(776, 255);
            this.dataGridClientesListado.TabIndex = 0;
            // 
            // tabControlImpuestos
            // 
            this.tabControlImpuestos.Controls.Add(this.tabBusqueda);
            this.tabControlImpuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlImpuestos.Location = new System.Drawing.Point(0, 0);
            this.tabControlImpuestos.Name = "tabControlImpuestos";
            this.tabControlImpuestos.SelectedIndex = 0;
            this.tabControlImpuestos.Size = new System.Drawing.Size(800, 450);
            this.tabControlImpuestos.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor de Impuesto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancelar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Guardar Datos";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupImpuestos
            // 
            this.groupImpuestos.Controls.Add(this.textBox1);
            this.groupImpuestos.Controls.Add(this.button1);
            this.groupImpuestos.Controls.Add(this.button2);
            this.groupImpuestos.Controls.Add(this.label2);
            this.groupImpuestos.Location = new System.Drawing.Point(20, 18);
            this.groupImpuestos.Name = "groupImpuestos";
            this.groupImpuestos.Size = new System.Drawing.Size(317, 137);
            this.groupImpuestos.TabIndex = 13;
            this.groupImpuestos.TabStop = false;
            this.groupImpuestos.Text = "Ingreso de Impuestos";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 20);
            this.textBox1.TabIndex = 9;
            // 
            // MantenimientoImpuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlImpuestos);
            this.Name = "MantenimientoImpuesto";
            this.Text = "MantenimientoImpuesto";
            this.Load += new System.EventHandler(this.MantenimientoImpuesto_Load);
            this.tabBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientesListado)).EndInit();
            this.tabControlImpuestos.ResumeLayout(false);
            this.groupImpuestos.ResumeLayout(false);
            this.groupImpuestos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabBusqueda;
        private System.Windows.Forms.DataGridView dataGridClientesListado;
        private System.Windows.Forms.TabControl tabControlImpuestos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupImpuestos;
        private System.Windows.Forms.TextBox textBox1;
    }
}