using System.Drawing.Text;

namespace MetbStockKontrol
{
    partial class LoginScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginUserNameTextBox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.goToRegistrationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginUserNameTextBox
            // 
            this.loginUserNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUserNameTextBox.Location = new System.Drawing.Point(132, 218);
            this.loginUserNameTextBox.Name = "loginUserNameTextBox";
            this.loginUserNameTextBox.Size = new System.Drawing.Size(337, 28);
            this.loginUserNameTextBox.TabIndex = 1;
            this.loginUserNameTextBox.Text = "Kullanıcı Adı";
            // 
            // loginPasswordTextBox
            // 
            this.loginPasswordTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTextBox.Location = new System.Drawing.Point(132, 253);
            this.loginPasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.loginPasswordTextBox.Name = "loginPasswordTextBox";
            this.loginPasswordTextBox.PasswordChar = '*';
            this.loginPasswordTextBox.ShortcutsEnabled = false;
            this.loginPasswordTextBox.Size = new System.Drawing.Size(337, 28);
            this.loginPasswordTextBox.TabIndex = 7;
            this.loginPasswordTextBox.Text = "Parola";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 151);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox1.Size = new System.Drawing.Size(337, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "METBA GIRIS ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(130, 299);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(339, 47);
            this.loginButton.TabIndex = 8;
            this.loginButton.Text = "Giriş";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 516);
            this.panel1.TabIndex = 9;
            // 
            // goToRegistrationButton
            // 
            this.goToRegistrationButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToRegistrationButton.Location = new System.Drawing.Point(130, 354);
            this.goToRegistrationButton.Margin = new System.Windows.Forms.Padding(4);
            this.goToRegistrationButton.Name = "goToRegistrationButton";
            this.goToRegistrationButton.Size = new System.Drawing.Size(339, 47);
            this.goToRegistrationButton.TabIndex = 9;
            this.goToRegistrationButton.Text = "Kaydol";
            this.goToRegistrationButton.UseVisualStyleBackColor = true;
            this.goToRegistrationButton.Click += new System.EventHandler(this.goToRegistrationButton_Click);
            // 
            // LoginScreen
            // 
            this.ClientSize = new System.Drawing.Size(635, 540);
            this.Controls.Add(this.goToRegistrationButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginPasswordTextBox);
            this.Controls.Add(this.loginUserNameTextBox);
            this.Name = "LoginScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox loginUserNameTextBox;
        private System.Windows.Forms.TextBox loginPasswordTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button goToRegistrationButton;
    }
}