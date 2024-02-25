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
            SuspendLayout();
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(227, 338);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(100, 23);
            tboxPhone.TabIndex = 27;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(227, 293);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(100, 23);
            tboxEmail.TabIndex = 26;
            // 
            // tboxPostCode
            // 
            tboxPostCode.Location = new Point(227, 252);
            tboxPostCode.Name = "tboxPostCode";
            tboxPostCode.Size = new Size(100, 23);
            tboxPostCode.TabIndex = 25;
            // 
            // tboxCity
            // 
            tboxCity.Location = new Point(227, 207);
            tboxCity.Name = "tboxCity";
            tboxCity.Size = new Size(100, 23);
            tboxCity.TabIndex = 24;
            // 
            // tboxAddress
            // 
            tboxAddress.Location = new Point(227, 165);
            tboxAddress.Name = "tboxAddress";
            tboxAddress.Size = new Size(100, 23);
            tboxAddress.TabIndex = 23;
            // 
            // tboxLastName
            // 
            tboxLastName.Location = new Point(227, 119);
            tboxLastName.Name = "tboxLastName";
            tboxLastName.Size = new Size(100, 23);
            tboxLastName.TabIndex = 22;
            // 
            // tboxFirstName
            // 
            tboxFirstName.Location = new Point(227, 75);
            tboxFirstName.Name = "tboxFirstName";
            tboxFirstName.Size = new Size(100, 23);
            tboxFirstName.TabIndex = 21;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(150, 346);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 20;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(150, 301);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "E-mail:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(150, 260);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(71, 15);
            lblPostalCode.TabIndex = 18;
            lblPostalCode.Text = "Postal code:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(150, 215);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 17;
            lblCity.Text = "City:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(150, 173);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 16;
            lblAddress.Text = "Address:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(150, 127);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(61, 15);
            lblLastName.TabIndex = 15;
            lblLastName.Text = "Lastname:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(150, 83);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(62, 15);
            lblFirstName.TabIndex = 14;
            lblFirstName.Text = "Firstname:";
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.OrangeRed;
            btnDelete.Location = new Point(150, 393);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 28;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_ClickAsync;
            // 
            // PersonDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "PersonDetails";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PersonDetails";
            Load += PersonDetails_LoadAsync;
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
    }
}