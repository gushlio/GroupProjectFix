namespace ZooBazarDesktopApp
{
    partial class AnimalDetails
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
            pbAnimal = new PictureBox();
            btnChangePicture = new Button();
            panel1 = new Panel();
            tbFatherIdModify = new TextBox();
            btnFatherDetails = new Button();
            btnMotherDetails = new Button();
            tbMotherIdModify = new TextBox();
            cbReasonForLeave = new ComboBox();
            cbReasonForEntry = new ComboBox();
            cbSpecies = new ComboBox();
            btnViewNotes = new Button();
            lblFatherId = new Label();
            lblMotherId = new Label();
            lblLocation = new Label();
            lblReasonForLeave = new Label();
            lblReasonForEntry = new Label();
            lblSpecies = new Label();
            lblId = new Label();
            label7 = new Label();
            label6 = new Label();
            btnLocationDetails = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnModify = new Button();
            ((System.ComponentModel.ISupportInitialize)pbAnimal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbAnimal
            // 
            pbAnimal.Location = new Point(105, 52);
            pbAnimal.Name = "pbAnimal";
            pbAnimal.Size = new Size(621, 383);
            pbAnimal.TabIndex = 0;
            pbAnimal.TabStop = false;
            // 
            // btnChangePicture
            // 
            btnChangePicture.BackColor = Color.Transparent;
            btnChangePicture.Font = new Font("Microsoft Sans Serif", 14F);
            btnChangePicture.Location = new Point(105, 451);
            btnChangePicture.Margin = new Padding(1);
            btnChangePicture.Name = "btnChangePicture";
            btnChangePicture.Size = new Size(179, 53);
            btnChangePicture.TabIndex = 25;
            btnChangePicture.Text = "Change Picture";
            btnChangePicture.UseVisualStyleBackColor = false;
            btnChangePicture.Visible = false;
            btnChangePicture.Click += btnChangePicture_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(tbFatherIdModify);
            panel1.Controls.Add(btnFatherDetails);
            panel1.Controls.Add(btnMotherDetails);
            panel1.Controls.Add(tbMotherIdModify);
            panel1.Controls.Add(cbReasonForLeave);
            panel1.Controls.Add(cbReasonForEntry);
            panel1.Controls.Add(cbSpecies);
            panel1.Controls.Add(btnViewNotes);
            panel1.Controls.Add(lblFatherId);
            panel1.Controls.Add(lblMotherId);
            panel1.Controls.Add(lblLocation);
            panel1.Controls.Add(lblReasonForLeave);
            panel1.Controls.Add(lblReasonForEntry);
            panel1.Controls.Add(lblSpecies);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLocationDetails);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(766, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(481, 484);
            panel1.TabIndex = 26;
            // 
            // tbFatherIdModify
            // 
            tbFatherIdModify.Font = new Font("Segoe UI", 14F);
            tbFatherIdModify.Location = new Point(143, 355);
            tbFatherIdModify.Margin = new Padding(1);
            tbFatherIdModify.Name = "tbFatherIdModify";
            tbFatherIdModify.Size = new Size(116, 32);
            tbFatherIdModify.TabIndex = 46;
            tbFatherIdModify.Visible = false;
            // 
            // btnFatherDetails
            // 
            btnFatherDetails.BackColor = Color.Transparent;
            btnFatherDetails.Font = new Font("Microsoft Sans Serif", 14F);
            btnFatherDetails.Location = new Point(263, 351);
            btnFatherDetails.Margin = new Padding(1);
            btnFatherDetails.Name = "btnFatherDetails";
            btnFatherDetails.Size = new Size(169, 32);
            btnFatherDetails.TabIndex = 33;
            btnFatherDetails.Text = "Father Details";
            btnFatherDetails.UseVisualStyleBackColor = false;
            btnFatherDetails.Click += btnFatherDetails_Click;
            // 
            // btnMotherDetails
            // 
            btnMotherDetails.BackColor = Color.Transparent;
            btnMotherDetails.Font = new Font("Microsoft Sans Serif", 14F);
            btnMotherDetails.Location = new Point(263, 309);
            btnMotherDetails.Margin = new Padding(1);
            btnMotherDetails.Name = "btnMotherDetails";
            btnMotherDetails.Size = new Size(169, 32);
            btnMotherDetails.TabIndex = 32;
            btnMotherDetails.Text = "Mother Details";
            btnMotherDetails.UseVisualStyleBackColor = false;
            btnMotherDetails.Click += btnMotherDetails_Click;
            // 
            // tbMotherIdModify
            // 
            tbMotherIdModify.Font = new Font("Segoe UI", 14F);
            tbMotherIdModify.Location = new Point(143, 309);
            tbMotherIdModify.Margin = new Padding(1);
            tbMotherIdModify.Name = "tbMotherIdModify";
            tbMotherIdModify.Size = new Size(116, 32);
            tbMotherIdModify.TabIndex = 45;
            tbMotherIdModify.Visible = false;
            // 
            // cbReasonForLeave
            // 
            cbReasonForLeave.Font = new Font("Segoe UI", 14F);
            cbReasonForLeave.FormattingEnabled = true;
            cbReasonForLeave.Location = new Point(234, 168);
            cbReasonForLeave.Margin = new Padding(1);
            cbReasonForLeave.Name = "cbReasonForLeave";
            cbReasonForLeave.Size = new Size(235, 33);
            cbReasonForLeave.TabIndex = 44;
            cbReasonForLeave.Visible = false;
            // 
            // cbReasonForEntry
            // 
            cbReasonForEntry.Font = new Font("Segoe UI", 14F);
            cbReasonForEntry.FormattingEnabled = true;
            cbReasonForEntry.Location = new Point(197, 120);
            cbReasonForEntry.Margin = new Padding(1);
            cbReasonForEntry.Name = "cbReasonForEntry";
            cbReasonForEntry.Size = new Size(235, 33);
            cbReasonForEntry.TabIndex = 43;
            cbReasonForEntry.Visible = false;
            // 
            // cbSpecies
            // 
            cbSpecies.Font = new Font("Segoe UI", 14F);
            cbSpecies.FormattingEnabled = true;
            cbSpecies.Location = new Point(110, 77);
            cbSpecies.Margin = new Padding(1);
            cbSpecies.Name = "cbSpecies";
            cbSpecies.Size = new Size(235, 33);
            cbSpecies.TabIndex = 42;
            cbSpecies.Visible = false;
            // 
            // btnViewNotes
            // 
            btnViewNotes.Font = new Font("Microsoft Sans Serif", 14F);
            btnViewNotes.Location = new Point(13, 399);
            btnViewNotes.Name = "btnViewNotes";
            btnViewNotes.Size = new Size(456, 76);
            btnViewNotes.TabIndex = 41;
            btnViewNotes.Text = "View Medical Reports";
            btnViewNotes.UseVisualStyleBackColor = true;
            btnViewNotes.Click += btnViewNotes_Click;
            // 
            // lblFatherId
            // 
            lblFatherId.AutoSize = true;
            lblFatherId.BackColor = Color.Transparent;
            lblFatherId.Font = new Font("Microsoft Sans Serif", 14F);
            lblFatherId.ForeColor = SystemColors.ButtonHighlight;
            lblFatherId.Location = new Point(143, 359);
            lblFatherId.Margin = new Padding(1, 0, 1, 0);
            lblFatherId.Name = "lblFatherId";
            lblFatherId.Size = new Size(175, 24);
            lblFatherId.TabIndex = 40;
            lblFatherId.Text = "(no father specified)";
            // 
            // lblMotherId
            // 
            lblMotherId.AutoSize = true;
            lblMotherId.BackColor = Color.Transparent;
            lblMotherId.Font = new Font("Microsoft Sans Serif", 14F);
            lblMotherId.ForeColor = SystemColors.ButtonHighlight;
            lblMotherId.Location = new Point(143, 312);
            lblMotherId.Margin = new Padding(1, 0, 1, 0);
            lblMotherId.Name = "lblMotherId";
            lblMotherId.Size = new Size(188, 24);
            lblMotherId.TabIndex = 39;
            lblMotherId.Text = "(no mother specified)";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.BackColor = Color.Transparent;
            lblLocation.Font = new Font("Microsoft Sans Serif", 14F);
            lblLocation.ForeColor = SystemColors.ButtonHighlight;
            lblLocation.Location = new Point(127, 231);
            lblLocation.Margin = new Padding(1, 0, 1, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(32, 24);
            lblLocation.TabIndex = 38;
            lblLocation.Text = "ID:";
            // 
            // lblReasonForLeave
            // 
            lblReasonForLeave.AutoSize = true;
            lblReasonForLeave.BackColor = Color.Transparent;
            lblReasonForLeave.Font = new Font("Microsoft Sans Serif", 14F);
            lblReasonForLeave.ForeColor = SystemColors.ButtonHighlight;
            lblReasonForLeave.Location = new Point(238, 177);
            lblReasonForLeave.Margin = new Padding(1, 0, 1, 0);
            lblReasonForLeave.Name = "lblReasonForLeave";
            lblReasonForLeave.Size = new Size(107, 24);
            lblReasonForLeave.TabIndex = 37;
            lblReasonForLeave.Text = "Didn't leave";
            // 
            // lblReasonForEntry
            // 
            lblReasonForEntry.AutoSize = true;
            lblReasonForEntry.BackColor = Color.Transparent;
            lblReasonForEntry.Font = new Font("Microsoft Sans Serif", 14F);
            lblReasonForEntry.ForeColor = SystemColors.ButtonHighlight;
            lblReasonForEntry.Location = new Point(197, 129);
            lblReasonForEntry.Margin = new Padding(1, 0, 1, 0);
            lblReasonForEntry.Name = "lblReasonForEntry";
            lblReasonForEntry.Size = new Size(32, 24);
            lblReasonForEntry.TabIndex = 36;
            lblReasonForEntry.Text = "ID:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.BackColor = Color.Transparent;
            lblSpecies.Font = new Font("Microsoft Sans Serif", 14F);
            lblSpecies.ForeColor = SystemColors.ButtonHighlight;
            lblSpecies.Location = new Point(117, 86);
            lblSpecies.Margin = new Padding(1, 0, 1, 0);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(32, 24);
            lblSpecies.TabIndex = 35;
            lblSpecies.Text = "ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.BackColor = Color.Transparent;
            lblId.Font = new Font("Microsoft Sans Serif", 14F);
            lblId.ForeColor = SystemColors.ButtonHighlight;
            lblId.Location = new Point(74, 36);
            lblId.Margin = new Padding(1, 0, 1, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(32, 24);
            lblId.TabIndex = 34;
            lblId.Text = "ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(33, 358);
            label7.Name = "label7";
            label7.Size = new Size(96, 25);
            label7.TabIndex = 31;
            label7.Text = "Father ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(33, 312);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 30;
            label6.Text = "Mother ID:";
            // 
            // btnLocationDetails
            // 
            btnLocationDetails.BackColor = Color.Transparent;
            btnLocationDetails.Font = new Font("Microsoft Sans Serif", 14F);
            btnLocationDetails.Location = new Point(33, 257);
            btnLocationDetails.Margin = new Padding(1);
            btnLocationDetails.Name = "btnLocationDetails";
            btnLocationDetails.Size = new Size(169, 32);
            btnLocationDetails.TabIndex = 29;
            btnLocationDetails.Text = "Location Details";
            btnLocationDetails.UseVisualStyleBackColor = false;
            btnLocationDetails.Click += btnLocationDetails_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(33, 231);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 28;
            label5.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(33, 176);
            label4.Name = "label4";
            label4.Size = new Size(201, 25);
            label4.TabIndex = 27;
            label4.Text = "Reason for Departure:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(33, 128);
            label3.Name = "label3";
            label3.Size = new Size(162, 25);
            label3.TabIndex = 2;
            label3.Text = "Reason For Entry:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(33, 85);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Species:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(33, 35);
            label1.Name = "label1";
            label1.Size = new Size(37, 25);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Transparent;
            btnModify.Font = new Font("Microsoft Sans Serif", 14F);
            btnModify.Location = new Point(431, 451);
            btnModify.Margin = new Padding(1);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(295, 53);
            btnModify.TabIndex = 27;
            btnModify.Text = "Modify Data";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // AnimalDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1259, 563);
            Controls.Add(btnModify);
            Controls.Add(panel1);
            Controls.Add(btnChangePicture);
            Controls.Add(pbAnimal);
            Name = "AnimalDetails";
            Text = "AnimalDetails";
            ((System.ComponentModel.ISupportInitialize)pbAnimal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbAnimal;
        private Button btnChangePicture;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button btnViewNotes;
        private Label lblFatherId;
        private Label lblMotherId;
        private Label lblLocation;
        private Label lblReasonForLeave;
        private Label lblReasonForEntry;
        private Label lblSpecies;
        private Label lblId;
        private Button btnFatherDetails;
        private Button btnMotherDetails;
        private Label label7;
        private Label label6;
        private Button btnLocationDetails;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnModify;
        private ComboBox cbReasonForLeave;
        private ComboBox cbReasonForEntry;
        private ComboBox cbSpecies;
        private TextBox tbFatherIdModify;
        private TextBox tbMotherIdModify;
    }
}