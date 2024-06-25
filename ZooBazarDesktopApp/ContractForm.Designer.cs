namespace ZooBazarDesktopApp
{
    partial class ContractForm
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
            groupBox1 = new GroupBox();
            btnAssign = new Button();
            txtEnd = new TextBox();
            txtStart = new TextBox();
            txtSalary = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            cbJob = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAssign);
            groupBox1.Controls.Add(txtEnd);
            groupBox1.Controls.Add(txtStart);
            groupBox1.Controls.Add(txtSalary);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cbJob);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(83, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 387);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // btnAssign
            // 
            btnAssign.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAssign.Location = new Point(92, 277);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new Size(390, 45);
            btnAssign.TabIndex = 8;
            btnAssign.Text = "Assign Contract";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += button1_Click;
            // 
            // txtEnd
            // 
            txtEnd.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEnd.Location = new Point(216, 225);
            txtEnd.Name = "txtEnd";
            txtEnd.PlaceholderText = "Optional";
            txtEnd.Size = new Size(266, 33);
            txtEnd.TabIndex = 7;
            // 
            // txtStart
            // 
            txtStart.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtStart.Location = new Point(216, 174);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(266, 33);
            txtStart.TabIndex = 6;
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSalary.Location = new Point(216, 121);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(266, 33);
            txtSalary.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(92, 233);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 4;
            label5.Text = "End Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(77, 182);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 3;
            label4.Text = "Start Date:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(111, 129);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Salary:";
            // 
            // cbJob
            // 
            cbJob.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbJob.FormattingEnabled = true;
            cbJob.Location = new Point(216, 67);
            cbJob.Name = "cbJob";
            cbJob.Size = new Size(266, 33);
            cbJob.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(67, 70);
            label2.Name = "label2";
            label2.Size = new Size(120, 25);
            label2.TabIndex = 0;
            label2.Text = "Job Position:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(288, 29);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 1;
            label1.Text = "Assign Contract";
            // 
            // ContractForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 468);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "ContractForm";
            Text = "ContractForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbJob;
        private Label label2;
        private Label label1;
        private Button btnAssign;
        private TextBox txtEnd;
        private TextBox txtStart;
        private TextBox txtSalary;
    }
}