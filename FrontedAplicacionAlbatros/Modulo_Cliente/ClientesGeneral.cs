using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloClientes;

namespace FrontedAplicacionAlbatros.Modulo_Cliente
{
    public partial class ClientesGeneral : Form
    {
        public ClientesGeneral()
        {
            InitializeComponent();
        }

        private void buttonSeleccionarCliente_Click(object sender, EventArgs e)
        {
            ModificacionClientes modificacionClientes = new ModificacionClientes();
            modificacionClientes.ShowDialog();
        }

        private void ClientesGeneral_Load(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            textBox1.Enabled=false;
            clientes.CargarDataGriewClientes(dataGridClientesListado);
        }

        private void dataGridClientesListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificacionClientes modClientes = new ModificacionClientes();

            DataGridViewRow dataGridViewRow = dataGridClientesListado.Rows[e.RowIndex];
            modClientes.idCliente = Convert.ToString(dataGridViewRow.Cells["ID_CLIENTE"].Value.ToString());
            modClientes.nombreCliente = Convert.ToString(dataGridViewRow.Cells["NOMBRE"].Value.ToString());
            modClientes.ShowDialog();
        }

        

        private void dataGridClientesListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ModificacionClientes modClientes = new ModificacionClientes();

            DataGridViewRow dataGridViewRow = dataGridClientesListado.Rows[e.RowIndex];
            modClientes.idCliente = Convert.ToString(dataGridViewRow.Cells["ID_CLIENTE"].Value.ToString());
            modClientes.nombreCliente = Convert.ToString(dataGridViewRow.Cells["NOMBRE"].Value.ToString());
            modClientes.RTN = Convert.ToString(dataGridViewRow.Cells["RTN"].Value.ToString());
            modClientes.DireccionCli = Convert.ToString(dataGridViewRow.Cells["Direccion"].Value.ToString());
            modClientes.Fecha_Creacion = Convert.ToString(dataGridViewRow.Cells["Fecha_Creacion"].Value.ToString());
            modClientes.Fecha_Modificacion = Convert.ToString(dataGridViewRow.Cells["Fecha_Modificacion"].Value.ToString());
            modClientes.datasg = dataGridClientesListado;
            modClientes.ShowDialog();
        }

        private void buttonGuardarClientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();

            clientes.CrearCliente(textBox2.Text, textBox3.Text, textBox4.Text);
            clientes.CargarDataGriewClientes(dataGridClientesListado);


        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
