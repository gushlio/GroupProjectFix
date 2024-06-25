namespace ZooBazarDesktopApp
{
    partial class AnimalDetailsForm
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
            button1 = new Button();
            panel1 = new Panel();
            btnFatherDetails = new Button();
            tbFatherIdModify = new TextBox();
            lblFatherId = new Label();
            btnMotherDetails = new Button();
            tbMotherIdModify = new TextBox();
            lblMotherId = new Label();
            label7 = new Label();
            label6 = new Label();
            btnModify = new Button();
            btnViewNotes = new Button();
            btnLocationDetails = new Button();
            cbReasonForLeave = new ComboBox();
            cbReasonForEntry = new ComboBox();
            cbSpecies = new ComboBox();
            lblLocation = new Label();
            lblReasonForLeave = new Label();
            lblReasonForEntry = new Label();
            lblSpecies = new Label();
            lblId = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pbAnimal).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pbAnimal
            // 
            pbAnimal.BackgroundImageLayout = ImageLayout.Stretch;
            pbAnimal.Location = new Point(42, 50);
            pbAnimal.Name = "pbAnimal";
            pbAnimal.Size = new Size(637, 401);
            pbAnimal.TabIndex = 0;
            pbAnimal.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(42, 464);
            button1.Name = "button1";
            button1.Size = new Size(235, 61);
            button1.TabIndex = 1;
            button1.Text = "Change Image";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Controls.Add(btnFatherDetails);
            panel1.Controls.Add(tbFatherIdModify);
            panel1.Controls.Add(lblFatherId);
            panel1.Controls.Add(btnViewNotes);
            panel1.Controls.Add(btnMotherDetails);
            panel1.Controls.Add(tbMotherIdModify);
            panel1.Controls.Add(lblMotherId);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnLocationDetails);
            panel1.Controls.Add(cbReasonForLeave);
            panel1.Controls.Add(cbReasonForEntry);
            panel1.Controls.Add(cbSpecies);
            panel1.Controls.Add(lblLocation);
            panel1.Controls.Add(lblReasonForLeave);
            panel1.Controls.Add(lblReasonForEntry);
            panel1.Controls.Add(lblSpecies);
            panel1.Controls.Add(lblId);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(714, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 520);
            panel1.TabIndex = 2;
            // 
            // btnFatherDetails
            // 
            btnFatherDetails.BackColor = Color.Transparent;
            btnFatherDetails.Font = new Font("Microsoft Sans Serif", 14F);
            btnFatherDetails.Location = new Point(304, 348);
            btnFatherDetails.Margin = new Padding(1);
            btnFatherDetails.Name = "btnFatherDetails";
            btnFatherDetails.Size = new Size(169, 32);
            btnFatherDetails.TabIndex = 38;
            btnFatherDetails.Text = "Father Details";
            btnFatherDetails.UseVisualStyleBackColor = false;
            // 
            // tbFatherIdModify
            // 
            tbFatherIdModify.Font = new Font("Segoe UI", 14F);
            tbFatherIdModify.Location = new Point(154, 351);
            tbFatherIdModify.Margin = new Padding(1);
            tbFatherIdModify.Name = "tbFatherIdModify";
            tbFatherIdModify.Size = new Size(134, 32);
            tbFatherIdModify.TabIndex = 37;
            tbFatherIdModify.Visible = false;
            // 
            // lblFatherId
            // 
            lblFatherId.AutoSize = true;
            lblFatherId.BackColor = Color.Transparent;
            lblFatherId.Font = new Font("Microsoft Sans Serif", 14F);
            lblFatherId.Location = new Point(211, 351);
            lblFatherId.Margin = new Padding(1, 0, 1, 0);
            lblFatherId.Name = "lblFatherId";
            lblFatherId.Size = new Size(175, 24);
            lblFatherId.TabIndex = 39;
            lblFatherId.Text = "(no father specified)";
            // 
            // btnMotherDetails
            // 
            btnMotherDetails.BackColor = Color.Transparent;
            btnMotherDetails.Font = new Font("Microsoft Sans Serif", 14F);
            btnMotherDetails.Location = new Point(304, 309);
            btnMotherDetails.Margin = new Padding(1);
            btnMotherDetails.Name = "btnMotherDetails";
            btnMotherDetails.Size = new Size(169, 32);
            btnMotherDetails.TabIndex = 35;
            btnMotherDetails.Text = "Mother Details";
            btnMotherDetails.UseVisualStyleBackColor = false;
            // 
            // tbMotherIdModify
            // 
            tbMotherIdModify.Font = new Font("Segoe UI", 14F);
            tbMotherIdModify.Location = new Point(154, 309);
            tbMotherIdModify.Margin = new Padding(1);
            tbMotherIdModify.Name = "tbMotherIdModify";
            tbMotherIdModify.Size = new Size(134, 32);
            tbMotherIdModify.TabIndex = 34;
            tbMotherIdModify.Visible = false;
            // 
            // lblMotherId
            // 
            lblMotherId.AutoSize = true;
            lblMotherId.BackColor = Color.Transparent;
            lblMotherId.Font = new Font("Microsoft Sans Serif", 14F);
            lblMotherId.Location = new Point(154, 309);
            lblMotherId.Margin = new Padding(1, 0, 1, 0);
            lblMotherId.Name = "lblMotherId";
            lblMotherId.Size = new Size(188, 24);
            lblMotherId.TabIndex = 36;
            lblMotherId.Text = "(no mother specified)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label7.Location = new Point(20, 350);
            label7.Name = "label7";
            label7.Size = new Size(108, 30);
            label7.TabIndex = 33;
            label7.Text = "Father ID:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label6.Location = new Point(20, 304);
            label6.Name = "label6";
            label6.Size = new Size(120, 30);
            label6.TabIndex = 32;
            label6.Text = "Mother ID:";
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.Transparent;
            btnModify.Font = new Font("Microsoft Sans Serif", 14F);
            btnModify.Location = new Point(281, 464);
            btnModify.Margin = new Padding(1);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(242, 61);
            btnModify.TabIndex = 31;
            btnModify.Text = "Modify Animal Data";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnViewNotes
            // 
            btnViewNotes.BackColor = Color.DarkSeaGreen;
            btnViewNotes.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnViewNotes.ForeColor = SystemColors.ButtonHighlight;
            btnViewNotes.Location = new Point(20, 396);
            btnViewNotes.Name = "btnViewNotes";
            btnViewNotes.Size = new Size(453, 99);
            btnViewNotes.TabIndex = 30;
            btnViewNotes.Text = "View Medical  Reports on Animal";
            btnViewNotes.UseVisualStyleBackColor = false;
            btnViewNotes.Click += btnViewNotes_Click;
            // 
            // btnLocationDetails
            // 
            btnLocationDetails.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLocationDetails.Location = new Point(20, 245);
            btnLocationDetails.Name = "btnLocationDetails";
            btnLocationDetails.Size = new Size(226, 37);
            btnLocationDetails.TabIndex = 3;
            btnLocationDetails.Text = "Location Details";
            btnLocationDetails.UseVisualStyleBackColor = true;
            btnLocationDetails.Click += btnLocationDetails_Click;
            // 
            // cbReasonForLeave
            // 
            cbReasonForLeave.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReasonForLeave.FormattingEnabled = true;
            cbReasonForLeave.Location = new Point(261, 163);
            cbReasonForLeave.Name = "cbReasonForLeave";
            cbReasonForLeave.Size = new Size(230, 33);
            cbReasonForLeave.TabIndex = 12;
            // 
            // cbReasonForEntry
            // 
            cbReasonForEntry.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbReasonForEntry.FormattingEnabled = true;
            cbReasonForEntry.Location = new Point(211, 121);
            cbReasonForEntry.Name = "cbReasonForEntry";
            cbReasonForEntry.Size = new Size(233, 33);
            cbReasonForEntry.TabIndex = 11;
            // 
            // cbSpecies
            // 
            cbSpecies.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbSpecies.FormattingEnabled = true;
            cbSpecies.Location = new Point(118, 75);
            cbSpecies.Name = "cbSpecies";
            cbSpecies.Size = new Size(214, 33);
            cbSpecies.TabIndex = 10;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblLocation.Location = new Point(129, 212);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(40, 30);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "ID:";
            // 
            // lblReasonForLeave
            // 
            lblReasonForLeave.AutoSize = true;
            lblReasonForLeave.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblReasonForLeave.Location = new Point(261, 166);
            lblReasonForLeave.Name = "lblReasonForLeave";
            lblReasonForLeave.Size = new Size(40, 30);
            lblReasonForLeave.TabIndex = 8;
            lblReasonForLeave.Text = "ID:";
            // 
            // lblReasonForEntry
            // 
            lblReasonForEntry.AutoSize = true;
            lblReasonForEntry.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblReasonForEntry.Location = new Point(215, 120);
            lblReasonForEntry.Name = "lblReasonForEntry";
            lblReasonForEntry.Size = new Size(40, 30);
            lblReasonForEntry.TabIndex = 7;
            lblReasonForEntry.Text = "ID:";
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblSpecies.Location = new Point(118, 75);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(40, 30);
            lblSpecies.TabIndex = 6;
            lblSpecies.Text = "ID:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            lblId.Location = new Point(72, 32);
            lblId.Name = "lblId";
            lblId.Size = new Size(40, 30);
            lblId.TabIndex = 5;
            lblId.Text = "ID:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label5.Location = new Point(20, 212);
            label5.Name = "label5";
            label5.Size = new Size(103, 30);
            label5.TabIndex = 4;
            label5.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label4.Location = new Point(20, 166);
            label4.Name = "label4";
            label4.Size = new Size(235, 30);
            label4.TabIndex = 3;
            label4.Text = "Reason For Departure:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label3.Location = new Point(20, 120);
            label3.Name = "label3";
            label3.Size = new Size(185, 30);
            label3.TabIndex = 2;
            label3.Text = "Reason For Entry:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label2.Location = new Point(20, 75);
            label2.Name = "label2";
            label2.Size = new Size(92, 30);
            label2.TabIndex = 1;
            label2.Text = "Species:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            label1.Location = new Point(20, 32);
            label1.Name = "label1";
            label1.Size = new Size(40, 30);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // AnimalDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1233, 582);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(pbAnimal);
            Controls.Add(btnModify);
            Name = "AnimalDetailsForm";
            Text = "AnimalDetailsForm";
            ((System.ComponentModel.ISupportInitialize)pbAnimal).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbAnimal;
        private Button button1;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnLocationDetails;
        private ComboBox cbReasonForLeave;
        private ComboBox cbReasonForEntry;
        private ComboBox cbSpecies;
        private Label lblLocation;
        private Label lblReasonForLeave;
        private Label lblReasonForEntry;
        private Label lblSpecies;
        private Label lblId;
        private Button btnModify;
        private Button btnViewNotes;
        private Label label6;
        private Label label7;
        private Button btnMotherDetails;
        private TextBox tbMotherIdModify;
        private Button btnFatherDetails;
        private TextBox tbFatherIdModify;
        private Label lblFatherId;
        private Label lblMotherId;
    }
}