using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloFacturacion;
using ModuloClientes;

namespace FrontedAplicacionAlbatros.Modulo_Facturas
{
    public partial class CreacionFacturas : Form
    {
        public CreacionFacturas()
        {
            InitializeComponent();
        }

        private void CreacionFacturas_Load(object sender, EventArgs e)
        {
            HeaderFactura headerFactura = new HeaderFactura();
            headerFactura.CreacionHeader();

            textIdFacturas.Text = headerFactura.CargarUltimaFactura();

            Clientes clientes = new Clientes();
            clientes.CargarClientes(comboBoxClientes);
        }
    }
}
