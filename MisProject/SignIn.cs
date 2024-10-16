using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MisProject
{
    public partial class SignIn : Form
    {
        private string connectionString = "Server=localhost;Database=cola_factory;User ID=root;Password=;";

        public SignIn()
        {
            InitializeComponent();
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void userPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Call the method to validate user credentials
            if (ValidateUser(username.Text, userPassword.Text))
            {
                AddDataPage addDataPage = new AddDataPage();
                this.Hide();
                addDataPage.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool ValidateUser(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    // SQL command to check if the username and password match
                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND user_password = @user_password";

                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@user_password", password); // Note: Passwords should ideally be hashed

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        // Return true if a match is found
                        return count > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false; // Return false in case of an error
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
    }
}
