namespace BilalAsyncAwait
{
    partial class Overview
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
            dgv = new DataGridView();
            btnCreate = new Button();
            btnExit = new Button();
            lblSelected = new Label();
            tboxSelected = new TextBox();
            lblTotal = new Label();
            tboxTotal = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 12);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(892, 306);
            dgv.TabIndex = 0;
            dgv.CellDoubleClick += dgv_CellDoubleClick;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(829, 349);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(12, 349);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button1_Click;
            // 
            // lblSelected
            // 
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(829, 321);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(54, 15);
            lblSelected.TabIndex = 3;
            lblSelected.Text = "Selected:";
            // 
            // tboxSelected
            // 
            tboxSelected.BackColor = SystemColors.Control;
            tboxSelected.BorderStyle = BorderStyle.None;
            tboxSelected.Location = new Point(881, 321);
            tboxSelected.Name = "tboxSelected";
            tboxSelected.ReadOnly = true;
            tboxSelected.Size = new Size(30, 16);
            tboxSelected.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(12, 321);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total:";
            // 
            // tboxTotal
            // 
            tboxTotal.BackColor = SystemColors.Control;
            tboxTotal.BorderStyle = BorderStyle.None;
            tboxTotal.Location = new Point(44, 321);
            tboxTotal.Name = "tboxTotal";
            tboxTotal.ReadOnly = true;
            tboxTotal.Size = new Size(30, 16);
            tboxTotal.TabIndex = 6;
            // 
            // Overview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 388);
            Controls.Add(tboxTotal);
            Controls.Add(lblTotal);
            Controls.Add(tboxSelected);
            Controls.Add(lblSelected);
            Controls.Add(btnExit);
            Controls.Add(btnCreate);
            Controls.Add(dgv);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Overview";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Person Manager";
            Load += Overview_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv;
        private Button btnCreate;
        private Button btnExit;
        private Label lblSelected;
        private TextBox tboxSelected;
        private Label lblTotal;
        private TextBox tboxTotal;
    }
}
