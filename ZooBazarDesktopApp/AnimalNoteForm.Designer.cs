namespace ZooBazarDesktopApp
{
    partial class AnimalNoteForm
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
            btnAddNote = new Button();
            txtBxContent = new RichTextBox();
            txtBxTitle = new TextBox();
            label2 = new Label();
            lblTitle = new Label();
            label1 = new Label();
            lstBxNotes = new ListBox();
            btnNoteDetails = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(btnAddNote);
            panel1.Controls.Add(txtBxContent);
            panel1.Controls.Add(txtBxTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 25);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 383);
            panel1.TabIndex = 0;
            // 
            // btnAddNote
            // 
            btnAddNote.BackColor = SystemColors.Info;
            btnAddNote.Location = new Point(17, 340);
            btnAddNote.Name = "btnAddNote";
            btnAddNote.Size = new Size(324, 33);
            btnAddNote.TabIndex = 6;
            btnAddNote.Text = "Add Report";
            btnAddNote.UseVisualStyleBackColor = false;
            btnAddNote.Click += btnAddNote_Click;
            // 
            // txtBxContent
            // 
            txtBxContent.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxContent.Location = new Point(89, 129);
            txtBxContent.Name = "txtBxContent";
            txtBxContent.Size = new Size(252, 205);
            txtBxContent.TabIndex = 5;
            txtBxContent.Text = "";
            // 
            // txtBxTitle
            // 
            txtBxTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBxTitle.Location = new Point(88, 58);
            txtBxTitle.Name = "txtBxTitle";
            txtBxTitle.Size = new Size(253, 27);
            txtBxTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 3;
            label2.Text = "Context:";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(36, 60);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(46, 21);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 25);
            label1.TabIndex = 0;
            label1.Text = "Add New Entry";
            // 
            // lstBxNotes
            // 
            lstBxNotes.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lstBxNotes.BackColor = SystemColors.Info;
            lstBxNotes.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBxNotes.FormattingEnabled = true;
            lstBxNotes.ItemHeight = 20;
            lstBxNotes.Location = new Point(416, 25);
            lstBxNotes.Name = "lstBxNotes";
            lstBxNotes.Size = new Size(328, 344);
            lstBxNotes.TabIndex = 2;
            // 
            // btnNoteDetails
            // 
            btnNoteDetails.BackColor = SystemColors.Info;
            btnNoteDetails.Location = new Point(416, 375);
            btnNoteDetails.Name = "btnNoteDetails";
            btnNoteDetails.Size = new Size(328, 33);
            btnNoteDetails.TabIndex = 7;
            btnNoteDetails.Text = "Details";
            btnNoteDetails.UseVisualStyleBackColor = false;
            btnNoteDetails.Click += btnNoteDetails_Click;
            // 
            // AnimalNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(756, 420);
            Controls.Add(btnNoteDetails);
            Controls.Add(lstBxNotes);
            Controls.Add(panel1);
            Name = "AnimalNoteForm";
            Text = "AnimalNoteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnAddNote;
        private RichTextBox txtBxContent;
        private TextBox txtBxTitle;
        private Label label2;
        private Label lblTitle;
        private ListBox lstBxNotes;
        private Button btnNoteDetails;
    }
}