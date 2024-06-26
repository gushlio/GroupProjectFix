namespace ZooBazarDesktopApp
{
    partial class TaskDetailsForm
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
            txtDescription = new RichTextBox();
            lblDescription = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnMarkAsDone = new Button();
            lblTitle = new Label();
            lblCategory = new Label();
            lblLocation = new Label();
            lblDeadline = new Label();
            label6 = new Label();
            lbAssignedEmployees = new ListBox();
            buttonDelete = new Button();
            buttonSave = new Button();
            txtTitle = new TextBox();
            cmbCategory = new ComboBox();
            cmbLocation = new ComboBox();
            doneByTextBox = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(txtDescription);
            panel1.Controls.Add(lblDescription);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(12, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 425);
            panel1.TabIndex = 0;
            // 
            // txtDescription
            // 
            txtDescription.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(130, 18);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(538, 397);
            txtDescription.TabIndex = 11;
            txtDescription.Text = "";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(130, 18);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(107, 30);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Category:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 18);
            label5.Name = "label5";
            label5.Size = new Size(94, 30);
            label5.TabIndex = 6;
            label5.Text = "Context:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 26);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 1;
            label1.Text = "Task Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 88);
            label2.Name = "label2";
            label2.Size = new Size(107, 30);
            label2.TabIndex = 2;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 153);
            label3.Name = "label3";
            label3.Size = new Size(100, 30);
            label3.TabIndex = 3;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 204);
            label4.Name = "label4";
            label4.Size = new Size(101, 30);
            label4.TabIndex = 4;
            label4.Text = "Deadline:";
            // 
            // btnMarkAsDone
            // 
            btnMarkAsDone.BackColor = Color.DarkSeaGreen;
            btnMarkAsDone.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold);
            btnMarkAsDone.ForeColor = SystemColors.ButtonHighlight;
            btnMarkAsDone.Location = new Point(12, 624);
            btnMarkAsDone.Name = "btnMarkAsDone";
            btnMarkAsDone.Size = new Size(683, 78);
            btnMarkAsDone.TabIndex = 5;
            btnMarkAsDone.Text = "Mark Task As Done";
            btnMarkAsDone.UseVisualStyleBackColor = false;
            btnMarkAsDone.Click += btnMarkAsDone_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(153, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(106, 30);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Task Title:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(153, 88);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(107, 30);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category:";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(153, 153);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(107, 30);
            lblLocation.TabIndex = 8;
            lblLocation.Text = "Category:";
            // 
            // lblDeadline
            // 
            lblDeadline.AutoSize = true;
            lblDeadline.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeadline.Location = new Point(153, 204);
            lblDeadline.Name = "lblDeadline";
            lblDeadline.Size = new Size(107, 30);
            lblDeadline.TabIndex = 9;
            lblDeadline.Text = "Category:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(374, 106);
            label6.Name = "label6";
            label6.Size = new Size(156, 60);
            label6.TabIndex = 10;
            label6.Text = "Employees for \r\n         the Task:";
            // 
            // lbAssignedEmployees
            // 
            lbAssignedEmployees.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbAssignedEmployees.FormattingEnabled = true;
            lbAssignedEmployees.ItemHeight = 20;
            lbAssignedEmployees.Location = new Point(536, 106);
            lbAssignedEmployees.Name = "lbAssignedEmployees";
            lbAssignedEmployees.Size = new Size(159, 144);
            lbAssignedEmployees.TabIndex = 11;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonDelete.Location = new Point(608, 9);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(87, 70);
            buttonDelete.TabIndex = 12;
            buttonDelete.Text = "Delete Task";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(435, 9);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(155, 70);
            buttonSave.TabIndex = 13;
            buttonSave.Text = "Modify Data";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(144, 26);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(269, 33);
            txtTitle.TabIndex = 14;
            // 
            // cmbCategory
            // 
            cmbCategory.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(145, 92);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(223, 29);
            cmbCategory.TabIndex = 15;
            // 
            // cmbLocation
            // 
            cmbLocation.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Location = new Point(145, 153);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(223, 29);
            cmbLocation.TabIndex = 16;
            // 
            // doneByTextBox
            // 
            doneByTextBox.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doneByTextBox.Location = new Point(144, 205);
            doneByTextBox.Name = "doneByTextBox";
            doneByTextBox.Size = new Size(165, 33);
            doneByTextBox.TabIndex = 17;
            // 
            // TaskDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(707, 704);
            Controls.Add(doneByTextBox);
            Controls.Add(cmbLocation);
            Controls.Add(cmbCategory);
            Controls.Add(txtTitle);
            Controls.Add(buttonSave);
            Controls.Add(buttonDelete);
            Controls.Add(lbAssignedEmployees);
            Controls.Add(label6);
            Controls.Add(lblDeadline);
            Controls.Add(lblLocation);
            Controls.Add(lblCategory);
            Controls.Add(lblTitle);
            Controls.Add(btnMarkAsDone);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TaskDetailsForm";
            Text = "TaskDetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnMarkAsDone;
        private Label label5;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblCategory;
        private Label lblLocation;
        private Label lblDeadline;
        private Label label6;
        private ListBox lbAssignedEmployees;
        private Button buttonDelete;
        private Button buttonSave;
        private TextBox txtTitle;
        private ComboBox cmbCategory;
        private ComboBox cmbLocation;
        private TextBox doneByTextBox;
        private RichTextBox txtDescription;
    }
}