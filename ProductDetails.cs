using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MetbStockKontrol
{
    public partial class ProductDetails : Form
    {
        private string productId;
        private string userId;
        private string connectionString = "Server=DESKTOP-UTV9ITN;" +
                                          "Database=USERS;" +
                                          "Integrated Security=True;";

        public ProductDetails(string productId, string userId)
        {
            InitializeComponent();
            this.productId = productId;
            this.userId = userId;
            LoadProductDetails();
        }

        private void LoadProductDetails()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string tableName = "Products_" + userId;
                string query = $"SELECT * FROM [{tableName}] WHERE Id = @ProductId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ProductId", productId);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    
                    IDTextBox.Text = reader["Id"].ToString();
                    
                    UrunTipiComboBox.Text = reader["ProductType"].ToString();
                    DurumComboBox.Text = reader["Status"].ToString();
                    StokKoduTextBox.Text = reader["ProductCode"].ToString();
                    BarkodTextBox.Text = reader["Barkod"].ToString();
                    AgirlikTextBox.Text = reader["Heavy"].ToString();
                    GenislikTextBox.Text = reader["Width"].ToString();
                    YukseklikTextBox.Text = reader["Height"].ToString();
                    GTINTextBox.Text = reader["GTIN"].ToString();
                    GTIPTextBox.Text = reader["GTIP"].ToString();
                    MPNTextBox.Text = reader["MPN"].ToString();
                    UrunAdiTextBox.Text = reader["ProductName"].ToString();
                    KategoriComboBox.Text = reader["Categorie"].ToString();
                    AdetTextBox.Text = reader["Stock"].ToString();
                    KritikStokTextBox.Text = reader["CriticalStock"].ToString();
                    ParaBirimiComboBox.Text = reader["Currency"].ToString();
                    KDVComboBox.Text = reader["KDV"].ToString();
                    MarkaComboBox.Text = reader["Brand"].ToString();
                    ListeFiyatiTextBox.Text = reader["ListPrice"].ToString();
                    SatisFiyatiTextBox.Text = reader["DiscountedPrice"].ToString();

                    
                   
                }
            }
        }

        private void KaydetKapatButton_Click(object sender, EventArgs e)
        {
            int id;
            int.TryParse(IDTextBox.Text, out id);
            string productType = UrunTipiComboBox.Text;
            string status = DurumComboBox.Text;
            string productCode = StokKoduTextBox.Text;
            string barkod = BarkodTextBox.Text;
            string productName = UrunAdiTextBox.Text;
            string categorie = KategoriComboBox.Text;
            string brand = MarkaComboBox.Text;
            int stock;

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(barkod) ||
                string.IsNullOrWhiteSpace(productCode) || !int.TryParse(AdetTextBox.Text, out stock) ||
                string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(categorie) ||
                string.IsNullOrWhiteSpace(status) || string.IsNullOrWhiteSpace(productType))
            {
                MessageBox.Show("Zorunlu alanları doldurunuz: Ürün adı, barkod, stok kodu, adet, marka, kategori, durum ve ürün tipi.");
                return;
            }

            float heavy;
            float width;
            float height;
            string gtin = GTINTextBox.Text;
            string gtip = GTIPTextBox.Text;
            string mpn = MPNTextBox.Text;
            string currency = ParaBirimiComboBox.Text;
            int criticalStock;
            int KDV;
            float listPrice;
            float discountedPrice;

            float.TryParse(AgirlikTextBox.Text, out heavy);
            float.TryParse(GenislikTextBox.Text, out width);
            float.TryParse(YukseklikTextBox.Text, out height);
            int.TryParse(KritikStokTextBox.Text, out criticalStock);
            int.TryParse(KDVComboBox.Text, out KDV);
            float.TryParse(ListeFiyatiTextBox.Text, out listPrice);
            float.TryParse(SatisFiyatiTextBox.Text, out discountedPrice);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string tableName = "Products_" + userId;
                    connection.Open();
                    string query = $"UPDATE [{tableName}] SET ProductType = @productType, Status = @status, ProductCode = @productCode, Barkod = @barkod, " +
                                   "Heavy = @heavy, Width = @width, Height = @height, GTIN = @gtin, GTIP = @gtip, MPN = @mpn, " +
                                   "ProductName = @productName, Categorie = @categorie, Stock = @stock, CriticalStock = @criticalStock, Currency = @currency, " +
                                   "KDV = @KDV, Brand = @brand, ListPrice = @listPrice, DiscountedPrice = @discountedPrice " +
                                   "WHERE Id = @id";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        command.Parameters.AddWithValue("@productType", productType);
                        command.Parameters.AddWithValue("@status", status);
                        command.Parameters.AddWithValue("@productCode", productCode);
                        command.Parameters.AddWithValue("@barkod", barkod);
                        command.Parameters.AddWithValue("@heavy", (object)heavy ?? DBNull.Value);
                        command.Parameters.AddWithValue("@width", (object)width ?? DBNull.Value);
                        command.Parameters.AddWithValue("@height", (object)height ?? DBNull.Value);
                        command.Parameters.AddWithValue("@gtin", (object)gtin ?? DBNull.Value);
                        command.Parameters.AddWithValue("@gtip", (object)gtip ?? DBNull.Value);
                        command.Parameters.AddWithValue("@mpn", (object)mpn ?? DBNull.Value);
                        command.Parameters.AddWithValue("@productName", productName);
                        command.Parameters.AddWithValue("@categorie", categorie);
                        command.Parameters.AddWithValue("@stock", stock);
                        command.Parameters.AddWithValue("@criticalStock", (object)criticalStock ?? DBNull.Value);
                        command.Parameters.AddWithValue("@currency", (object)currency ?? DBNull.Value);
                        command.Parameters.AddWithValue("@KDV", (object)KDV ?? DBNull.Value);
                        command.Parameters.AddWithValue("@brand", brand);
                        command.Parameters.AddWithValue("@listPrice", (object)listPrice ?? DBNull.Value);
                        command.Parameters.AddWithValue("@discountedPrice", (object)discountedPrice ?? DBNull.Value);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ürün başarıyla güncellendi!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün güncelleme başarısız: " + ex.Message);
                }
            }
        }

        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    //AA5B 8822 5A45 54AD
                    //9C5D C001 4768 71EA
                    DialogResult result = MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz?", "Ürünü Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        string tableName = "Products_" + userId;
                        connection.Open();
                        string query = $"DELETE FROM [{tableName}] WHERE Id = @id";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@id", userId);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Ürün başarıyla silindi!");
                            }
                            else
                            {
                                MessageBox.Show("Silinecek ürün bulunamadı.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Silme işlemi iptal edildi.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün silme başarısız: " + ex.Message);
                }
            }

        }
    }
}