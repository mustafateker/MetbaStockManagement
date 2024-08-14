using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace MetbStockKontrol
{
    public partial class Form2 : Form
    {
        private string connectionString = "Server=DESKTOP-UTV9ITN;" +
                                      "Database=USERS;" +
                                      "Integrated Security=True;";
        private string mainConnectionString = "Server=DESKTOP-UTV9ITN;" +
                                      "Database=METBA_STOCK_TEST;" +
                                      "Integrated Security=True;";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = registerNameTextBox.Text;
            string surname = registerSurnameTextBox.Text;
            string username = registerUserNameTextBox.Text;
            string email = registerEmailTextBox.Text;
            string phoneNumber = registerPhoneNumberTextBox.Text;
            string password = registerParolaTextBox.Text;
            string passwordConfirm = registerParolaTekrarTextBox.Text;

            if (password != passwordConfirm)
            {
                MessageBox.Show("Parolalar eşleşmiyor!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var userIdd = Guid.NewGuid();
            string userId = userIdd.ToString();
            bool userStatus = false;

            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    
                    string newTableName = $"Products_{userId}";
                    string createTableQuery = $@"
                            CREATE TABLE [{newTableName}] (
                                Id NVARCHAR(50),
                                ProductType NVARCHAR(100),
                                Status NVARCHAR(50),
                                ProductCode NVARCHAR(50),
                                Barkod NVARCHAR(50),
                                Heavy FLOAT,
                                Width FLOAT,
                                Height FLOAT,
                                GTIN NVARCHAR(50),
                                GTIP NVARCHAR(50),
                                MPN NVARCHAR(50),
                                ProductName NVARCHAR(100),
                                Categorie NVARCHAR(100),
                                Stock INT,
                                CriticalStock INT,
                                Currency NVARCHAR(10),
                                KDV INT,
                                Brand NVARCHAR(50),
                                ListPrice FLOAT,
                                DiscountedPrice FLOAT
                            );";

                    using (SqlCommand createTableCommand = new SqlCommand(createTableQuery, conn))
                    {
                        createTableCommand.ExecuteNonQuery();
                    }
                }
                catch(Exception ex)
                {
                     MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }


            user regUser = new user
            {
                UserId1 = userId,
                Name1 = name,
                Surname1 = surname,
                UserName1 = username,
                Email1 = email,
                PhoneNumber1 = phoneNumber,
                Password1 = password,
                UserStatus1 = userStatus
            };

            //30D5D246381888F7

            using (SqlConnection connection = new SqlConnection(mainConnectionString))
            {
                try
                {
                    connection.Open();

                    string existUserQuery = "SELECT COUNT(*) FROM USERS WHERE Username = @Username;";
                    using (SqlCommand existUser = new SqlCommand(existUserQuery, connection))
                    {
                        existUser.Parameters.AddWithValue("@Username", username);
                        int existUserCount = (int)(existUser.ExecuteScalar() ?? 0);
                        if (existUserCount > 0)
                        {
                            MessageBox.Show("Bu kullanıcı adı daha önce alınmış. \n Lütfen başka bir Kullanıcı Adı giriniz.");
                        }
                        else
                        {
                            string query = "INSERT INTO USERS (Name, Surname, Username, Email, " +
                                           "PhoneNumber, Password, UserId, UserStatus) VALUES (@Name, @Surname, @Username, @Email, @PhoneNumber, @Password, @UserId, @UserStatus)";

                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@UserId", regUser.UserId1);
                                command.Parameters.AddWithValue("@Name", regUser.Name1);
                                command.Parameters.AddWithValue("@Surname", regUser.Surname1);
                                command.Parameters.AddWithValue("@Username", regUser.UserName1);
                                command.Parameters.AddWithValue("@Email", regUser.Email1);
                                command.Parameters.AddWithValue("@PhoneNumber", regUser.PhoneNumber1);
                                command.Parameters.AddWithValue("@Password", regUser.Password1);
                                command.Parameters.AddWithValue("@UserStatus", regUser.UserStatus1);
                                //288521BB39F9A2B8
                                int result = command.ExecuteNonQuery();

                                if (result > 0)
                                {
                                

                                    MessageBox.Show("Kayıt Başarılı ve ürün tablosu oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Activation formunu aç
                                    Activation activationForm = new Activation(userId);
                                    activationForm.ShowDialog();
                                    this.Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Kayıt Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void registerParolaTekrarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void kaydolTittle_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
