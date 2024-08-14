using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MetbStockKontrol
{
    public partial class AddProducts : Form
    {

        private string userId;
        public AddProducts(MainMenu mainMenu, string userId)
        {
            InitializeComponent();
            this.userId = userId;   
        }

        private void KaydetKapatButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int id = rnd.Next(10000000, 99999999);
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

            string connectionString = "Server=DESKTOP-UTV9ITN;" +
                                      "Database=USERS;" +
                                      "Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string tableName = "Products_" + userId;
                    connection.Open();
                    string query = $"INSERT INTO [{tableName}] (Id, ProductType, Status, ProductCode, Barkod, Heavy, Width, Height, GTIN, GTIP, MPN, ProductName, Categorie, Stock, CriticalStock, Currency, KDV, Brand, ListPrice, DiscountedPrice) " +
                                   "VALUES (@id, @productType, @status, @productCode, @barkod, @heavy, @width, @height, @gtin, @gtip, @mpn, @productName, @categorie, @stock, @criticalStock, @currency, @KDV, @brand, @listPrice, @discountedPrice)";

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

                    MessageBox.Show("Ürün başarıyla eklendi!");
                    this.Hide();
                   
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün ekleme başarısız: " + ex.Message);
                }
            }
        }
    }
}
