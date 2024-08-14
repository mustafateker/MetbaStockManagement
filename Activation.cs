using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MetbStockKontrol
{
    public partial class Activation : Form
    {
        private string userId;

        public Activation(string userId)
        {
            InitializeComponent();
            InitializeTextBoxes();
            this.userId = userId;
        }

        private void InitializeTextBoxes()
        {
            WriteCodeTextBox1.MaxLength = 4;
            WriteCodeTextBox2.MaxLength = 4;
            WriteCodeTextBox3.MaxLength = 4;
            WriteCodeTextBox4.MaxLength = 4;

            WriteCodeTextBox1.TextChanged += new EventHandler(TextBox_TextChanged);
            WriteCodeTextBox2.TextChanged += new EventHandler(TextBox_TextChanged);
            WriteCodeTextBox3.TextChanged += new EventHandler(TextBox_TextChanged);
            WriteCodeTextBox4.TextChanged += new EventHandler(TextBox_TextChanged);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox currentTextBox = sender as TextBox;
            if (currentTextBox.Text.Length == 4)
            {
                SelectNextTextBox(currentTextBox);
            }
        }

        private void SelectNextTextBox(TextBox currentTextBox)
        {
            if (currentTextBox == WriteCodeTextBox1)
            {
                WriteCodeTextBox2.Focus();
            }
            else if (currentTextBox == WriteCodeTextBox2)
            {
                WriteCodeTextBox3.Focus();
            }
            else if (currentTextBox == WriteCodeTextBox3)
            {
                WriteCodeTextBox4.Focus();
            }
            else if (currentTextBox == WriteCodeTextBox4)
            {
                string activationCode = WriteCodeTextBox1.Text + WriteCodeTextBox2.Text + WriteCodeTextBox3.Text + WriteCodeTextBox4.Text;
                
            }
        }

        private void activationButton_Click(object sender, EventArgs e)
        {
            string activationCode = WriteCodeTextBox1.Text + WriteCodeTextBox2.Text + WriteCodeTextBox3.Text + WriteCodeTextBox4.Text;
            string userName = usernameTextBox.Text;

            string connectionString = "Server=DESKTOP-UTV9ITN;" +
                                      "Database=METBA_STOCK_TEST;" +
                                      "Integrated Security=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    
                    string selectQuery = "SELECT COUNT(*) FROM ActivationCodes WHERE Activation_Code = @ActivationCode AND status = 0";
                    using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
                    {
                        selectCommand.Parameters.AddWithValue("@ActivationCode", activationCode);
                        int count = (int)(selectCommand.ExecuteScalar() ?? 0);

                        if (count == 0)
                        {
                            MessageBox.Show("Aktivasyon kodu bulunamadı veya zaten kullanılmış.");
                            return;
                        }
                    }// 2ABA 2B49 7697 DE9C

                    
                    string userCheckQuery = "SELECT COUNT(*) FROM USERS WHERE Username = @Username";
                    using (SqlCommand userCheckCommand = new SqlCommand(userCheckQuery, connection))
                    {
                        
                        userCheckCommand.Parameters.AddWithValue("@Username", userName);
                        int userCount = (int)(userCheckCommand.ExecuteScalar() ?? 0);

                        if (userCount == 0)
                        {
                            MessageBox.Show("Kullanıcı adı bulunamadı.");
                            return;
                        }
                    }

                    
                    string updateUserStatusQuery = "UPDATE USERS SET UserStatus = 1 WHERE Username = @Username";
                    using (SqlCommand updateUserStatusCommand = new SqlCommand(updateUserStatusQuery, connection))
                    {
                        updateUserStatusCommand.Parameters.AddWithValue("@Username", userName);
                        int rowsAffected = updateUserStatusCommand.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User Status Güncellendi!");
                        }
                        else
                        {
                            MessageBox.Show("User Status güncelleme başarısız! Hata Oluştu");
                        }
                    }

                    
                    string updateQuery = "UPDATE ActivationCodes SET status = 1, Activation_Date = @ActivationDate WHERE Activation_Code = @ActivationCode AND status = 0";
                    using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue("@ActivationDate", DateTime.Now);
                        updateCommand.Parameters.AddWithValue("@ActivationCode", activationCode);
                        int rowsAffected = updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Aktivasyon başarılı.");
                            MainMenu mainMenu = new MainMenu(userId);
                            mainMenu.ShowDialog();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Aktivasyon başarısız oldu.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
