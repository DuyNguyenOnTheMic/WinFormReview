namespace WinFormReview
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            lblName = new Label();
            lblDesignation = new Label();
            lblSalary = new Label();
            txtName = new TextBox();
            txtDesignation = new TextBox();
            txtSalary = new TextBox();
            btnSave = new Button();
            rdoMale = new RadioButton();
            lblGender = new Label();
            rdoFemale = new RadioButton();
            label1 = new Label();
            chkGood = new CheckBox();
            chkVeryGood = new CheckBox();
            dtgDataGridView = new DataGridView();
            btnComboBox = new Button();
            btnPanels = new Button();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dtgDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
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
            txtName.Validating += TxtNameValidating;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(159, 95);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(309, 27);
            txtDesignation.TabIndex = 2;
            txtDesignation.Validating += TxtDesignationValidating;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(159, 147);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(309, 27);
            txtSalary.TabIndex = 3;
            txtSalary.Validating += TxtSalaryValidating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(501, 233);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 49);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += SaveData;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(159, 203);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 24);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(49, 205);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender: ";
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(308, 203);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(78, 24);
            rdoFemale.TabIndex = 5;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 259);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 0;
            label1.Text = "Review: ";
            // 
            // chkGood
            // 
            chkGood.AutoSize = true;
            chkGood.Location = new Point(159, 258);
            chkGood.Name = "chkGood";
            chkGood.Size = new Size(68, 24);
            chkGood.TabIndex = 6;
            chkGood.Text = "Good";
            chkGood.UseVisualStyleBackColor = true;
            // 
            // chkVeryGood
            // 
            chkVeryGood.AutoSize = true;
            chkVeryGood.Location = new Point(308, 255);
            chkVeryGood.Name = "chkVeryGood";
            chkVeryGood.Size = new Size(99, 24);
            chkVeryGood.TabIndex = 7;
            chkVeryGood.Text = "Very good";
            chkVeryGood.UseVisualStyleBackColor = true;
            // 
            // dtgDataGridView
            // 
            dtgDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDataGridView.Location = new Point(49, 339);
            dtgDataGridView.Name = "dtgDataGridView";
            dtgDataGridView.RowHeadersWidth = 51;
            dtgDataGridView.RowTemplate.Height = 29;
            dtgDataGridView.Size = new Size(571, 188);
            dtgDataGridView.TabIndex = 9;
            // 
            // btnComboBox
            // 
            btnComboBox.BackColor = Color.FromArgb(255, 192, 192);
            btnComboBox.CausesValidation = false;
            btnComboBox.Location = new Point(501, 48);
            btnComboBox.Name = "btnComboBox";
            btnComboBox.Size = new Size(119, 49);
            btnComboBox.TabIndex = 8;
            btnComboBox.Text = "ComboBox";
            btnComboBox.UseVisualStyleBackColor = false;
            btnComboBox.Click += NavigateToComboBox;
            // 
            // btnPanels
            // 
            btnPanels.BackColor = Color.FromArgb(255, 192, 192);
            btnPanels.CausesValidation = false;
            btnPanels.Location = new Point(501, 103);
            btnPanels.Name = "btnPanels";
            btnPanels.Size = new Size(119, 49);
            btnPanels.TabIndex = 8;
            btnPanels.Text = "Panels";
            btnPanels.UseVisualStyleBackColor = false;
            btnPanels.Click += NavigateToPanels;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(670, 560);
            Controls.Add(dtgDataGridView);
            Controls.Add(chkVeryGood);
            Controls.Add(chkGood);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(btnPanels);
            Controls.Add(btnComboBox);
            Controls.Add(btnSave);
            Controls.Add(txtSalary);
            Controls.Add(txtDesignation);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(lblGender);
            Controls.Add(lblSalary);
            Controls.Add(lblDesignation);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dtgDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
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
        private RadioButton rdoMale;
        private Label lblGender;
        private RadioButton rdoFemale;
        private Label label1;
        private CheckBox chkGood;
        private CheckBox chkVeryGood;
        private DataGridView dtgDataGridView;
        private Button btnComboBox;
        private Button btnPanels;
        private ErrorProvider errorProvider;
    }
}