using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula16
{
   
    public partial class Cad_Celular : Form
    {
        string connectionString =@"Data Source = DESKTOP-5HIR0H9; 
                                Initial Catalog = Cad_Equipamento; 
                                Integrated Security = True;";
        public bool novo;

        public Cad_Celular()
        {
            InitializeComponent();
        }

        //Button search
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //var sql = "SELECT * FROM Celulares WHERE Nome= " + tstName.Text;

            var sql = "SELECT * FROM Celulares WHERE Nome LIKE '%" + tstName.Text + "%'";

            if (tstName.Text == "")
            {
                MessageBox.Show("Precisa digitar algo né seu animal");

            }
        
            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandText = sql;
            SqlDataReader reader;
            cn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tsbNew.Enabled = false;
                    tsbSave.Enabled = true;
                    tsbCancel.Enabled = true;
                    tsbDelete.Enabled = true;


                    tstName.Enabled = true;
                    tsbBuscar.Enabled = true;

                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    txtFilial.Enabled = true;
                    txtModelo.Enabled = true;
                    txtMarca.Enabled = true;
                    txtIMEI.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtMemoria.Enabled = true;
                    txtDep.Enabled = true;
                    txtObs.Enabled = true;
                    txtTermo.Enabled = true;
                    txtUser.Enabled = true;
                    txtNF.Enabled = true;
                    mskEntrega.Enabled = true;
                    mskDevolucao.Enabled = true;
                    txtMat.Enabled = true;
                    txtRG.Enabled = true;
                    mskCPF.Enabled = true;
                    
                    tstName.Focus();
                    txtId.Text= reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    txtFilial.Text = reader[2].ToString();
                    txtModelo.Text = reader[3].ToString(); 
                    txtMarca.Text = reader[4].ToString();
                    txtIMEI.Text = reader[5].ToString();    
                    txtTelefone.Text = reader[6].ToString();
                    txtMemoria.Text= reader[7].ToString();
                    txtDep.Text = reader[8].ToString();
                    txtObs.Text = reader[9].ToString();
                    txtTermo.Text = reader[10].ToString();
                    txtUser.Text = reader[11].ToString();
                    txtNF.Text = reader[12].ToString();
                    mskEntrega.Text = reader[13].ToString();
                    mskDevolucao.Text = reader[14].ToString();
                    txtMat.Text = reader[15].ToString();
                    txtRG.Text = reader[16].ToString();
                    mskCPF.Text = reader[17].ToString();

                    novo = false;
                }
                else
                    MessageBox.Show("Nenhum registro encontrado com o nome informado!");


            }
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Erro: " + ex.ToString());
            //}
            finally
            {
                cn.Close();
            }
        }

        //Button Transfer
        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            var sql = "INSERT INTO Sobra_Celular SELECT * FROM Celulares WHERE id= " + tstName.Text;

            SqlConnection cn = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandText = sql;
            SqlDataReader reader;
            cn.Open();

            try
            {
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    //tsbNew.Enabled = false;
                    //tsbSave.Enabled = true;
                    //tsbCancel.Enabled = true;
                    //tsbDelete.Enabled = true;


                    tstName.Enabled = false;
                    tsbBuscar.Enabled = false;

                    txtId.Enabled = false;
                    txtNome.Enabled = true;
                    txtFilial.Enabled = true;
                    txtModelo.Enabled = true;
                    txtMarca.Enabled = true;
                    txtIMEI.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtMemoria.Enabled = true;
                    txtDep.Enabled = true;
                    txtObs.Enabled = true;
                    txtTermo.Enabled = true;
                    txtUser.Enabled = true;
                    txtNF.Enabled = true;
                    mskEntrega.Enabled = true;
                    mskDevolucao.Enabled = true;

                    tstName.Focus();
                    txtId.Text = reader[0].ToString();
                    txtNome.Text = reader[1].ToString();
                    txtFilial.Text = reader[2].ToString();
                    txtModelo.Text = reader[3].ToString();
                    txtMarca.Text = reader[4].ToString();
                    txtIMEI.Text = reader[5].ToString();
                    txtTelefone.Text = reader[6].ToString();
                    txtMemoria.Text = reader[7].ToString();
                    txtDep.Text = reader[8].ToString();
                    txtObs.Text = reader[9].ToString();
                    txtTermo.Text = reader[10].ToString();
                    txtUser.Text = reader[11].ToString();
                    txtNF.Text = reader[12].ToString();
                    mskEntrega.Text = reader[13].ToString();
                    mskDevolucao.Text = reader[14].ToString();
                    //novo = false;
                }
                else
                {
                    MessageBox.Show("Transferencia realizada com sucesso!");
                }

            }
            finally
            {
                cn.Close();
            }
        }
        // Button New
        private void tsbNew_Click(object sender, EventArgs e)
        {
            
            tsbNew.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tsbDelete.Enabled = false;

            tstName.Enabled = false;
            tsbBuscar.Enabled = false;

            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtFilial.Enabled = true;
            txtModelo.Enabled = true;
            txtMarca.Enabled = true;
            txtIMEI.Enabled = true;
            txtTelefone.Enabled = true;
            txtMemoria.Enabled = true;
            txtDep.Enabled = true;
            txtObs.Enabled = true;
            txtTermo.Enabled = true;
            txtUser.Enabled = true;
            txtNF.Enabled = true;
            mskEntrega.Enabled = true;
            mskDevolucao.Enabled = true;
            txtMat.Enabled = true;
            txtRG.Enabled = true;
            mskCPF.Enabled = true;
            novo = true;
        }

        // Button Cancel
        private void tsbCancel_Click(object sender, EventArgs e)
        {
            tsbNew.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = true;
            tsbDelete.Enabled = false;

            tstName.Enabled = false;
            tsbBuscar.Enabled = true;

            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtFilial.Enabled = true;
            txtModelo.Enabled = true;
            txtMarca.Enabled = true;
            txtIMEI.Enabled = true;
            txtTelefone.Enabled = true;
            txtMemoria.Enabled = true;
            txtDep.Enabled = true;
            txtObs.Enabled = true;
            txtTermo.Enabled = true;
            txtUser.Enabled = true;
            txtNF.Enabled = true;
            mskEntrega.Enabled = true;
            mskDevolucao.Enabled = true;
            txtMat.Enabled = true;
            txtRG.Enabled = true;
            mskCPF.Enabled = true;
            novo = false;

            txtId.Text = "";
            txtNome.Text = "";
            txtFilial.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtIMEI.Text = "";
            txtTelefone.Text = "";
            txtMemoria.Text = "";
            txtDep.Text = "";
            txtObs.Text = "";
            txtTermo.Text = "";
            txtUser.Text = "";
            txtNF.Text = "";
            mskEntrega.Text = "";
            mskDevolucao.Text = "";
            txtMat.Text = "";
            txtRG.Text = "";
            mskCPF.Text = "";
        }
        // Button Save
        private void tsbSave_Click(object sender, EventArgs e)
        {
            DateTime thisDay = DateTime.Today;
            //Criação de um novo cadastro
            if (novo)
            {
                var sql = "INSERT INTO Celulares (Nome,Filial,Mod_Celular,Marca,IMEI,N_Telefone,Quantidade_GB,Departamento,Observacao,Termo,Ultimo_dono,NF,Devolucao,MATRICULA,RG,CPF)"
                 + "Values('" + txtNome.Text + "', '" + txtFilial.Text + "', '"
                     + txtModelo.Text + "', '" + txtMarca.Text + "','"
                     + txtIMEI.Text + "', '" + txtTelefone.Text + "','"
                     + txtMemoria.Text + "', '"+ txtDep.Text +"','" + txtObs.Text + "','"
                     + txtTermo.Text + "','" + txtUser.Text + "', '" + txtNF.Text + "','" + mskDevolucao.Text+ "','" + txtMat.Text + "','" + txtRG.Text + "','" 
                     + mskCPF.Text + "')";

                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandText = sql;
                //SqlDataReader reader;
                cn.Open();

                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        //MessageBox.Show("Cadastro realizado com sucesso!" + thisDay.ToString("d"),"Confirmação");//data.ToString("hh:mm"));
                        MessageBox.Show("Cadastro realizado com sucesso!","Confirmação");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    cn.Close();
                }

            }
            // Aqui é feito a alteração do cadastro existente
            else
            {
                var sql = "UPDATE Celulares SET Nome='" + txtNome.Text +
                    "',filial = '" + txtFilial.Text + "',Mod_celular= '" + txtModelo.Text +
                    "' ,Marca= '" + txtMarca.Text +
                    "',IMEI= '" + txtIMEI.Text +
                    "',N_telefone='" + txtTelefone.Text + "', Quantidade_GB='" + txtMemoria.Text + "'" +
                    ",Departamento='" + txtDep.Text + "',Observacao='" + txtObs.Text + "',Termo='" + txtTermo.Text + "'" +
                    ",Ultimo_Dono='" + txtUser.Text + "',NF='" + txtNF.Text +"',Matricula='"+txtMat.Text+"',RG='"+txtRG.Text+"',CPF='"+mskCPF.Text+"' WHERE ID= '" + txtId.Text + "'";

                //Aqui é feito uma nova conexão
                SqlConnection cn = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandText = sql;
                //SqlDataReader reader;
                cn.Open();

                try
                {
                    var i = cmd.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("Atualização realizada com sucesso!" + thisDay, "Confirmação");
                    else
                    {
                        MessageBox.Show("Se caiu aqui porque deu merdaa !!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
                finally
                {
                    cn.Close();
                }
            }

            tsbNew.Enabled = true;
            tsbSave.Enabled = true;
            tsbCancel.Enabled = false;
            tsbDelete.Enabled = false;

            tstName.Enabled = true;
            tsbBuscar.Enabled = true;

            txtId.Enabled = false;
            txtNome.Enabled = true;
            txtFilial.Enabled = true;
            txtModelo.Enabled = true;
            txtMarca.Enabled = true;
            txtIMEI.Enabled = true;
            txtTelefone.Enabled = true;
            txtMemoria.Enabled = true;
            txtDep.Enabled = true;
            txtObs.Enabled = true;
            txtTermo.Enabled = true;
            txtUser.Enabled = true;
            txtNF.Enabled = true;
            mskEntrega.Enabled = true;
            mskDevolucao.Enabled = true;
            txtMat.Enabled = true;
            txtRG.Enabled = true;
            mskCPF.Enabled = true;

            txtId.Text = "";
            txtNome.Text = "";
            txtFilial.Text = "";
            txtModelo.Text = "";
            txtMarca.Text = "";
            txtIMEI.Text = "";
            txtTelefone.Text = "";
            txtMemoria.Text = "";
            txtDep.Text = "";
            txtObs.Text = "";
            txtTermo.Text = "";
            txtUser.Text = "";
            txtNF.Text = "";
            mskEntrega.Text = "";
            mskDevolucao.Text = "";
            txtMat.Text = "";
            txtRG.Text = "";
            mskCPF.Text = "";


        }

   
        
    }
}
