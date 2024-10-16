using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace MisProject
{
    public partial class AddDataPage : Form
    {
        private string connectionString = "Server=localhost;Database=cola_factory;User ID=root;Password=;";

        public AddDataPage()
        {
            InitializeComponent();
        }

        private void AddDataPage_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM producinginfo"; // Modify this query as needed
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: handle cell click events if needed
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime input1 = producingDate.Value.Date; // Get date only
            string input2 = producingLot.Text;
            string input3 = waterInput.Text;
            string input4 = sugarInput.Text;
            string input5 = scentInput.Text;
            string input6 = phosphoricInput.Text;
            string input7 = foodColorInput.Text;
            string input8 = carbondioxideInput.Text;
            string input9 = quantity.Text;
            string input10 = temperature.Text;
            string input11 = timeUse.Text;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO producinginfo (dateProduce, producingLot, water, sugar, phosphoricAcid, scent, foodColor, carbondioxide, quantity, temperature, timeuse) " +
                                   "VALUES (@input1, @input2, @input3, @input4, @input5, @input6, @input7, @input8, @input9, @input10, @input11)";

                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@input1", input1);
                    command.Parameters.AddWithValue("@input2", input2);
                    command.Parameters.AddWithValue("@input3", input3);
                    command.Parameters.AddWithValue("@input4", input4);
                    command.Parameters.AddWithValue("@input5", input5);
                    command.Parameters.AddWithValue("@input6", input6);
                    command.Parameters.AddWithValue("@input7", input7);
                    command.Parameters.AddWithValue("@input8", input8);
                    command.Parameters.AddWithValue("@input9", input9);
                    command.Parameters.AddWithValue("@input10", input10);
                    command.Parameters.AddWithValue("@input11", input11);

                    int result = command.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Data added successfully!");
                        LoadData(); // Reload the data
                    }
                    else
                    {
                        MessageBox.Show("No data was added.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"General Error: {ex.Message}");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Populate the input fields with the values from the selected row
                producingDate.Value = Convert.ToDateTime(row.Cells["dateProduce"].Value);
                producingLot.Text = row.Cells["producingLot"].Value.ToString();
                waterInput.Text = row.Cells["water"].Value.ToString();
                sugarInput.Text = row.Cells["sugar"].Value.ToString();
                scentInput.Text = row.Cells["scent"].Value.ToString();
                phosphoricInput.Text = row.Cells["phosphoricAcid"].Value.ToString();
                foodColorInput.Text = row.Cells["foodColor"].Value.ToString();
                carbondioxideInput.Text = row.Cells["carbondioxide"].Value.ToString();
                quantity.Text = row.Cells["quantity"].Value.ToString();
                temperature.Text = row.Cells["temperature"].Value.ToString();
                timeUse.Text = row.Cells["timeuse"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value); // Assuming "id" is the name of your primary key column

                DateTime input1 = producingDate.Value.Date;
                string input2 = producingLot.Text;
                string input3 = waterInput.Text;
                string input4 = sugarInput.Text;
                string input5 = scentInput.Text;
                string input6 = phosphoricInput.Text;
                string input7 = foodColorInput.Text;
                string input8 = carbondioxideInput.Text;
                string input9 = quantity.Text;
                string input10 = temperature.Text;
                string input11 = timeUse.Text;

                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE producinginfo SET dateProduce = @input1, producingLot = @input2, water = @input3, sugar = @input4, " +
                                       "phosphoricAcid = @input5, scent = @input6, foodColor = @input7, carbondioxide = @input8, " +
                                       "quantity = @input9, temperature = @input10, timeuse = @input11 WHERE id = @id";

                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@input1", input1);
                        command.Parameters.AddWithValue("@input2", input2);
                        command.Parameters.AddWithValue("@input3", input3);
                        command.Parameters.AddWithValue("@input4", input4);
                        command.Parameters.AddWithValue("@input5", input5);
                        command.Parameters.AddWithValue("@input6", input6);
                        command.Parameters.AddWithValue("@input7", input7);
                        command.Parameters.AddWithValue("@input8", input8);
                        command.Parameters.AddWithValue("@input9", input9);
                        command.Parameters.AddWithValue("@input10", input10);
                        command.Parameters.AddWithValue("@input11", input11);
                        command.Parameters.AddWithValue("@id", id);

                        int result = command.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("Data updated successfully!");
                            LoadData(); // Reload the data
                        }
                        else
                        {
                            MessageBox.Show("No data was updated.");
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"General Error: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected row index
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView1.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView1.Rows[rowIndex].Cells["id"].Value); // Assuming "id" is the name of your primary key column

                DialogResult confirmResult = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            string query = "DELETE FROM producinginfo WHERE id = @id";

                            MySqlCommand command = new MySqlCommand(query, connection);
                            command.Parameters.AddWithValue("@id", id);

                            int result = command.ExecuteNonQuery();

                            if (result > 0)
                            {
                                MessageBox.Show("Data deleted successfully!");
                                LoadData(); // Reload the data
                            }
                            else
                            {
                                MessageBox.Show("No data was deleted.");
                            }
                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show($"Error: {ex.Message}");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"General Error: {ex.Message}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save a PDF File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filename = saveFileDialog.FileName;

                    // Create a new PDF document
                    PdfDocument document = new PdfDocument();
                    document.Info.Title = "Producing Information Report";

                    // Create a new page with portrait orientation
                    PdfPage page = document.AddPage();
                    page.Size = PdfSharp.PageSize.A4; // Set to A4 size
                    page.Orientation = PdfSharp.PageOrientation.Portrait; // Set to portrait orientation

                    XGraphics gfx = XGraphics.FromPdfPage(page);
                    XFont font = new XFont("Verdana", 20);

                    // Draw the title
                    gfx.DrawString("Producing Information Report", font, XBrushes.Black,
                        new XRect(0, 0, page.Width, page.Height),
                        XStringFormats.TopCenter);

                    // Draw data with titles on new lines
                    font = new XFont("Verdana", 12);
                    int yPoint = 50;

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Index == dataGridView1.Rows.Count - 1) break; // Skip the new row placeholder

                        gfx.DrawString("Date Produced: " + row.Cells["dateProduce"].Value.ToString(), font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Producing Lot: " + row.Cells["producingLot"].Value.ToString(), font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Water: " + row.Cells["water"].Value.ToString() + " liter", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Sugar: " + row.Cells["sugar"].Value.ToString() + " kilogram", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Phosphoric Acid: " + row.Cells["phosphoricAcid"].Value.ToString() + " kilogram", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Scent: " + row.Cells["scent"].Value.ToString() + " gram", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Color: " + row.Cells["foodColor"].Value.ToString() + " milligram", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Carbondioxide: " + row.Cells["carbondioxide"].Value.ToString() + " kilogram", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Quantity: " + row.Cells["quantity"].Value.ToString() + " bottles", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Temperature: " + row.Cells["temperature"].Value.ToString() + " °C", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        gfx.DrawString("Time: " + row.Cells["timeuse"].Value.ToString() + " minute", font, XBrushes.Black, new XRect(30, yPoint, page.Width, page.Height), XStringFormats.TopLeft);
                        yPoint += 20; // Move down for the next line

                        // Add spacing between different records
                        yPoint += 10; // Extra space between different records
                    }

                    // Save the document
                    document.Save(filename);
                    MessageBox.Show("PDF file saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnReturnHome_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            this.Close();
            homePage.Show();
        }
    }
}
