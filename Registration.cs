using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WinFormReview
{
    public partial class Registration : Form
    {
        private readonly string databaseConnection = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=WinformReview;Integrated Security=True";
        private readonly SqlConnection connection;
        private SqlCommand? command;

        public Registration()
        {
            InitializeComponent();
            connection = new(databaseConnection);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string[] requiredTextFields = { txtID.Text, txtFirstName.Text, txtlastName.Text, txtDesignation.Text, txtEmail.Text, txtAddress.Text };

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
                                             + $" VALUES('{txtID.Text}','{txtFirstName.Text}', '{txtlastName.Text}',"
                                             + $" '{txtDesignation.Text}', '{txtEmail.Text}', '{gender}', '{txtAddress.Text}')", connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Your data has been saved in the database! 😊");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private static bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }
    }
}
