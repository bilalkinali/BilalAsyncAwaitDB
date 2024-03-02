namespace UI
{
    partial class PersonCreate
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
            lblFirstName = new Label();
            lblLastName = new Label();
            lblAddress = new Label();
            lblCity = new Label();
            lblPostalCode = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            tboxFirstName = new TextBox();
            tboxLastName = new TextBox();
            tboxAddress = new TextBox();
            tboxCity = new TextBox();
            tboxPostCode = new TextBox();
            tboxEmail = new TextBox();
            tboxPhone = new TextBox();
            btnCreate = new Button();
            btnBack = new Button();
            panel1 = new Panel();
            lblLoading = new Label();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(47, 42);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(62, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Firstname:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(48, 86);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(61, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Lastname:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(57, 132);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(78, 174);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 3;
            lblCity.Text = "City:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(38, 219);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(71, 15);
            lblPostalCode.TabIndex = 4;
            lblPostalCode.Text = "Postal code:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(65, 260);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(65, 305);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // tboxFirstName
            // 
            tboxFirstName.Location = new Point(111, 39);
            tboxFirstName.MaxLength = 30;
            tboxFirstName.Name = "tboxFirstName";
            tboxFirstName.Size = new Size(96, 23);
            tboxFirstName.TabIndex = 7;
            tboxFirstName.TextChanged += tboxFirstName_TextChanged;
            // 
            // tboxLastName
            // 
            tboxLastName.Location = new Point(111, 83);
            tboxLastName.MaxLength = 30;
            tboxLastName.Name = "tboxLastName";
            tboxLastName.Size = new Size(96, 23);
            tboxLastName.TabIndex = 8;
            tboxLastName.TextChanged += tboxLastName_TextChanged;
            // 
            // tboxAddress
            // 
            tboxAddress.Location = new Point(111, 129);
            tboxAddress.MaxLength = 30;
            tboxAddress.Name = "tboxAddress";
            tboxAddress.Size = new Size(174, 23);
            tboxAddress.TabIndex = 9;
            tboxAddress.TextChanged += tboxAddress_TextChanged;
            // 
            // tboxCity
            // 
            tboxCity.Location = new Point(111, 171);
            tboxCity.MaxLength = 30;
            tboxCity.Name = "tboxCity";
            tboxCity.Size = new Size(126, 23);
            tboxCity.TabIndex = 10;
            tboxCity.TextChanged += tboxCity_TextChanged;
            // 
            // tboxPostCode
            // 
            tboxPostCode.Location = new Point(111, 216);
            tboxPostCode.MaxLength = 4;
            tboxPostCode.Name = "tboxPostCode";
            tboxPostCode.Size = new Size(39, 23);
            tboxPostCode.TabIndex = 11;
            tboxPostCode.TextChanged += tboxPostCode_TextChanged;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(111, 257);
            tboxEmail.MaxLength = 50;
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(174, 23);
            tboxEmail.TabIndex = 12;
            tboxEmail.TextChanged += tboxEmail_TextChanged;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(111, 302);
            tboxPhone.MaxLength = 8;
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(69, 23);
            tboxPhone.TabIndex = 13;
            tboxPhone.TextChanged += tboxPhone_TextChanged;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(243, 377);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(19, 377);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 15;
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
            panel1.TabIndex = 32;
            // 
            // lblLoading
            // 
            lblLoading.AutoSize = true;
            lblLoading.Location = new Point(139, 353);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(61, 15);
            lblLoading.TabIndex = 33;
            lblLoading.Text = "Creating...";
            // 
            // PersonCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 424);
            Controls.Add(lblLoading);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
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
            Name = "PersonCreate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Person Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirstName;
        private Label lblLastName;
        private Label lblAddress;
        private Label lblCity;
        private Label lblPostalCode;
        private Label lblEmail;
        private Label lblPhone;
        private TextBox tboxFirstName;
        private TextBox tboxLastName;
        private TextBox tboxAddress;
        private TextBox tboxCity;
        private TextBox tboxPostCode;
        private TextBox tboxEmail;
        private TextBox tboxPhone;
        private Button btnCreate;
        private Button btnBack;
        private Panel panel1;
        private Label lblLoading;
    }
}