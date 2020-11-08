namespace POSSystemOOPFinals
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lwdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.adminLogin = new System.Windows.Forms.RadioButton();
            this.closeWindow = new System.Windows.Forms.PictureBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bebas Neue", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(0, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "ARTEM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lwdateTimePicker);
            this.panel1.Controls.Add(this.adminLogin);
            this.panel1.Controls.Add(this.closeWindow);
            this.panel1.Controls.Add(this.loginUsername);
            this.panel1.Controls.Add(this.loginPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(348, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 337);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lwdateTimePicker
            // 
            this.lwdateTimePicker.CalendarFont = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwdateTimePicker.Font = new System.Drawing.Font("Bebas Neue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwdateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.lwdateTimePicker.Location = new System.Drawing.Point(4, 4);
            this.lwdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.lwdateTimePicker.Name = "lwdateTimePicker";
            this.lwdateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lwdateTimePicker.RightToLeftLayout = true;
            this.lwdateTimePicker.Size = new System.Drawing.Size(71, 22);
            this.lwdateTimePicker.TabIndex = 13;
            // 
            // adminLogin
            // 
            this.adminLogin.AutoSize = true;
            this.adminLogin.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.adminLogin.Location = new System.Drawing.Point(65, 260);
            this.adminLogin.Margin = new System.Windows.Forms.Padding(2);
            this.adminLogin.Name = "adminLogin";
            this.adminLogin.Size = new System.Drawing.Size(120, 18);
            this.adminLogin.TabIndex = 12;
            this.adminLogin.TabStop = true;
            this.adminLogin.Text = "Administrator Login";
            this.toolTip1.SetToolTip(this.adminLogin, "[?] Mark this if your trying to login as an administrator");
            this.adminLogin.UseVisualStyleBackColor = true;
            this.adminLogin.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // closeWindow
            // 
            this.closeWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeWindow.BackgroundImage")));
            this.closeWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeWindow.Location = new System.Drawing.Point(210, 4);
            this.closeWindow.Margin = new System.Windows.Forms.Padding(2);
            this.closeWindow.Name = "closeWindow";
            this.closeWindow.Size = new System.Drawing.Size(30, 32);
            this.closeWindow.TabIndex = 12;
            this.closeWindow.TabStop = false;
            this.closeWindow.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // loginUsername
            // 
            this.loginUsername.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.ForeColor = System.Drawing.Color.White;
            this.loginUsername.Location = new System.Drawing.Point(27, 179);
            this.loginUsername.Margin = new System.Windows.Forms.Padding(2);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(190, 21);
            this.loginUsername.TabIndex = 7;
            this.loginUsername.TextChanged += new System.EventHandler(this.loginUsername_TextChanged);
            this.loginUsername.Enter += new System.EventHandler(this.loginUsername_Enter);
            this.loginUsername.Leave += new System.EventHandler(this.loginUsername_Leave);
            // 
            // loginPassword
            // 
            this.loginPassword.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.ForeColor = System.Drawing.Color.White;
            this.loginPassword.Location = new System.Drawing.Point(27, 228);
            this.loginPassword.Margin = new System.Windows.Forms.Padding(2);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(190, 21);
            this.loginPassword.TabIndex = 8;
            this.loginPassword.TextChanged += new System.EventHandler(this.loginPassword_TextChanged);
            this.loginPassword.Enter += new System.EventHandler(this.loginPassword_Enter);
            this.loginPassword.Leave += new System.EventHandler(this.loginPassword_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label5.Location = new System.Drawing.Point(24, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bebas Neue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label4.Location = new System.Drawing.Point(24, 157);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Username";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // loginButton
            // 
            this.loginButton.AccessibleName = "loginButton";
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.Color.PaleGreen;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loginButton.Font = new System.Drawing.Font("Bebas Neue", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginButton.Location = new System.Drawing.Point(81, 286);
            this.loginButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(95, 27);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "      Login     ";
            this.loginButton.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(81, 57);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(81, 78);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(110, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 38);
            this.panel2.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bebas Neue", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(1, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Information System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(70, 109);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 174);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(101, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Agency FB", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(70, 307);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 50);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = "\"The wildlife and its habitat cannot speak.  So We Must and We Will..\" -Theodore " +
    "Roosevelt ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(5, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 57);
            this.textBox2.TabIndex = 17;
            this.textBox2.Text = "Automated and Real-Time Endangered animal Monitoring through Information Systems";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(6, 298);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 60);
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWindow";
            this.Load += new System.EventHandler(this.LoginWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeWindow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label loginButton;
        private System.Windows.Forms.TextBox loginPassword;
        private System.Windows.Forms.TextBox loginUsername;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox closeWindow;
        private System.Windows.Forms.RadioButton adminLogin;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DateTimePicker lwdateTimePicker;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}