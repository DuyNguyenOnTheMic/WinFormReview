namespace WinFormReview
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void NavigateToMain(object sender, EventArgs e)
        {
            (Tag as Form1)?.Show();
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cbbCourse.Items.Add("C# Programming");
            cbbCourse.Items.Add("C++ Programming");
            cbbCourse.Items.Add("C Programming");
            cbbCourse.Items.Add("Java Programming");
            cbbCourse.Items.Add("PHP Programming");
        }
    }
}
