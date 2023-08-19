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
            string gender = rdoMale.Checked ? "Male" : "Female";
            string review = chkGood.Checked ? "Good" : "Very Good";
            lblResult.Text = $"Your name is: {name}\nYour designation is: {designation}\nYour salary is: {salary}\nYour gender is: {gender}\nYour review is: {review}";
        }
    }
}