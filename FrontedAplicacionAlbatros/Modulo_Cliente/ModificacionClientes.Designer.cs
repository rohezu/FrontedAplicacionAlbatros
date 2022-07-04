namespace FrontedAplicacionAlbatros.Modulo_Cliente
{
    partial class ModificacionClientes
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
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonGuardarClientes = new System.Windows.Forms.Button();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxRTN = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textIDCLiente = new System.Windows.Forms.TextBox();
            this.lableIdCliente = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRTN = new System.Windows.Forms.Label();
            this.textClientesFechaCreacion = new System.Windows.Forms.TextBox();
            this.labelFechaCreacion = new System.Windows.Forms.Label();
            this.labelFechaModificacion = new System.Windows.Forms.Label();
            this.textClientesFechaMoificacionUltima = new System.Windows.Forms.TextBox();
            this.borrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(225, 443);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(287, 58);
            this.buttonCancelar.TabIndex = 20;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonGuardarClientes
            // 
            this.buttonGuardarClientes.Location = new System.Drawing.Point(225, 378);
            this.buttonGuardarClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonGuardarClientes.Name = "buttonGuardarClientes";
            this.buttonGuardarClientes.Size = new System.Drawing.Size(287, 58);
            this.buttonGuardarClientes.TabIndex = 19;
            this.buttonGuardarClientes.Text = "Guardar Datos";
            this.buttonGuardarClientes.UseVisualStyleBackColor = true;
            this.buttonGuardarClientes.Click += new System.EventHandler(this.buttonGuardarClientes_Click);
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDireccion.Location = new System.Drawing.Point(227, 219);
            this.textBoxDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDireccion.Multiline = true;
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(285, 142);
            this.textBoxDireccion.TabIndex = 18;
            // 
            // textBoxRTN
            // 
            this.textBoxRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRTN.Location = new System.Drawing.Point(225, 102);
            this.textBoxRTN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxRTN.Name = "textBoxRTN";
            this.textBoxRTN.Size = new System.Drawing.Size(285, 26);
            this.textBoxRTN.TabIndex = 17;
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(225, 60);
            this.textNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(285, 26);
            this.textNombre.TabIndex = 16;
            // 
            // textIDCLiente
            // 
            this.textIDCLiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIDCLiente.Location = new System.Drawing.Point(225, 18);
            this.textIDCLiente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textIDCLiente.Name = "textIDCLiente";
            this.textIDCLiente.ReadOnly = true;
            this.textIDCLiente.Size = new System.Drawing.Size(285, 26);
            this.textIDCLiente.TabIndex = 15;
            this.textIDCLiente.TextChanged += new System.EventHandler(this.textIDCLiente_TextChanged);
            // 
            // lableIdCliente
            // 
            this.lableIdCliente.AutoSize = true;
            this.lableIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIdCliente.Location = new System.Drawing.Point(25, 22);
            this.lableIdCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lableIdCliente.Name = "lableIdCliente";
            this.lableIdCliente.Size = new System.Drawing.Size(83, 20);
            this.lableIdCliente.TabIndex = 14;
            this.lableIdCliente.Text = "ID Cliente";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(25, 223);
            this.labelDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(81, 20);
            this.labelDireccion.TabIndex = 13;
            this.labelDireccion.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombre Cliente";
            // 
            // labelRTN
            // 
            this.labelRTN.AutoSize = true;
            this.labelRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRTN.Location = new System.Drawing.Point(25, 103);
            this.labelRTN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRTN.Name = "labelRTN";
            this.labelRTN.Size = new System.Drawing.Size(43, 20);
            this.labelRTN.TabIndex = 11;
            this.labelRTN.Text = "RTN";
            // 
            // textClientesFechaCreacion
            // 
            this.textClientesFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClientesFechaCreacion.Location = new System.Drawing.Point(227, 140);
            this.textClientesFechaCreacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textClientesFechaCreacion.Name = "textClientesFechaCreacion";
            this.textClientesFechaCreacion.Size = new System.Drawing.Size(285, 26);
            this.textClientesFechaCreacion.TabIndex = 21;
            // 
            // labelFechaCreacion
            // 
            this.labelFechaCreacion.AutoSize = true;
            this.labelFechaCreacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaCreacion.Location = new System.Drawing.Point(25, 144);
            this.labelFechaCreacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaCreacion.Name = "labelFechaCreacion";
            this.labelFechaCreacion.Size = new System.Drawing.Size(127, 20);
            this.labelFechaCreacion.TabIndex = 22;
            this.labelFechaCreacion.Text = "Fecha Creacion";
            // 
            // labelFechaModificacion
            // 
            this.labelFechaModificacion.AutoSize = true;
            this.labelFechaModificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaModificacion.Location = new System.Drawing.Point(25, 180);
            this.labelFechaModificacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFechaModificacion.Name = "labelFechaModificacion";
            this.labelFechaModificacion.Size = new System.Drawing.Size(156, 20);
            this.labelFechaModificacion.TabIndex = 23;
            this.labelFechaModificacion.Text = "Ultima Modificacion";
            // 
            // textClientesFechaMoificacionUltima
            // 
            this.textClientesFechaMoificacionUltima.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClientesFechaMoificacionUltima.Location = new System.Drawing.Point(227, 180);
            this.textClientesFechaMoificacionUltima.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textClientesFechaMoificacionUltima.Name = "textClientesFechaMoificacionUltima";
            this.textClientesFechaMoificacionUltima.Size = new System.Drawing.Size(285, 26);
            this.textClientesFechaMoificacionUltima.TabIndex = 24;
            // 
            // borrar
            // 
            this.borrar.Location = new System.Drawing.Point(13, 378);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(205, 58);
            this.borrar.TabIndex = 25;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = true;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // ModificacionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 526);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.textClientesFechaMoificacionUltima);
            this.Controls.Add(this.labelFechaModificacion);
            this.Controls.Add(this.labelFechaCreacion);
            this.Controls.Add(this.textClientesFechaCreacion);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardarClientes);
            this.Controls.Add(this.textBoxDireccion);
            this.Controls.Add(this.textBoxRTN);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textIDCLiente);
            this.Controls.Add(this.lableIdCliente);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelRTN);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificacionClientes";
            this.Text = "Modificacion de Clientes";
            this.Load += new System.EventHandler(this.ModificacionClientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonGuardarClientes;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxRTN;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textIDCLiente;
        private System.Windows.Forms.Label lableIdCliente;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRTN;
        private System.Windows.Forms.TextBox textClientesFechaCreacion;
        private System.Windows.Forms.Label labelFechaCreacion;
        private System.Windows.Forms.Label labelFechaModificacion;
        private System.Windows.Forms.TextBox textClientesFechaMoificacionUltima;
        private System.Windows.Forms.Button borrar;
    }
}