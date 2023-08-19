namespace WinFormReview
{
    public partial class FormPanels : Form
    {
        public FormPanels()
        {
            InitializeComponent();
        }

        private void NavigateToMain(object sender, EventArgs e)
        {
            (Tag as FormMain)?.Show();
            Close();
        }
    }
}
