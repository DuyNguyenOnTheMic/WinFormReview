namespace WinFormReview
{
    partial class Registration
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
            gbRegistration = new GroupBox();
            txtAddress = new TextBox();
            txtID = new TextBox();
            lblAddress = new Label();
            lblGender = new Label();
            lblID = new Label();
            dtgdataGridView = new DataGridView();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtDesignation = new TextBox();
            lblEmail = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            lblDesignation = new Label();
            lblFirstName = new Label();
            btnSave = new Button();
            gbOperations = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            dtpDateTimePicker = new DateTimePicker();
            gbRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgdataGridView).BeginInit();
            gbOperations.SuspendLayout();
            SuspendLayout();
            // 
            // gbRegistration
            // 
            gbRegistration.Controls.Add(txtAddress);
            gbRegistration.Controls.Add(txtID);
            gbRegistration.Controls.Add(lblAddress);
            gbRegistration.Controls.Add(lblGender);
            gbRegistration.Controls.Add(lblID);
            gbRegistration.Controls.Add(dtgdataGridView);
            gbRegistration.Controls.Add(rdoMale);
            gbRegistration.Controls.Add(rdoFemale);
            gbRegistration.Controls.Add(txtEmail);
            gbRegistration.Controls.Add(txtLastName);
            gbRegistration.Controls.Add(txtDesignation);
            gbRegistration.Controls.Add(lblEmail);
            gbRegistration.Controls.Add(txtFirstName);
            gbRegistration.Controls.Add(lblLastName);
            gbRegistration.Controls.Add(lblDesignation);
            gbRegistration.Controls.Add(lblFirstName);
            gbRegistration.Location = new Point(12, 45);
            gbRegistration.Name = "gbRegistration";
            gbRegistration.Size = new Size(770, 453);
            gbRegistration.TabIndex = 0;
            gbRegistration.TabStop = false;
            gbRegistration.Text = "Registration";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(107, 189);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(647, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 136);
            txtID.Name = "txtID";
            txtID.Size = new Size(270, 27);
            txtID.TabIndex = 4;
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(13, 192);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(69, 20);
            lblAddress.TabIndex = 0;
            lblAddress.Text = "Address: ";
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(395, 139);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 0;
            lblGender.Text = "Gender: ";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(13, 139);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 0;
            lblID.Text = "ID:";
            // 
            // dtgdataGridView
            // 
            dtgdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgdataGridView.Location = new Point(13, 237);
            dtgdataGridView.Name = "dtgdataGridView";
            dtgdataGridView.RowHeadersWidth = 51;
            dtgdataGridView.RowTemplate.Height = 29;
            dtgdataGridView.Size = new Size(741, 194);
            dtgdataGridView.TabIndex = 8;
            dtgdataGridView.CellDoubleClick += DtgdataGridView_CellDoubleClick;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(484, 137);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(63, 24);
            rdoMale.TabIndex = 5;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(590, 137);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(78, 24);
            rdoFemale.TabIndex = 6;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(484, 80);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(270, 27);
            txtEmail.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(484, 30);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(270, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtDesignation
            // 
            txtDesignation.Location = new Point(107, 80);
            txtDesignation.Name = "txtDesignation";
            txtDesignation.Size = new Size(270, 27);
            txtDesignation.TabIndex = 2;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(395, 83);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(53, 20);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email: ";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(107, 30);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(270, 27);
            txtFirstName.TabIndex = 0;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(395, 33);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(86, 20);
            lblLastName.TabIndex = 0;
            lblLastName.Text = "Last Name: ";
            // 
            // lblDesignation
            // 
            lblDesignation.AutoSize = true;
            lblDesignation.Location = new Point(13, 83);
            lblDesignation.Name = "lblDesignation";
            lblDesignation.Size = new Size(62, 20);
            lblDesignation.TabIndex = 0;
            lblDesignation.Text = "Design: ";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(13, 33);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(87, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name: ";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(46, 204, 113);
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(6, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 56);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += BtnSave_Click;
            // 
            // gbOperations
            // 
            gbOperations.Controls.Add(btnDelete);
            gbOperations.Controls.Add(btnUpdate);
            gbOperations.Controls.Add(btnSave);
            gbOperations.Location = new Point(788, 45);
            gbOperations.Name = "gbOperations";
            gbOperations.Size = new Size(176, 453);
            gbOperations.TabIndex = 1;
            gbOperations.TabStop = false;
            gbOperations.Text = "Operations";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(231, 76, 60);
            btnDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(6, 173);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 56);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(41, 128, 185);
            btnUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(6, 103);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(164, 56);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // dtpDateTimePicker
            // 
            dtpDateTimePicker.Location = new Point(714, 12);
            dtpDateTimePicker.Name = "dtpDateTimePicker";
            dtpDateTimePicker.Size = new Size(250, 27);
            dtpDateTimePicker.TabIndex = 2;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(976, 510);
            Controls.Add(dtpDateTimePicker);
            Controls.Add(gbOperations);
            Controls.Add(gbRegistration);
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration";
            gbRegistration.ResumeLayout(false);
            gbRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgdataGridView).EndInit();
            gbOperations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbRegistration;
        private DataGridView dtgdataGridView;
        private RadioButton rdoFemale;
        private TextBox txtFirstName;
        private Button btnSave;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private TextBox txtEmail;
        private TextBox txtDesignation;
        private Label lblEmail;
        private Label lblDesignation;
        private TextBox txtID;
        private Label lblID;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblGender;
        private RadioButton rdoMale;
        private GroupBox gbOperations;
        private Button btnDelete;
        private Button btnUpdate;
        private DateTimePicker dtpDateTimePicker;
    }
}