using System.Data;

namespace WinFormReview
{
    public partial class Form1 : Form
    {
        private readonly DataTable dataTable = new();
        string name = string.Empty;
        string designation = string.Empty;
        int salary;
        string gender = string.Empty;
        string review = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void NavigateToComboBox(object sender, EventArgs e)
        {
            new Form2()
            {
                Tag = this
            }.Show(this);
            Hide();
        }

        private void SaveData(object sender, EventArgs e)
        {
            name = txtName.Text;
            designation = txtDesignation.Text;
            salary = int.Parse(txtSalary.Text);
            gender = rdoMale.Checked ? "Male" : "Female";
            review = chkGood.Checked ? "Good" : "Very Good";
            Display();
            Empty();
        }

        private void Display()
        {
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Designation");
            dataTable.Columns.Add("Salary");
            dataTable.Columns.Add("Gender");
            dataTable.Columns.Add("Review");

            DataRow dataRow = dataTable.NewRow();
            dataRow["Name"] = name;
            dataRow["Designation"] = designation;
            dataRow["Salary"] = salary;
            dataRow["Gender"] = gender;
            dataRow["Review"] = review;

            dataTable.Rows.Add(dataRow);
            dtgDataGridView.DataSource = dataTable;
        }

        private void Empty()
        {
            txtName.Text = string.Empty;
            txtDesignation.Text = string.Empty;
            txtSalary.Text = string.Empty;
        }
    }
}