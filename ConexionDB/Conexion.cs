using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace ConexionDB
{
    public class Conexion
    {
        public string ccnx;
        public string sql;
        public string mensaje;
        public SqlConnection cnx;
        public SqlCommand cmd;
        public SqlDataAdapter DataAdapter;
        public DataTable dt;
        public DataRow Dr;
        public SqlDataReader DtR;
        public DataSet Dataset;
        public DataView DataView;

        public Conexion()
        {

            try
            {

                this.ccnx = @"Data Source=LAPTOP-QCCHCKRB;Initial Catalog=ALBATROS;integrated security=true;";
                this.cnx = new SqlConnection(this.ccnx);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Abrir()
        {
            try
            {
                cnx.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

    }
}
