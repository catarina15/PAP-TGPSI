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

namespace Software_DCMECA
{
    public partial class stock : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=dcmeca;Integrated Security=True";

        public stock()
        {
            InitializeComponent();
        }

        private void CarregarDados()
        {
            using (SqlConnection ligacao = new SqlConnection(connectionString))
            {
                ligacao.Open();

                string bd = "SELECT Cod_material, Nome_material, Quantidade_material FROM material";

                using (SqlDataAdapter adapter = new SqlDataAdapter(bd, ligacao))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
            }

            /*try
                {
                    using (SqlConnection ligacao = new SqlConnection(connectionString))
                    {
                        ligacao.Open();

                        string bd = "SELECT Cod_material, Nome_material, Quantidade_material FROM material";

                        using (SqlDataAdapter adapter = new SqlDataAdapter(bd, ligacao))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    StringBuilder errorMessages = new StringBuilder();
                    for (int i = 0; i < ex.Errors.Count; i++)
                    {
                        errorMessages.Append($"Index #{i} \n" +
                                             $"Message: {ex.Errors[i].Message}\n");
                    }
                    MessageBox.Show($"Erro ao carregar dados: {errorMessages.ToString()}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao carregar dados: {ex.Message}");
                }*/
          

        }

        private void stock_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void stock_Load_1(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form2 Variavel = new Form2();
            Variavel.Show();
            this.Hide();
        }
    }
}


