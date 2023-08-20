using System.ComponentModel;
using System.Data;
using WinFormReview.Helpers;

namespace WinFormReview
{
    public partial class FormMain : Form
    {
        private readonly DataTable dataTable = new();
        string name = string.Empty;
        string designation = string.Empty;
        int salary;
        string gender = string.Empty;
        string review = string.Empty;

        public FormMain()
        {
            InitializeComponent();
        }

        private void BtnComboBox_Click(object sender, EventArgs e)
        {
            // Navigate to form combobox
            new FormComboBox()
            {
                Tag = this
            }.Show(this);
            Hide();
        }

        private void BtnPanels_Click(object sender, EventArgs e)
        {
            // Navigate to form Panels
            new FormPanels()
            {
                Tag = this
            }.Show(this);
            Hide();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Check validations
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                name = txtName.Text;
                designation = txtDesignation.Text;
                salary = int.Parse(txtSalary.Text);
                gender = rdoMale.Checked ? "Male" : "Female";
                review = chkGood.Checked ? "Good" : "Very Good";
                Display();
                FormClearing.ClearFormControls(this);
            }
        }

        private void Display()
        {
            if (dataTable.Columns.Count == 0)
            {
                dataTable.Columns.Add("Name");
                dataTable.Columns.Add("Designation");
                dataTable.Columns.Add("Salary");
                dataTable.Columns.Add("Gender");
                dataTable.Columns.Add("Review");
            }

            DataRow dataRow = dataTable.NewRow();
            dataRow["Name"] = name;
            dataRow["Designation"] = designation;
            dataRow["Salary"] = salary;
            dataRow["Gender"] = gender;
            dataRow["Review"] = review;

            dataTable.Rows.Add(dataRow);
            dtgDataGridView.DataSource = dataTable;
        }

        #region Validations
        private void TxtNameValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtName, "");
            }
        }

        private void TxtDesignationValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDesignation.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtDesignation, "Designation should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDesignation, "");
            }
        }

        private void TxtSalaryValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSalary, "Salary should not be left blank!");
            }
            else if (!int.TryParse(txtSalary.Text, out _))
            {
                e.Cancel = true;
                errorProvider.SetError(txtSalary, "Salary should be a number");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSalary, "");
            }
        }
        #endregion
    }
}