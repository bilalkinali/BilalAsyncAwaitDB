namespace UI
{
    partial class PersonDetails
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
            tboxPhone = new TextBox();
            tboxEmail = new TextBox();
            tboxPostCode = new TextBox();
            tboxCity = new TextBox();
            tboxAddress = new TextBox();
            tboxLastName = new TextBox();
            tboxFirstName = new TextBox();
            lblPhone = new Label();
            lblEmail = new Label();
            lblPostalCode = new Label();
            lblCity = new Label();
            lblAddress = new Label();
            lblLastName = new Label();
            lblFirstName = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(111, 302);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(69, 23);
            tboxPhone.TabIndex = 6;
            tboxPhone.TextChanged += tboxPhone_TextChanged;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(111, 257);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(174, 23);
            tboxEmail.TabIndex = 5;
            tboxEmail.TextChanged += tboxEmail_TextChanged;
            // 
            // tboxPostCode
            // 
            tboxPostCode.Location = new Point(111, 216);
            tboxPostCode.Name = "tboxPostCode";
            tboxPostCode.Size = new Size(39, 23);
            tboxPostCode.TabIndex = 4;
            tboxPostCode.TextChanged += tboxPostCode_TextChanged;
            // 
            // tboxCity
            // 
            tboxCity.Location = new Point(111, 171);
            tboxCity.Name = "tboxCity";
            tboxCity.Size = new Size(174, 23);
            tboxCity.TabIndex = 3;
            tboxCity.TextChanged += tboxCity_TextChanged;
            // 
            // tboxAddress
            // 
            tboxAddress.Location = new Point(111, 129);
            tboxAddress.Name = "tboxAddress";
            tboxAddress.Size = new Size(174, 23);
            tboxAddress.TabIndex = 2;
            tboxAddress.TextChanged += tboxAddress_TextChanged;
            // 
            // tboxLastName
            // 
            tboxLastName.Location = new Point(111, 83);
            tboxLastName.Name = "tboxLastName";
            tboxLastName.Size = new Size(96, 23);
            tboxLastName.TabIndex = 1;
            tboxLastName.TextChanged += tboxLastName_TextChanged;
            // 
            // tboxFirstName
            // 
            tboxFirstName.Location = new Point(111, 39);
            tboxFirstName.Name = "tboxFirstName";
            tboxFirstName.Size = new Size(96, 23);
            tboxFirstName.TabIndex = 0;
            tboxFirstName.TextChanged += tboxFirstName_TextChanged;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(65, 305);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 20;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(65, 260);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "E-mail:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(38, 219);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(71, 15);
            lblPostalCode.TabIndex = 18;
            lblPostalCode.Text = "Postal code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(78, 174);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 17;
            lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(57, 132);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(48, 86);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(61, 15);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Lastname:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(47, 42);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(62, 15);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "Firstname:";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.OrangeRed;
            btnDelete.Location = new Point(132, 377);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(243, 377);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += bntUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(19, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(299, 329);
            panel1.TabIndex = 31;
            // 
            // PersonDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 424);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(tboxPhone);
            Controls.Add(tboxEmail);
            Controls.Add(tboxPostCode);
            Controls.Add(tboxCity);
            Controls.Add(tboxAddress);
            Controls.Add(tboxLastName);
            Controls.Add(tboxFirstName);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblPostalCode);
            Controls.Add(lblCity);
            Controls.Add(lblAddress);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "PersonDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person Details";
            Load += PersonDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tboxPhone;
        private TextBox tboxEmail;
        private TextBox tboxPostCode;
        private TextBox tboxCity;
        private TextBox tboxAddress;
        private TextBox tboxLastName;
        private TextBox tboxFirstName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblPostalCode;
        private Label lblCity;
        private Label lblAddress;
        private Label lblLastName;
        private Label lblFirstName;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnBack;
        private Panel panel1;
    }
}