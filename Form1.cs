namespace WinFormReview
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveData(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string designation = txtDesignation.Text;
            int salary = int.Parse(txtSalary.Text);
            lblResult.Text = $"Your name is: {name}\nYour designation is: {designation}\nYour salary is: {salary}";
        }
    }
}