using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionDB;

namespace ModuloFacturacion
{
    public class HeaderFactura : Conexion
    {
        private int idFactura;
        private int idCliente;
        private double totalPuesto;
        private double totalFactura;
        private DateTime fechaCreacion;
        private DateTime fechaAnulacion;

        public int IdFactura { get { return idFactura; } set { idFactura = value; } }

        public int IdCliente { get { return idCliente; } set { idCliente = value; } }

        public double TotalPuesto { get { return totalPuesto; } set { totalPuesto = value; } }


        public double TotalFactura { get { return totalFactura; } set { totalFactura = value; } }

        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = DateTime.Now; } }

        public DateTime? FechaAnulacion { get { return fechaAnulacion; } set { fechaAnulacion = DateTime.Now; } }




        public void CreacionHeader()
        {
            string Impuesto =
            sql = string.Format(@"Execute ALBATROS_FACTURACION_HEADER;;");

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            try
            {
                this.cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }

            ;
            cnx.Close();
        }

        public string CargarUltimaFactura()
        {
            string idFactura = "";
            this.sql = string.Format(@"select top 1 ID_FACTURA from [dbo].[FACTURA_HEADER] order by ID_FACTURA desc;");
            this.cmd = new SqlCommand(this.sql, this.cnx);
            this.cnx.Open();

            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();

            if (Reg.Read())
            {

                idFactura = Convert.ToString(Reg["ID_FACTURA"]);
            }
            else
            {

            }

            this.cnx.Close();
            return (idFactura);
        }

        public void CargarDataGriewHeader(DataGridView dvg)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"select * from [dbo].[FACTURA_HEADER];", ccnx);
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
    }
}
