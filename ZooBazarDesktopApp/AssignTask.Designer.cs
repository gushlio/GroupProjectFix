namespace ZooBazarDesktopApp
{
    partial class AssignTask
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
            taskTitleTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            doneByTextBox = new TextBox();
            categoryComboBox = new ComboBox();
            lbEmployees = new ListBox();
            groupBox1 = new GroupBox();
            locationComboBox = new ComboBox();
            contextTextBox = new RichTextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // taskTitleTextBox
            // 
            taskTitleTextBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            taskTitleTextBox.Location = new Point(157, 83);
            taskTitleTextBox.Name = "taskTitleTextBox";
            taskTitleTextBox.Size = new Size(323, 36);
            taskTitleTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(211, 19);
            label1.Name = "label1";
            label1.Size = new Size(393, 45);
            label1.TabIndex = 1;
            label1.Text = "Assign Task To Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(41, 89);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 2;
            label2.Text = "Task Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(41, 190);
            label3.Name = "label3";
            label3.Size = new Size(109, 30);
            label3.TabIndex = 3;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(47, 257);
            label4.Name = "label4";
            label4.Size = new Size(103, 30);
            label4.TabIndex = 4;
            label4.Text = "Location:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(49, 303);
            label5.Name = "label5";
            label5.Size = new Size(97, 30);
            label5.TabIndex = 5;
            label5.Text = "Context:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(49, 134);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 6;
            label6.Text = "Done by:";
            // 
            // doneByTextBox
            // 
            doneByTextBox.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            doneByTextBox.Location = new Point(157, 134);
            doneByTextBox.Name = "doneByTextBox";
            doneByTextBox.Size = new Size(323, 36);
            doneByTextBox.TabIndex = 7;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(156, 190);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(324, 38);
            categoryComboBox.TabIndex = 8;
            // 
            // lbEmployees
            // 
            lbEmployees.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold);
            lbEmployees.FormattingEnabled = true;
            lbEmployees.ItemHeight = 20;
            lbEmployees.Location = new Point(21, 33);
            lbEmployees.Name = "lbEmployees";
            lbEmployees.Size = new Size(258, 384);
            lbEmployees.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lbEmployees);
            groupBox1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(544, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(285, 424);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employees";
            // 
            // locationComboBox
            // 
            locationComboBox.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locationComboBox.FormattingEnabled = true;
            locationComboBox.Location = new Point(157, 254);
            locationComboBox.Name = "locationComboBox";
            locationComboBox.Size = new Size(324, 38);
            locationComboBox.TabIndex = 11;
            // 
            // contextTextBox
            // 
            contextTextBox.Location = new Point(152, 303);
            contextTextBox.Name = "contextTextBox";
            contextTextBox.Size = new Size(328, 188);
            contextTextBox.TabIndex = 12;
            contextTextBox.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.FloralWhite;
            button1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 507);
            button1.Name = "button1";
            button1.Size = new Size(811, 60);
            button1.TabIndex = 13;
            button1.Text = "Assign Task";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AssignTask
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(841, 579);
            Controls.Add(button1);
            Controls.Add(contextTextBox);
            Controls.Add(locationComboBox);
            Controls.Add(groupBox1);
            Controls.Add(categoryComboBox);
            Controls.Add(doneByTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(taskTitleTextBox);
            Name = "AssignTask";
            Text = "AssignTask";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taskTitleTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox doneByTextBox;
        private ComboBox categoryComboBox;
        private ListBox lbEmployees;
        private GroupBox groupBox1;
        private ComboBox locationComboBox;
        private RichTextBox contextTextBox;
        private Button button1;
    }
}