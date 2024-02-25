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
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(84, 70);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(62, 15);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "Firstname:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(84, 114);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(61, 15);
            lblLastName.TabIndex = 1;
            lblLastName.Text = "Lastname:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(84, 160);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 2;
            lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Location = new Point(84, 202);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(31, 15);
            lblCity.TabIndex = 3;
            lblCity.Text = "City:";
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.Location = new Point(84, 247);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(71, 15);
            lblPostalCode.TabIndex = 4;
            lblPostalCode.Text = "Postal code:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(84, 288);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "E-mail:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(84, 333);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(44, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // tboxFirstName
            // 
            tboxFirstName.Location = new Point(161, 62);
            tboxFirstName.Name = "tboxFirstName";
            tboxFirstName.Size = new Size(100, 23);
            tboxFirstName.TabIndex = 7;
            // 
            // tboxLastName
            // 
            tboxLastName.Location = new Point(161, 106);
            tboxLastName.Name = "tboxLastName";
            tboxLastName.Size = new Size(100, 23);
            tboxLastName.TabIndex = 8;
            // 
            // tboxAddress
            // 
            tboxAddress.Location = new Point(161, 152);
            tboxAddress.Name = "tboxAddress";
            tboxAddress.Size = new Size(100, 23);
            tboxAddress.TabIndex = 9;
            // 
            // tboxCity
            // 
            tboxCity.Location = new Point(161, 194);
            tboxCity.Name = "tboxCity";
            tboxCity.Size = new Size(100, 23);
            tboxCity.TabIndex = 10;
            // 
            // tboxPostCode
            // 
            tboxPostCode.Location = new Point(161, 239);
            tboxPostCode.Name = "tboxPostCode";
            tboxPostCode.Size = new Size(100, 23);
            tboxPostCode.TabIndex = 11;
            // 
            // tboxEmail
            // 
            tboxEmail.Location = new Point(161, 280);
            tboxEmail.Name = "tboxEmail";
            tboxEmail.Size = new Size(100, 23);
            tboxEmail.TabIndex = 12;
            // 
            // tboxPhone
            // 
            tboxPhone.Location = new Point(161, 325);
            tboxPhone.Name = "tboxPhone";
            tboxPhone.Size = new Size(100, 23);
            tboxPhone.TabIndex = 13;
            // 
            // btnCreate
            // 
            btnCreate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(324, 385);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 14;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // PersonCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
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
            Name = "PersonCreate";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PersonCreate";
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
    }
}