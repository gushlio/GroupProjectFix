namespace ZooBazarDesktopApp
{
    partial class AddReportForm
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
            btnSave = new Button();
            label1 = new Label();
            label2 = new Label();
            btnCancel = new Button();
            txtTitle = new TextBox();
            txtContent = new RichTextBox();
            label3 = new Label();
            comboBoxCategory = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 427);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(669, 67);
            btnSave.TabIndex = 0;
            btnSave.Text = "Submit Report";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(62, 41);
            label1.Name = "label1";
            label1.Size = new Size(77, 37);
            label1.TabIndex = 1;
            label1.Text = "Title:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(18, 164);
            label2.Name = "label2";
            label2.Size = new Size(121, 37);
            label2.TabIndex = 2;
            label2.Text = "Context:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(687, 427);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(101, 67);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(145, 42);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(602, 39);
            txtTitle.TabIndex = 4;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(145, 164);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(602, 245);
            txtContent.TabIndex = 5;
            txtContent.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(3, 102);
            label3.Name = "label3";
            label3.Size = new Size(136, 37);
            label3.TabIndex = 6;
            label3.Text = "Category:";
            // 
            // comboBoxCategory
            // 
            comboBoxCategory.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBoxCategory.FormattingEnabled = true;
            comboBoxCategory.Location = new Point(145, 103);
            comboBoxCategory.Name = "comboBoxCategory";
            comboBoxCategory.Size = new Size(328, 40);
            comboBoxCategory.TabIndex = 7;
            // 
            // AddReportForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 506);
            Controls.Add(comboBoxCategory);
            Controls.Add(label3);
            Controls.Add(txtContent);
            Controls.Add(txtTitle);
            Controls.Add(btnCancel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Name = "AddReportForm";
            Text = "AddReportForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private TextBox txtTitle;
        private RichTextBox txtContent;
        private Label label3;
        private ComboBox comboBoxCategory;
    }
}