namespace WinFormReview.Helpers
{
    internal class FormClearing
    {
        public static void ClearFormControls(Form form)
        {
            foreach (Control control in form.Controls)
            {
                ClearControls(control);
            }
        }

        public static void ClearGroupBoxFormControls(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                ClearControls(control);
            }
        }

        private static void ClearControls(Control control)
        {
            if (control is TextBox txtBox)
            {
                txtBox.Text = string.Empty;
            }
            else if (control is CheckBox chkBox)
            {
                chkBox.Checked = false;
            }
            else if (control is RadioButton rdoBtn)
            {
                rdoBtn.Checked = false;
            }
            else if (control is DateTimePicker dtp)
            {
                dtp.Value = DateTime.Now;
            }
        }
    }
}