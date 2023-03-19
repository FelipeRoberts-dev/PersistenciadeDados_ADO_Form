using Microsoft.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace CRUDADO.form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string connectionsqlserver = @"Data Source=localhost;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog=Cliente01_";

        void ListarTudoSqlServer()
        {
        
            

            SqlDataAdapter da = new SqlDataAdapter("select * from Produtos", connectionsqlserver);
            DataSet dataSet = new DataSet();

            da.Fill(dataSet);

            dataGridProdutosCrud.DataSource = dataSet.Tables[0];

        }


        private void button5_Click(object sender, EventArgs e)
        {
            ListarTudoSqlServer(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = $"$select * from Produtos where nome like '%{textBox1.Text}%'";


            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connectionsqlserver);
            DataSet dataSet = new DataSet();


            dataAdapter.Fill(dataSet);

            dataGridProdutosCrud.DataSource = dataSet.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionsqlserver);

            SqlCommand comand = new SqlCommand();

            comand.Connection = connection;
            comand.CommandType = CommandType.Text;

            comand.CommandText = "INSERT INTO Produtos (Nome, Cor) values (@Nome, @Cor)";
            comand.Parameters.AddWithValue("@Nome", textBox2.Text);
            comand.Parameters.AddWithValue("@Cor", textBox3.Text);

            SqlTransaction transaction = null;

            try
            {
                connection.Open();

                transaction = connection.BeginTransaction();

                //Define fluxo de transa��o para os comandos de dele��o.
                comand.Transaction = transaction;


                //Executa a query de altera��o do Produto.
                comand.ExecuteNonQuery();


                //Confirma a dele��o dos registros.
                transaction.Commit();


                ListarTudoSqlServer();

                MessageBox.Show("Inclu�do com sucesso");
            }
            catch (Exception ex)
            {
                //Rollback caso der erro na transa��o

                transaction?.Rollback();
                MessageBox.Show("Ocorreu erro ao inclu�r o registro: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionsqlserver);

            SqlCommand comand = new SqlCommand();

            comand.Connection = connection;
            comand.CommandType = CommandType.Text;

            comand.CommandText = "UPDATE  Produtos SET Nome = @Nome, Cor = @Cor WHERE Id = @Id";
            comand.Parameters.AddWithValue("@Nome", textBox2.Text);
            comand.Parameters.AddWithValue("@Cor", textBox3.Text);
            comand.Parameters.AddWithValue("@Id", textBox1.Text);


            SqlTransaction transaction = null;

            try
            {
                connection.Open();

                transaction = connection.BeginTransaction();

                //Define fluxo de transa��o para os comandos de dele��o.
                comand.Transaction = transaction;


                //Executa a query de altera��o do Produto.
                comand.ExecuteNonQuery();


                //Confirma a dele��o dos registros.
                transaction.Commit();


                ListarTudoSqlServer();

                MessageBox.Show("Alterado com sucesso");
            }
            catch (Exception ex)
            {
                //Rollback caso der erro na transa��o

                transaction?.Rollback();
                MessageBox.Show("Ocorreu erro ao alterar o registro: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionsqlserver);

            SqlCommand comandProduto = new SqlCommand();
            SqlCommand comandEstoque = new SqlCommand();

            comandProduto.Connection = connection;
            comandProduto.CommandType = CommandType.Text;
            comandProduto.CommandText = "DELETE FROM  Produtos WHERE Id = @Id";
            comandProduto.Parameters.AddWithValue("@Id", textBox1.Text);

            //FK estoque
            comandEstoque.Connection = connection;
            comandEstoque.CommandType = CommandType.Text;
            comandEstoque.CommandText = "DELETE FROM Estoque WHERE Id = @Id";
            comandEstoque.Parameters.AddWithValue("@Id", textBox1.Text);


            SqlTransaction transaction = null;

            try {
                connection.Open();

                transaction = connection.BeginTransaction();

                //Define fluxo de transa��o para os comandos de dele��o.
                comandProduto.Transaction = transaction;
                comandEstoque.Transaction = transaction;

                //Executa primeiro a dele��o do estoque que est� amarrado a um produto.
                comandEstoque.ExecuteNonQuery();

                // Executa dele��o da tabela forte produtos.
                comandProduto.ExecuteNonQuery();


                //Confirma a dele��o dos registros.
                transaction.Commit();


                ListarTudoSqlServer();

                MessageBox.Show("Deletado com sucesso");
            }
            catch(Exception ex)
            {
                //Rollback caso der erro na transa��o

                transaction?.Rollback();
                MessageBox.Show("Ocorreu erro ao excluir o registro: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }

           
        }
    }
}