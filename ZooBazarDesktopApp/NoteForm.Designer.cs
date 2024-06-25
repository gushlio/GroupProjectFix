namespace ZooBazarDesktopApp
{
    partial class NoteForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblAuthor = new Label();
            lblTitle = new Label();
            lblContent = new Label();
            btnDelete = new Button();
            lblDate = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 0;
            label1.Text = "Author:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 77);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 1;
            label2.Text = "Note Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 2;
            label3.Text = "Note:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(325, 26);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 3;
            label4.Text = "Date:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAuthor.Location = new Point(96, 38);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(79, 21);
            lblAuthor.TabIndex = 4;
            lblAuthor.Text = "lblAuthor";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(118, 77);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(60, 21);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "lblTitle";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblContent.Location = new Point(80, 126);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(87, 21);
            lblContent.TabIndex = 6;
            lblContent.Text = "lblContent";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(539, 12);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 35);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDate.Location = new Point(391, 26);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(60, 21);
            lblDate.TabIndex = 10;
            lblDate.Text = "lblTitle";
            // 
            // NoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(652, 408);
            Controls.Add(lblDate);
            Controls.Add(btnDelete);
            Controls.Add(lblContent);
            Controls.Add(lblTitle);
            Controls.Add(lblAuthor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NoteForm";
            Text = "NoteForm";
            Load += NoteForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblAuthor;
        private Label lblTitle;
        private Label lblContent;
        private Button btnDelete;
        private Label lblDate;
    }
}