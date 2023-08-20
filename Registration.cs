using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using WinFormReview.Helpers;

namespace WinFormReview
{
    public partial class Registration : Form
    {
        private readonly string databaseConnection = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=WinformReview;Integrated Security=True";
        private readonly SqlConnection connection;
        private SqlCommand? command;
        private SqlDataAdapter? adapter;
        private DataTable? dataTable;
        int id;

        public Registration()
        {
            InitializeComponent();
            connection = new(databaseConnection);
            Display();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string[] requiredTextFields = { txtID.Text, txtFirstName.Text, txtLastName.Text, txtDesignation.Text, txtEmail.Text, txtAddress.Text };

            // Check if any text fields is empty
            if (requiredTextFields.Any(string.IsNullOrWhiteSpace) || (!rdoMale.Checked && !rdoFemale.Checked))
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email address is not valid");
            }
            else
            {
                string gender = rdoMale.Checked ? "Male" : "Female";
                try
                {
                    // Add new employee
                    connection.Open();
                    command = new SqlCommand($"INSERT INTO EMPLOYEE"
                                             + $"(EmployeeId,FirstName,LastName,Designation,Email,Gender,Address)"
                                             + $" VALUES('{txtID.Text}','{txtFirstName.Text}','{txtLastName.Text}',"
                                             + $"'{txtDesignation.Text}','{txtEmail.Text}','{gender}','{txtAddress.Text}')", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Your data has been saved in the database! 😊");
                    FormClearing.ClearGroupBoxFormControls(gbRegistration);
                    Display();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string[] requiredTextFields = { txtID.Text, txtFirstName.Text, txtLastName.Text, txtDesignation.Text, txtEmail.Text, txtAddress.Text };

            // Check if any text fields is empty
            if (requiredTextFields.Any(string.IsNullOrWhiteSpace) || (!rdoMale.Checked && !rdoFemale.Checked))
            {
                MessageBox.Show("Please fill in the blanks");
            }
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email address is not valid");
            }
            else
            {
                string gender = rdoMale.Checked ? "Male" : "Female";
                try
                {
                    // Update employee
                    connection.Open();
                    command = new SqlCommand($"UPDATE EMPLOYEE "
                                             + $"SET FirstName='{txtFirstName.Text}',LastName='{txtLastName.Text}',"
                                             + $"Designation='{txtDesignation.Text}',Email='{txtEmail.Text}',"
                                             + $"Gender='{gender}',Address='{txtAddress.Text}'"
                                             + $"WHERE Id='{id}'", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Your data has been updated in the database! 😊");
                    Display();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Delete employee
                connection.Open();
                command = new SqlCommand($"DELETE FROM EMPLOYEE "
                                         + $"WHERE Id='{id}'", connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Your data has been deleted in the database! 😊");
                Display();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private void Display()
        {
            try
            {
                dataTable = new DataTable();
                connection.Open();
                adapter = new SqlDataAdapter("SELECT * FROM EMPLOYEE", connection);
                adapter.Fill(dataTable);
                dtgdataGridView.DataSource = dataTable;
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        private static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void DtgdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dtgdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtID.Text = dtgdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtFirstName.Text = dtgdataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtLastName.Text = dtgdataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDesignation.Text = dtgdataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtEmail.Text = dtgdataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (dtgdataGridView.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male")
            {
                rdoMale.Checked = true;
                rdoFemale.Checked = false;
            }
            else
            {
                rdoMale.Checked = false;
                rdoFemale.Checked = true;
            }
            txtAddress.Text = dtgdataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
        }
    }
}
