namespace WinFormReview
{
    public partial class Form2 : Form
    {
        string? name = string.Empty;

        public Form2()
        {
            InitializeComponent();
        }

        private void NavigateToMain(object sender, EventArgs e)
        {
            (Tag as Form1)?.Show();
            Close();
        }

        private void FormLoad(object sender, EventArgs e)
        {
            cbbCourse.Items.Add("C# Programming");
            cbbCourse.Items.Add("C++ Programming");
            cbbCourse.Items.Add("C Programming");
            cbbCourse.Items.Add("Java Programming");
            cbbCourse.Items.Add("PHP Programming");
        }

        private void SelectedIndexChanged(object sender, EventArgs e)
        {
            name = cbbCourse.SelectedItem.ToString();
        }

        private void ShowName(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }
    }
}
