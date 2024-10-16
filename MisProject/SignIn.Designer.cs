namespace MisProject
{
    partial class SignIn
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
            btnLogin = new Button();
            btnHome = new Button();
            label3 = new Label();
            label6 = new Label();
            label1 = new Label();
            userPassword = new TextBox();
            username = new TextBox();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Green;
            btnLogin.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(403, 378);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(120, 40);
            btnLogin.TabIndex = 38;
            btnLogin.Text = "Sign-in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnHome
            // 
            btnHome.BackColor = Color.DarkGray;
            btnHome.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Location = new Point(277, 378);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(120, 40);
            btnHome.TabIndex = 37;
            btnHome.Text = "Return Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(201, 244);
            label3.Name = "label3";
            label3.Size = new Size(73, 26);
            label3.TabIndex = 34;
            label3.Text = "password :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Cordia New", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(201, 199);
            label6.Name = "label6";
            label6.Size = new Size(74, 26);
            label6.TabIndex = 32;
            label6.Text = "username :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(290, 55);
            label1.Name = "label1";
            label1.Size = new Size(220, 45);
            label1.TabIndex = 31;
            label1.Text = "Sign-up Page";
            // 
            // userPassword
            // 
            userPassword.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userPassword.Location = new Point(291, 244);
            userPassword.Name = "userPassword";
            userPassword.Size = new Size(218, 30);
            userPassword.TabIndex = 27;
            userPassword.TextChanged += userPassword_TextChanged;
            // 
            // username
            // 
            username.Font = new Font("Cordia New", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(291, 199);
            username.Name = "username";
            username.Size = new Size(218, 30);
            username.TabIndex = 25;
            username.TextChanged += username_TextChanged;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnHome);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(userPassword);
            Controls.Add(username);
            Name = "SignIn";
            Text = "SignIn";
            Load += SignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private Button btnHome;
        private Label label3;
        private Label label6;
        private Label label1;
        private TextBox userPassword;
        private TextBox username;
    }
}