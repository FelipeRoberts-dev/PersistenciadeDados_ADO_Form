using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;

namespace ADO.form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSqlServe_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();

            sqlConnection.ConnectionString = "Data Source=localhost;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            sqlConnection.Open();

            MessageBox.Show("Abri Conexao com o SQL");

            sqlConnection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnListarSQL_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();

            string conection = @"Data Source=localhost;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog=Cliente01_";


            sqlConnection.ConnectionString = conection;
            sqlConnection.Open();

            SqlCommand comandosql = new SqlCommand();

            comandosql.CommandText = "SELECT * FROM Produtos";
            comandosql.Connection = sqlConnection;

            SqlDataReader lerquery = comandosql.ExecuteReader();

            while (lerquery.Read())
            {
                string nome = lerquery.IsDBNull(1) ? string.Empty :  lerquery.GetString(1);
                string cor = lerquery.IsDBNull(2) ? string.Empty :  lerquery.GetString(2);
                listProdutos.Items.Add($"{lerquery.GetInt32(0)}, {nome}, {cor}");
            }
       

            sqlConnection.Close();
        }

        private void btnListarDataSet_Click(object sender, EventArgs e)
        {
            string conection = @"Data Source=localhost;User ID=sa;Password=123;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False; Initial Catalog=Cliente01_";

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Produtos", conection);

            DataSet dataSet = new DataSet();

            da.Fill(dataSet);

            dataGridViewProdutos.DataSource = dataSet.Tables[0];

        }
    }
}