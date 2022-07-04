using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModuloProductos;

namespace FrontedAplicacionAlbatros.Modulo_Item
{
    public partial class ProductoGeneral : Form
    {
        public ProductoGeneral()
        {
            InitializeComponent();
        }
        private void ProductoGeneral_Load(object sender, EventArgs e)
        {
            Productos products = new Productos();
            products.CargarComboPro (comboImpuestos);
            products.CargarDataGriewProductos(dataGridItemsListado);
        }

        private void buttonGuardarClientes_Click(object sender, EventArgs e)
        {
            Productos products = new Productos();

            products.CrearProducto (textBox2.Text, Convert.ToDecimal(textPrecioProducto.Text),Convert.ToInt16(textPrecioProducto.Text));
            products.CargarDataGriewProductos(dataGridItemsListado);
        }
    }
}
