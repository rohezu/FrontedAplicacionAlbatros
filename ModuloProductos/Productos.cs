using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.Data.Common;
using ConexionDB;
using System.Windows.Forms;


namespace ModuloProductos
{
    public class Productos:ConexionDB.Conexion
    {
        private int codProducto;
        private String producto;
        private Decimal precio;
        private int impuesto;

        public int CodProducto { get => codProducto; set => codProducto = value; }
        public string Producto { get => producto; set => producto = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public int Impuesto { get => impuesto; set => impuesto = value; }

        public void CargarDataGriewProductos(DataGridView dvg)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"select * from [dbo].[PRODUCTO]  where STATUS = 'A'", ccnx);
                dt = new DataTable();
                DataAdapter.Fill(dt);
                dvg.DataSource = dt;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            cnx.Close();

        }
        public void CargarComboPro(ComboBox comboBoxPro)
        {
            Conexion Con = new Conexion();
            Con.cnx.Open();
            Con.sql = string.Format(@"select ID_IMPUESTO, impuesto from [dbo].[IMPUESTO]");
            Con.cmd = new SqlCommand(Con.sql, Con.cnx);
            Con.DataAdapter = new SqlDataAdapter(Con.cmd);
            Con.dt = new DataTable();
            Con.DataAdapter.Fill(Con.dt);
            

            comboBoxPro.ValueMember = "ID_IMPUESTO";
            comboBoxPro.DisplayMember = "impuesto";
            comboBoxPro.DataSource = dt;
            Con.cnx.Close();
        }
        public void UpdateProducto(int CodProducto, String Producto, Decimal Precio, int Impuesto)
        {

            Conexion Con = new Conexion();

            Con.sql = string.Format(@"EXECUTE ALBATROS.DBO.[ALBATROS_PRODUCTOS_UPDATE] '{0}' ,'{1}' ,
            '{2}','{3}' ,'{4}' ", CodProducto, Producto, Precio, Impuesto,3);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();
                Con.cnx.Close();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el Update del Producto", "Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Con.cnx.Close();
            }





        }
        public void CrearProducto(String Producto, Decimal Precio, int Impuesto)
        {

            Conexion Con = new Conexion();

            
            Con.sql = string.Format(@"EXECUTE ALBATROS.DBO.[ALBATROS_PRODUCTOS] '{0}' ,'{1}' ,
            '{2}%','{3}' ", Producto, Precio, Impuesto,1);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();


            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el ingreso del nuevo Producto", "Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Con.cnx.Close();
            }





        }
        public void DeleteProducto(int CodProducto)
        {

            Conexion Con = new Conexion();


            Con.sql = string.Format(@"EXECUTE ALBATROS.[dbo].[ALBATROS_PRODUCTOS_DELETE]  '{0}' ,'{1}'", CodProducto, 2);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();


            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el borrado del Producto", "Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Con.cnx.Close();
            }





        }
        

    }
}