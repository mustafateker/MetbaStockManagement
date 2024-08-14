using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MetbStockKontrol
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = loginUserNameTextBox.Text;
            string password = loginPasswordTextBox.Text;

            string connectionString = "Server=DESKTOP-UTV9ITN;Database=METBA_STOCK_TEST;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string loginQuery = "SELECT UserID, UserStatus FROM USERS WHERE Username = @Username AND Password = @Password;";
                    using (SqlCommand loginCommand = new SqlCommand(loginQuery, conn))
                    {
                        loginCommand.Parameters.AddWithValue("@Username", username);
                        loginCommand.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = loginCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string userId = reader.IsDBNull(0) ? null : reader.GetString(0).Trim();
                                string userStatus = reader.IsDBNull(1) ? null : reader.GetString(1).Trim();

                                if (userStatus == "1")
                                {
                                 
                                    MainMenu mainMenu = new MainMenu(userId);
                                    this.Hide();
                                    mainMenu.ShowDialog();
                                }
                                else
                                {
                                    Activation activation = new Activation(userId);
                                    this.Hide();
                                    activation.ShowDialog();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void goToRegistrationButton_Click(object sender, EventArgs e)
        {
            Form2 registrationForm = new Form2();
            registrationForm.ShowDialog();
        }
    }
}
