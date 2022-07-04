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

namespace FrontedAplicacionAlbatros.Modulo_Facturas
{
    public partial class BusquedaFacturas : Form
    {
        public BusquedaFacturas()
        {
            InitializeComponent();
        }

        private void BusquedaFacturas_Load(object sender, EventArgs e)
        {
            HeaderFactura headerFactura = new HeaderFactura();
            headerFactura.CargarDataGriewHeader(dataGridClientesListado);
        }
    }
}
