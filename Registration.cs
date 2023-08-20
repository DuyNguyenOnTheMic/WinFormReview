using System.Data.SqlClient;

namespace WinFormReview
{
    public partial class Registration : Form
    {
        private readonly string databaseConnection = @"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=WinformReview;Integrated Security=True";
        private SqlConnection con;

        public Registration()
        {
            InitializeComponent();
            con = new(databaseConnection);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
