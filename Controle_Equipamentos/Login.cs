using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Controle_Equipamentos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //SQL Server
            //  SqlConnection
            //     ConnectionString
            //     Open()
            //     Close()

            //  SqlCommand
            //      Connection
            //      CommandText
            //      ExecuteReader()
            //      ExecuteNonQuery()
            //      ExecuteScalar()

            //  SqlDataReader
            //      Read()

            var cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                                    Initial Catalog=Cad_equipamento;
                                    Integrated Security=True;";
            cn.Open();
            Mensagem("Conexão Aberta");

            cn.Close();
            Mensagem("Conexão Fechada");

            //if (txtUser.Text  == "1223")
            //{
            //    MessageBox.Show( txtUser.Text );
            //}
            //else
            //{
            //    MessageBox.Show("errou o nome");
            //}
        }
    }
}
