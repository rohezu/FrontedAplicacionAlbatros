using ModuloClientes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontedAplicacionAlbatros.Modulo_Cliente
{
    public partial class ModificacionClientes : Form
    {
        public string idCliente;
        public string nombreCliente;
        public string RTN;
        public string DireccionCli;
        public string Fecha_Modificacion;
        public string Fecha_Creacion;
        public DataGridView datasg;

        public ModificacionClientes()
        {
            InitializeComponent();
        }

        private void ModificacionClientes_Load(object sender, EventArgs e)
        {
            textIDCLiente.Text = idCliente;
            textNombre.Text = nombreCliente;
            textBoxRTN.Text = RTN;
            textBoxDireccion.Text = DireccionCli;
            textIDCLiente.Text = idCliente;
            textClientesFechaCreacion.Text = Fecha_Creacion;
            textClientesFechaMoificacionUltima.Text = Fecha_Modificacion;
            textClientesFechaCreacion.Enabled = false;
            textClientesFechaMoificacionUltima.Enabled = false;
            textNombre.Enabled = false;
            textBoxRTN.Enabled = false;


        }

        private void textIDCLiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();

            clientes.UpdateCliente (Convert.ToInt16(textIDCLiente.Text), textBoxDireccion.Text);
          
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.DeleteCliente(Convert.ToInt16(textIDCLiente.Text));
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            clientes.CargarDataGriewClientes(datasg);
            this.Close();
        }
    }
}
