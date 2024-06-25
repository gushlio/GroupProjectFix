namespace ZooBazarDesktopApp
{
    partial class EmployeeForm
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
            panel1 = new Panel();
            comboBoxJobTItle = new ComboBox();
            label4 = new Label();
            btnSearch = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbLocation = new ComboBox();
            txtName = new TextBox();
            panel2 = new Panel();
            btnView = new Button();
            btnAdd = new Button();
            label5 = new Label();
            lbEmployees = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(comboBoxJobTItle);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnSearch);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbLocation);
            panel1.Controls.Add(txtName);
            panel1.Location = new Point(43, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 93);
            panel1.TabIndex = 0;
            // 
            // comboBoxJobTItle
            // 
            comboBoxJobTItle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxJobTItle.FormattingEnabled = true;
            comboBoxJobTItle.Location = new Point(480, 52);
            comboBoxJobTItle.Name = "comboBoxJobTItle";
            comboBoxJobTItle.Size = new Size(190, 29);
            comboBoxJobTItle.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(476, 9);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 7;
            label4.Text = "Filter Out Employees";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FloralWhite;
            btnSearch.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = SystemColors.ActiveCaptionText;
            btnSearch.Location = new Point(1009, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(171, 57);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(691, 52);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 5;
            label3.Text = "Location:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(382, 52);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 4;
            label2.Text = "Job Title:\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(36, 35);
            label1.Name = "label1";
            label1.Size = new Size(110, 50);
            label1.TabIndex = 3;
            label1.Text = "Empoloyee\r\n        Name:";
            // 
            // cmbLocation
            // 
            cmbLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(791, 52);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(190, 29);
            cmbLocation.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.Location = new Point(152, 52);
            txtName.Name = "txtName";
            txtName.Size = new Size(209, 29);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(lbEmployees);
            panel2.Location = new Point(43, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 506);
            panel2.TabIndex = 1;
            // 
            // btnView
            // 
            btnView.BackColor = Color.FloralWhite;
            btnView.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnView.ForeColor = SystemColors.ActiveCaptionText;
            btnView.Location = new Point(15, 456);
            btnView.Name = "btnView";
            btnView.Size = new Size(1165, 42);
            btnView.TabIndex = 9;
            btnView.Text = "View Selected Employee Detials";
            btnView.UseVisualStyleBackColor = false;
            btnView.Click += btnView_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FloralWhite;
            btnAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = SystemColors.ActiveCaptionText;
            btnAdd.Location = new Point(900, 18);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 42);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Employee";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(15, 33);
            label5.Name = "label5";
            label5.Size = new Size(134, 25);
            label5.TabIndex = 8;
            label5.Text = "All Employees\r\n";
            // 
            // lbEmployees
            // 
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 15;
            lbEmployees.Location = new Point(15, 71);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(1165, 379);
            lbEmployees.TabIndex = 0;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1283, 682);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private ComboBox cmbLocation;
        private Button btnSearch;
        private Label label3;
        private Label label4;
        private Panel panel2;
        private Button btnView;
        private Button btnAdd;
        private Label label5;
        private ListBox lbEmployees;
        private ComboBox comboBoxJobTItle;
    }
}