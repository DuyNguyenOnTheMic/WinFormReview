namespace WinFormReview
{
    partial class FormPanels
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPanels));
            panel1 = new Panel();
            btnMain = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(231, 76, 60);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(785, 73);
            panel1.TabIndex = 0;
            // 
            // btnMain
            // 
            btnMain.BackColor = Color.FromArgb(255, 192, 192);
            btnMain.Location = new Point(655, 88);
            btnMain.Name = "btnMain";
            btnMain.Size = new Size(119, 49);
            btnMain.TabIndex = 1;
            btnMain.Text = "Main";
            btnMain.UseVisualStyleBackColor = false;
            btnMain.Click += NavigateToMain;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.store;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(680, 12);
            button6.Name = "button6";
            button6.Size = new Size(94, 46);
            button6.TabIndex = 0;
            button6.Text = "Shop";
            button6.TextAlign = ContentAlignment.MiddleRight;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.report;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(558, 12);
            button5.Name = "button5";
            button5.Size = new Size(116, 46);
            button5.TabIndex = 0;
            button5.Text = "Reports";
            button5.TextAlign = ContentAlignment.MiddleRight;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.delivery_box;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(427, 12);
            button4.Name = "button4";
            button4.Size = new Size(125, 46);
            button4.TabIndex = 0;
            button4.Text = "Products";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.plus;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(287, 12);
            button3.Name = "button3";
            button3.Size = new Size(134, 46);
            button3.TabIndex = 0;
            button3.Text = "Add Items";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(170, 12);
            button2.Name = "button2";
            button2.Size = new Size(111, 46);
            button2.TabIndex = 0;
            button2.Text = "Invoice";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.profile;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(152, 46);
            button1.TabIndex = 0;
            button1.Text = "Registration";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.work;
            pictureBox1.Location = new Point(0, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(785, 377);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormPanels
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 450);
            Controls.Add(btnMain);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FormPanels";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPanels";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Button btnMain;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private PictureBox pictureBox1;
    }
}