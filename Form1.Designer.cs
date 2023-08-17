namespace WinFormReview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblDesignation = new Label();
            lblSalary = new Label();
            txtName = new TextBox();
            txtDesignation = new TextBox();
            txtSalary = new TextBox();
            btnSave = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(49, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name: ";
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Location = new Point(49, 98);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(96, 20);
            lblDesignation.TabIndex = 0;
            lblDesignation.Text = "Designation: ";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Location = new Point(49, 150);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(56, 20);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "Salary: ";
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(309, 27);
            txtName.TabIndex = 1;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(159, 95);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(309, 27);
            txtDesignation.TabIndex = 2;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(159, 147);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(309, 27);
            txtSalary.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(159, 202);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 49);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += SaveData;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(49, 276);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 20);
            lblResult.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 403);
            Controls.Add(btnSave);
            Controls.Add(txtSalary);
            Controls.Add(txtDesignation);
            Controls.Add(txtName);
            Controls.Add(lblResult);
            Controls.Add(lblSalary);
            Controls.Add(lblDesignation);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblDesignation;
        private Label lblSalary;
        private TextBox txtName;
        private TextBox txtDesignation;
        private TextBox txtSalary;
        private Button btnSave;
        private Label lblResult;
    }
}