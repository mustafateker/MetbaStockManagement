namespace MetbStockKontrol
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.registerParolaTekrarTextBox = new System.Windows.Forms.TextBox();
            this.registerParolaTextBox = new System.Windows.Forms.TextBox();
            this.registerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.registerEmailTextBox = new System.Windows.Forms.TextBox();
            this.registerUserNameTextBox = new System.Windows.Forms.TextBox();
            this.registerSurnameTextBox = new System.Windows.Forms.TextBox();
            this.registerNameTextBox = new System.Windows.Forms.TextBox();
            this.kaydolTittle = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.registerParolaTekrarTextBox);
            this.panel1.Controls.Add(this.registerParolaTextBox);
            this.panel1.Controls.Add(this.registerPhoneNumberTextBox);
            this.panel1.Controls.Add(this.registerEmailTextBox);
            this.panel1.Controls.Add(this.registerUserNameTextBox);
            this.panel1.Controls.Add(this.registerSurnameTextBox);
            this.panel1.Controls.Add(this.registerNameTextBox);
            this.panel1.Controls.Add(this.kaydolTittle);
            this.panel1.Location = new System.Drawing.Point(16, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 511);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(132, 394);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(339, 47);
            this.button1.TabIndex = 8;
            this.button1.Text = "Kaydol";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registerParolaTekrarTextBox
            // 
            this.registerParolaTekrarTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerParolaTekrarTextBox.Location = new System.Drawing.Point(132, 342);
            this.registerParolaTekrarTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerParolaTekrarTextBox.Name = "registerParolaTekrarTextBox";
            this.registerParolaTekrarTextBox.ShortcutsEnabled = false;
            this.registerParolaTekrarTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerParolaTekrarTextBox.TabIndex = 7;
            this.registerParolaTekrarTextBox.Text = "Parola Tekrar";
            // 
            // registerParolaTextBox
            // 
            this.registerParolaTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerParolaTextBox.Location = new System.Drawing.Point(132, 305);
            this.registerParolaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerParolaTextBox.Name = "registerParolaTextBox";
            this.registerParolaTextBox.ShortcutsEnabled = false;
            this.registerParolaTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerParolaTextBox.TabIndex = 6;
            this.registerParolaTextBox.Text = "Parola";
            // 
            // registerPhoneNumberTextBox
            // 
            this.registerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerPhoneNumberTextBox.Location = new System.Drawing.Point(132, 268);
            this.registerPhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerPhoneNumberTextBox.Name = "registerPhoneNumberTextBox";
            this.registerPhoneNumberTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerPhoneNumberTextBox.TabIndex = 5;
            this.registerPhoneNumberTextBox.Text = "Telefon Numarası";
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerEmailTextBox.Location = new System.Drawing.Point(132, 231);
            this.registerEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerEmailTextBox.TabIndex = 4;
            this.registerEmailTextBox.Text = "E-mail";
            // 
            // registerUserNameTextBox
            // 
            this.registerUserNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerUserNameTextBox.Location = new System.Drawing.Point(132, 194);
            this.registerUserNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerUserNameTextBox.Name = "registerUserNameTextBox";
            this.registerUserNameTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerUserNameTextBox.TabIndex = 3;
            this.registerUserNameTextBox.Text = "Kullanıcı Adı";
            // 
            // registerSurnameTextBox
            // 
            this.registerSurnameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerSurnameTextBox.Location = new System.Drawing.Point(132, 158);
            this.registerSurnameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerSurnameTextBox.Name = "registerSurnameTextBox";
            this.registerSurnameTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerSurnameTextBox.TabIndex = 2;
            this.registerSurnameTextBox.Text = "Soyad";
            // 
            // registerNameTextBox
            // 
            this.registerNameTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerNameTextBox.Location = new System.Drawing.Point(132, 121);
            this.registerNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.registerNameTextBox.Name = "registerNameTextBox";
            this.registerNameTextBox.Size = new System.Drawing.Size(337, 28);
            this.registerNameTextBox.TabIndex = 1;
            this.registerNameTextBox.Text = "Ad";
            this.registerNameTextBox.TextChanged += new System.EventHandler(this.registerNameTextBox_TextChanged);
            // 
            // kaydolTittle
            // 
            this.kaydolTittle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydolTittle.Location = new System.Drawing.Point(132, 55);
            this.kaydolTittle.Margin = new System.Windows.Forms.Padding(4);
            this.kaydolTittle.Name = "kaydolTittle";
            this.kaydolTittle.ReadOnly = true;
            this.kaydolTittle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.kaydolTittle.Size = new System.Drawing.Size(337, 38);
            this.kaydolTittle.TabIndex = 0;
            this.kaydolTittle.TabStop = false;
            this.kaydolTittle.Text = "METBA KAYDOL";
            this.kaydolTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kaydolTittle.TextChanged += new System.EventHandler(this.kaydolTittle_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 540);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Kaydol";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox kaydolTittle;
        private System.Windows.Forms.TextBox registerNameTextBox;
        private System.Windows.Forms.TextBox registerSurnameTextBox;
        private System.Windows.Forms.TextBox registerUserNameTextBox;
        private System.Windows.Forms.TextBox registerEmailTextBox;
        private System.Windows.Forms.TextBox registerParolaTekrarTextBox;
        private System.Windows.Forms.TextBox registerParolaTextBox;
        private System.Windows.Forms.TextBox registerPhoneNumberTextBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}