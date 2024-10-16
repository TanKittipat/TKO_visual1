namespace MisProject
{
    partial class SignUp
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
            username = new TextBox();
            userEmail = new TextBox();
            userPassword = new TextBox();
            rolesSelect = new ComboBox();
            confirmPwd = new TextBox();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnRegister = new Button();
            btnHome = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(291, 127);
            username.Name = "username";
            username.Size = new Size(218, 30);
            username.TabIndex = 11;
            username.TextChanged += username_TextChanged;
            // 
            // userEmail
            // 
            userEmail.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userEmail.Location = new Point(291, 170);
            userEmail.Name = "userEmail";
            userEmail.Size = new Size(218, 30);
            userEmail.TabIndex = 12;
            userEmail.TextChanged += userEmail_TextChanged;
            // 
            // userPassword
            // 
            userPassword.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPassword.Location = new Point(291, 213);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(218, 30);
            userPassword.TabIndex = 13;
            userPassword.TextChanged += userPassword_TextChanged;
            // 
            // rolesSelect
            // 
            rolesSelect.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rolesSelect.FormattingEnabled = true;
            rolesSelect.Location = new Point(291, 299);
            rolesSelect.Name = "rolesSelect";
            rolesSelect.Size = new Size(218, 30);
            rolesSelect.TabIndex = 14;
            rolesSelect.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // confirmPwd
            // 
            confirmPwd.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            confirmPwd.Location = new Point(291, 256);
            confirmPwd.Name = "confirmPwd";
            confirmPwd.Size = new Size(218, 30);
            confirmPwd.TabIndex = 15;
            confirmPwd.TextChanged += confirmPwd_TextChanged;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(128, 128, 255);
            linkLabel1.Location = new Point(341, 342);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(121, 22);
            linkLabel1.TabIndex = 16;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 23);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 17;
            label1.Text = "Sign-up Page";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(191, 127);
            label6.Name = "label6";
            label6.Size = new Size(74, 26);
            label6.TabIndex = 18;
            label6.Text = "username :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(191, 256);
            label2.Name = "label2";
            label2.Size = new Size(88, 26);
            label2.TabIndex = 19;
            label2.Text = "confirm pwd :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(191, 213);
            label3.Name = "label3";
            label3.Size = new Size(73, 26);
            label3.TabIndex = 20;
            label3.Text = "password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(191, 170);
            label4.Name = "label4";
            label4.Size = new Size(49, 26);
            label4.TabIndex = 21;
            label4.Text = "email :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(191, 299);
            label5.Name = "label5";
            label5.Size = new Size(66, 26);
            label5.TabIndex = 22;
            label5.Text = "user role :";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Green;
            btnRegister.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(403, 389);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(120, 40);
            btnRegister.TabIndex = 24;
            btnRegister.Text = "Sign-up";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkGray;
            btnHome.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(277, 389);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(120, 40);
            btnHome.TabIndex = 23;
            btnHome.Text = "Return Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnHome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(linkLabel1);
            Controls.Add(confirmPwd);
            Controls.Add(rolesSelect);
            Controls.Add(userPassword);
            Controls.Add(userEmail);
            Controls.Add(username);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox userEmail;
        private TextBox userPassword;
        private ComboBox rolesSelect;
        private TextBox confirmPwd;
        private LinkLabel linkLabel1;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnRegister;
        private Button btnHome;
    }
}