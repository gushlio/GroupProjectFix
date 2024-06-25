namespace ZooBazarDesktopApp
{
    partial class EditShiftsForm
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
            lblDayTime = new Label();
            cmbEmployee = new ComboBox();
            btnAddEmployee = new Button();
            lbxWorkingEmployees = new ListBox();
            btnRemoveEmployee = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(lblDayTime);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 77);
            panel1.TabIndex = 0;
            // 
            // lblDayTime
            // 
            lblDayTime.AutoSize = true;
            lblDayTime.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDayTime.ForeColor = SystemColors.ButtonHighlight;
            lblDayTime.Location = new Point(13, 22);
            lblDayTime.Name = "lblDayTime";
            lblDayTime.Size = new Size(137, 32);
            lblDayTime.TabIndex = 0;
            lblDayTime.Text = "DAY - TIME";
            // 
            // cmbEmployee
            // 
            cmbEmployee.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(32, 119);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(316, 40);
            cmbEmployee.TabIndex = 1;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.DarkSeaGreen;
            btnAddEmployee.BackgroundImageLayout = ImageLayout.None;
            btnAddEmployee.Cursor = Cursors.Hand;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnAddEmployee.ForeColor = Color.White;
            btnAddEmployee.Location = new Point(378, 119);
            btnAddEmployee.Margin = new Padding(3, 2, 3, 2);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(156, 40);
            btnAddEmployee.TabIndex = 53;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // lbxWorkingEmployees
            // 
            lbxWorkingEmployees.BackColor = Color.WhiteSmoke;
            lbxWorkingEmployees.BorderStyle = BorderStyle.None;
            lbxWorkingEmployees.Font = new Font("Segoe UI", 12F);
            lbxWorkingEmployees.FormattingEnabled = true;
            lbxWorkingEmployees.ItemHeight = 21;
            lbxWorkingEmployees.Location = new Point(32, 176);
            lbxWorkingEmployees.Name = "lbxWorkingEmployees";
            lbxWorkingEmployees.Size = new Size(502, 336);
            lbxWorkingEmployees.TabIndex = 54;
            // 
            // btnRemoveEmployee
            // 
            btnRemoveEmployee.BackColor = Color.DarkSeaGreen;
            btnRemoveEmployee.BackgroundImageLayout = ImageLayout.None;
            btnRemoveEmployee.Cursor = Cursors.Hand;
            btnRemoveEmployee.FlatStyle = FlatStyle.Flat;
            btnRemoveEmployee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRemoveEmployee.ForeColor = Color.White;
            btnRemoveEmployee.Location = new Point(32, 517);
            btnRemoveEmployee.Margin = new Padding(3, 2, 3, 2);
            btnRemoveEmployee.Name = "btnRemoveEmployee";
            btnRemoveEmployee.Size = new Size(502, 35);
            btnRemoveEmployee.TabIndex = 55;
            btnRemoveEmployee.Text = "Remove Employee";
            btnRemoveEmployee.UseVisualStyleBackColor = false;
            btnRemoveEmployee.Click += btnRemoveEmployee_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.ForestGreen;
            btnSave.BackgroundImageLayout = ImageLayout.None;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(32, 576);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(242, 42);
            btnSave.TabIndex = 57;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.ForestGreen;
            btnCancel.BackgroundImageLayout = ImageLayout.None;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(292, 576);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(242, 42);
            btnCancel.TabIndex = 58;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 646);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnRemoveEmployee);
            Controls.Add(lbxWorkingEmployees);
            Controls.Add(btnAddEmployee);
            Controls.Add(cmbEmployee);
            Controls.Add(panel1);
            Name = "EditShiftsForm";
            Text = "EditShiftsForm";
            FormClosing += EditShiftsForm_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDayTime;
        private ComboBox cmbEmployee;
        private Button btnAddEmployee;
        private ListBox lbxWorkingEmployees;
        private Button btnRemoveEmployee;
        private Button btnSave;
        private Button btnCancel;
    }
}