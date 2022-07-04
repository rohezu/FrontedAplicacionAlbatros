using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontedAplicacionAlbatros.Modulo_Item;
using FrontedAplicacionAlbatros.Modulo_Cliente;
using FrontedAplicacionAlbatros.Modulo_Facturas;


namespace FrontedAplicacionAlbatros.General
{
    public partial class MenuIngreso : Form
    {
        public MenuIngreso()
        {
            InitializeComponent();
        }

        private void gestionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesGeneral clientesGeneral = new ClientesGeneral();
            clientesGeneral.ShowDialog();
        }

        private void gestionDeItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductoGeneral itemsGeneral = new ProductoGeneral(); 
            itemsGeneral.ShowDialog();
        }

        private void busquedaDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaFacturas busquedaFacturas = new BusquedaFacturas();
            busquedaFacturas.ShowDialog();
        }

        private void creaciónDeFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreacionFacturas creacionFacturas = new CreacionFacturas();
            creacionFacturas.ShowDialog();
        }
    }
}
