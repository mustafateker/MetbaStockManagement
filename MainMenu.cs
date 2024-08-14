using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MetbStockKontrol
{
    public partial class MainMenu : Form
    {
        private string userId;
        private string connectionString = "Server=DESKTOP-UTV9ITN" +
                                          ";Database=METBA_STOCK_TEST;" +
                                          "Integrated Security=True;";
        private string productConnString = "Server=DESKTOP-UTV9ITN" +
                                          ";Database=USERS;" +
                                          "Integrated Security=True;";
        

        public MainMenu(string userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            LoadProducts();
            dataGridView1.CellClick += DataGridView1_CellClick;
        }

        private void LoadProducts()
        {
            using (SqlConnection connection = new SqlConnection(productConnString))
            {
                try
                {
                    string tableName = "Products_"+userId;
                    string query = $"SELECT * FROM [{tableName}]";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                MessageBox.Show("Arama terimini giriniz.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(productConnString))
            {
                
                string tableName = "Products_" + userId;
                string query = $"SELECT * FROM [{tableName}] WHERE productName LIKE @ProductName OR barkod LIKE @Barkod OR productCode LIKE @ProductCode";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductName", "%" + SearchBox.Text + "%");
                command.Parameters.AddWithValue("@Barkod", "%" + SearchBox.Text + "%");
                command.Parameters.AddWithValue("@ProductCode", "%" + SearchBox.Text + "%");

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string productId = row.Cells["Id"].Value.ToString();

                ProductDetails productDetails = new ProductDetails(productId, userId);
                productDetails.Show();
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            using (AddProducts addProducts = new AddProducts(this, userId))
            {

                addProducts.ShowDialog();
            }

            LoadProducts(); 
        }
    }
}
