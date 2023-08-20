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

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gege");
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
