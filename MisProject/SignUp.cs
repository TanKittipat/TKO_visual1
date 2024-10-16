using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MisProject
{
    public partial class SignUp : Form
    {
        private string connectionString = "Server=localhost;Database=cola_factory;User ID=root;Password=;";

        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            LoadRoles();
            rolesSelect.Text = "user";
        }

        private void LoadRoles()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT role_name FROM roles";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string roleName = reader.GetString("role_name");
                                rolesSelect.Items.Add(roleName);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignIn signIn = new SignIn();
            this.Hide();
            signIn.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // Add registration logic here
            // Check if passwords match
            if (userPassword.Text != confirmPwd.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return; // Exit the method
            }

            // Proceed to register the user
            RegisterUser();
            SignIn signIn1 = new SignIn();
            signIn1.Show();
            this.Hide();
        }

        private void RegisterUser()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Get values from the input fields
                    string userName = username.Text; // Assume this is your username field
                    string email = userEmail.Text; // Assume this is your email field
                    string password = userPassword.Text; // Password input
                    string userRole = rolesSelect.SelectedItem?.ToString(); // Selected role from ComboBox

                    // Determine role value to return
                    int roleValue = 0;
                    if (userRole == "admin")
                    {
                        roleValue = 1;
                    }
                    else if (userRole == "user")
                    {
                        roleValue = 2;
                    }
                    // SQL command to insert user data
                    string query = "INSERT INTO users (username, email, user_password, user_role) VALUES (@username, @email, @user_password, @user_role)";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", userName);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@user_password", password);
                        cmd.Parameters.AddWithValue("@user_role", roleValue);

                        int result = cmd.ExecuteNonQuery();

                        // Check if the insert was successful
                        if (result > 0)
                        {
                            MessageBox.Show("User registered successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Registration failed. Please try again.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void confirmPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void userEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
