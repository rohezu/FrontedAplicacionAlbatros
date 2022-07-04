using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Input;
using System.Windows.Forms;
using System.Data.Common;
using ConexionDB;


namespace ModuloClientes
{
    public class Clientes : ConexionDB.Conexion
    {
        private int idCliente;
        private string nombreCliente;
        private string rtnCliente;
        private string direccionCliente;
        private DateTime fechaCreacion;
        private DateTime? fechaModificacion;



        public int IdCliente
        {
            get { return idCliente; }
            set { IdCliente = value; }
        }

        public string NombreCliente { get { return nombreCliente; } set { nombreCliente = value; } }

        public string RtnCliente { get { return rtnCliente; } set { rtnCliente = value; } }

        public string DireccionCliente { get { return direccionCliente; } set { direccionCliente = value; } }

        public DateTime FechaCreacion { get { return fechaCreacion; } set { fechaCreacion = DateTime.Now; } }

        public DateTime? FechaModificacion { get { return fechaModificacion; } set { fechaModificacion = DateTime.Now; } }


        public void CargarDataGriewClientes(DataGridView dvg)
        {
            cnx.Open();
            try
            {
                DataAdapter = new SqlDataAdapter(@"select * from [dbo].[CLIENTES]  where STATUS = 'A'", ccnx);
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

        public void CargarClientes(ComboBox comboBoxClientes)
        {
            cnx.Open();
            sql = string.Format(@"select * from [dbo].[CLIENTES]  where STATUS = 'A'");
            cmd = new SqlCommand(sql, cnx);
            DataAdapter = new SqlDataAdapter(cmd);
            dt = new DataTable();
            DataAdapter.Fill(dt);
            cnx.Close();

            comboBoxClientes.ValueMember = "ID_CLIENTE";
            comboBoxClientes.DisplayMember = "NOMBRE";
            comboBoxClientes.DataSource = dt;
        }


        public void IngresoClientes(Clientes clientes)
        {
            string Impuesto =
            sql = string.Format(@""
            );

            cmd = new SqlCommand(sql, cnx);
            cnx.Open();
            SqlDataReader Reg = null;
            Reg = this.cmd.ExecuteReader();
            cnx.Close();
        }




        public void UpdateCliente(int IdCliente, String Direccion)
        {

            Conexion Con = new Conexion();

            Con.sql = string.Format(@"EXECUTE ALBATROS.DBO.[ALBATROS_CLIENTE_UPDATE] '{0}' ,'{1}' ,
            '{2}' ", IdCliente, Direccion, 3);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();
               
                MessageBox.Show("Se hizo el UPDATE correctamente", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el Update del Cliente", "Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            Con.cnx.Close();




        }
        public void CrearCliente(String Nombre, String RTN, String DireccionCli)
        {

            Conexion Con = new Conexion();


            Con.sql = string.Format(@"EXECUTE ALBATROS.[dbo].[ALBATROS_CLIENTES] '{0}' ,'{1}' ,
            '{2}','{3}'", Nombre, RTN, DireccionCli, 1);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();
                MessageBox.Show("Se ingreso correctamente", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el ingreso del nuevo Cliente", "Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            Con.cnx.Close();




        }
        public void DeleteCliente(int IdCliente)
        {

            Conexion Con = new Conexion();


            Con.sql = string.Format(@"EXECUTE ALBATROS.[dbo].[ALBATROS_CLIENTE_DELETE] '{0}' ,'{1}'", IdCliente, 2);
            try
            {
                Con.cmd = new SqlCommand(Con.sql, Con.cnx);
                Con.cnx.Open();
                SqlDataReader Reg = null;
                Reg = Con.cmd.ExecuteReader();
                MessageBox.Show("Se ingreso correctamente", "Guardado Exitoso", MessageBoxButtons.OK, MessageBoxIcon.None);

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error en el borrado del Cliente", "Esto es embarasoso", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
            }
            Con.cnx.Close();



        }
    }
}