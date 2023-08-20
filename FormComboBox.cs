namespace WinFormReview
{
    public partial class FormComboBox : Form
    {
        string name = string.Empty;

        public FormComboBox()
        {
            InitializeComponent();
        }

        private void BtnMain_Click(object sender, EventArgs e)
        {
            (Tag as FormMain)?.Show();
            Close();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            cbbCourse.Items.Add("C# Programming");
            cbbCourse.Items.Add("C++ Programming");
            cbbCourse.Items.Add("C Programming");
            cbbCourse.Items.Add("Java Programming");
            cbbCourse.Items.Add("PHP Programming");
        }

        private void CbbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            name = cbbCourse.SelectedItem.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
