namespace WinFormReview
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMain = new Button();
            label1 = new Label();
            cbbCourse = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.FromArgb(255, 192, 192);
            btnMain.Location = new Point(531, 42);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(119, 49);
            btnMain.TabIndex = 0;
            btnMain.Text = "Main";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += NavigateToMain;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 45);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // cbbCourse
            // 
            cbbCourse.FormattingEnabled = true;
            cbbCourse.Location = new Point(152, 42);
            cbbCourse.Name = "cbbCourse";
            cbbCourse.Size = new Size(318, 28);
            cbbCourse.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(351, 105);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 49);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(695, 217);
            Controls.Add(btnSave);
            Controls.Add(cbbCourse);
            Controls.Add(label1);
            Controls.Add(btnMain);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormReview2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMain;
        private Label label1;
        private ComboBox cbbCourse;
        private Button btnSave;
    }
}