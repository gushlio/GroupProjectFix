namespace ZooBazarDesktopApp
{
    partial class ReportDetailsForm
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
            lblTitle = new Label();
            panel2 = new Panel();
            lblEmp = new Label();
            label1 = new Label();
            lblCategory = new Label();
            lblDateCreated = new Label();
            lblDescription = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(lblTitle);
            panel1.Location = new Point(37, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(631, 62);
            panel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(17, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(76, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lblEmp);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lblCategory);
            panel2.Controls.Add(lblDateCreated);
            panel2.Controls.Add(lblDescription);
            panel2.Location = new Point(37, 99);
            panel2.Name = "panel2";
            panel2.Size = new Size(631, 483);
            panel2.TabIndex = 1;
            // 
            // lblEmp
            // 
            lblEmp.AutoSize = true;
            lblEmp.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblEmp.Location = new Point(161, 433);
            lblEmp.Name = "lblEmp";
            lblEmp.Size = new Size(70, 30);
            lblEmp.TabIndex = 6;
            lblEmp.Text = "label1";
            lblEmp.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(3, 433);
            label1.Name = "label1";
            label1.Size = new Size(152, 30);
            label1.TabIndex = 5;
            label1.Text = "Submitted by:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(161, 87);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(76, 32);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "label1";
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDateCreated.Location = new Point(191, 21);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(76, 32);
            lblDateCreated.TabIndex = 3;
            lblDateCreated.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(161, 161);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(76, 32);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 7;
            label2.Text = "Submitted on:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 87);
            label3.Name = "label3";
            label3.Size = new Size(120, 32);
            label3.TabIndex = 8;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 161);
            label4.Name = "label4";
            label4.Size = new Size(106, 32);
            label4.TabIndex = 9;
            label4.Text = "Context:";
            // 
            // ReportDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(693, 628);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ReportDetailsForm";
            Text = "ReportDetailsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblTitle;
        private Panel panel2;
        private Label lblDescription;
        private Label lblDateCreated;
        private Label lblCategory;
        private Label lblEmp;
        private Label label1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}