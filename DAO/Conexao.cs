using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_A1_Supermecado.DAO
{
    public class Conexao
    {
        public static SqlConnection conectar()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-DOH161L;Initial Catalog=Supermecado;Integrated Security=True";
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public static Boolean CRUD(SqlCommand cmd)
        {
            try
            {
                SqlConnection con = conectar();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return false;
            }
        }

        public static SqlDataReader selecionar(SqlCommand cmd)
        {
            try
            {
                SqlConnection con = conectar();
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                return dr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                return null;
            }
        }

        internal static object pesquisar(string v)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = v;
            SqlDataReader dr = Conexao.selecionar(cmd);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, Conexao.conectar());
            da.Fill(dt);
            return dt;
        }
    }
}
