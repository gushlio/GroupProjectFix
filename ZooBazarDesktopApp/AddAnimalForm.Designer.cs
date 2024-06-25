namespace ZooBazarDesktopApp
{
    partial class AddAnimalForm
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
            label10 = new Label();
            label9 = new Label();
            btnChooseFather = new Button();
            btnChooseMother = new Button();
            tbFatherId = new TextBox();
            tbMotherId = new TextBox();
            label8 = new Label();
            label7 = new Label();
            lblLocation = new Label();
            btnSelectImage = new Button();
            tbImgURL = new TextBox();
            cbReasonForEntry = new ComboBox();
            tbDateOfBirth = new TextBox();
            btnSelectSpecies = new Button();
            tbSpecies = new TextBox();
            btnAdd = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(btnChooseFather);
            panel1.Controls.Add(btnChooseMother);
            panel1.Controls.Add(tbFatherId);
            panel1.Controls.Add(tbMotherId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(lblLocation);
            panel1.Controls.Add(btnSelectImage);
            panel1.Controls.Add(tbImgURL);
            panel1.Controls.Add(cbReasonForEntry);
            panel1.Controls.Add(tbDateOfBirth);
            panel1.Controls.Add(btnSelectSpecies);
            panel1.Controls.Add(tbSpecies);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(35, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(512, 435);
            panel1.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ButtonFace;
            label10.Location = new Point(32, 320);
            label10.Name = "label10";
            label10.Size = new Size(68, 20);
            label10.TabIndex = 37;
            label10.Text = "Optional";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(32, 273);
            label9.Name = "label9";
            label9.Size = new Size(68, 20);
            label9.TabIndex = 36;
            label9.Text = "Optional";
            // 
            // btnChooseFather
            // 
            btnChooseFather.Font = new Font("Microsoft Sans Serif", 12F);
            btnChooseFather.Location = new Point(393, 307);
            btnChooseFather.Margin = new Padding(1);
            btnChooseFather.Name = "btnChooseFather";
            btnChooseFather.Size = new Size(101, 33);
            btnChooseFather.TabIndex = 35;
            btnChooseFather.Text = "Select";
            btnChooseFather.UseVisualStyleBackColor = true;
            btnChooseFather.Click += btnChooseFather_Click;
            // 
            // btnChooseMother
            // 
            btnChooseMother.Font = new Font("Microsoft Sans Serif", 12F);
            btnChooseMother.Location = new Point(393, 264);
            btnChooseMother.Margin = new Padding(1);
            btnChooseMother.Name = "btnChooseMother";
            btnChooseMother.Size = new Size(100, 32);
            btnChooseMother.TabIndex = 34;
            btnChooseMother.Text = "Select";
            btnChooseMother.UseVisualStyleBackColor = true;
            btnChooseMother.Click += btnChooseMother_Click;
            // 
            // tbFatherId
            // 
            tbFatherId.Font = new Font("Microsoft Sans Serif", 14F);
            tbFatherId.Location = new Point(190, 311);
            tbFatherId.Margin = new Padding(1);
            tbFatherId.Name = "tbFatherId";
            tbFatherId.Size = new Size(201, 29);
            tbFatherId.TabIndex = 33;
            // 
            // tbMotherId
            // 
            tbMotherId.Font = new Font("Microsoft Sans Serif", 14F);
            tbMotherId.Location = new Point(190, 267);
            tbMotherId.Margin = new Padding(1);
            tbMotherId.Name = "tbMotherId";
            tbMotherId.Size = new Size(201, 29);
            tbMotherId.TabIndex = 32;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(111, 315);
            label8.Name = "label8";
            label8.Size = new Size(66, 25);
            label8.TabIndex = 31;
            label8.Text = "Father";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(106, 271);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 30;
            label7.Text = "Mother";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLocation.Location = new Point(192, 187);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(107, 25);
            lblLocation.TabIndex = 29;
            lblLocation.Text = "<location>";
            // 
            // btnSelectImage
            // 
            btnSelectImage.Font = new Font("Microsoft Sans Serif", 12F);
            btnSelectImage.Location = new Point(394, 223);
            btnSelectImage.Margin = new Padding(1);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(100, 32);
            btnSelectImage.TabIndex = 28;
            btnSelectImage.Text = "Select";
            btnSelectImage.UseVisualStyleBackColor = true;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // tbImgURL
            // 
            tbImgURL.Font = new Font("Microsoft Sans Serif", 14F);
            tbImgURL.Location = new Point(190, 226);
            tbImgURL.Margin = new Padding(1);
            tbImgURL.Name = "tbImgURL";
            tbImgURL.ReadOnly = true;
            tbImgURL.Size = new Size(202, 29);
            tbImgURL.TabIndex = 27;
            // 
            // cbReasonForEntry
            // 
            cbReasonForEntry.Font = new Font("Microsoft Sans Serif", 14F);
            cbReasonForEntry.FormattingEnabled = true;
            cbReasonForEntry.Location = new Point(190, 141);
            cbReasonForEntry.Margin = new Padding(1);
            cbReasonForEntry.Name = "cbReasonForEntry";
            cbReasonForEntry.Size = new Size(296, 32);
            cbReasonForEntry.TabIndex = 26;
            // 
            // tbDateOfBirth
            // 
            tbDateOfBirth.Font = new Font("Microsoft Sans Serif", 14F);
            tbDateOfBirth.Location = new Point(190, 91);
            tbDateOfBirth.Margin = new Padding(1);
            tbDateOfBirth.Name = "tbDateOfBirth";
            tbDateOfBirth.PlaceholderText = "dd-mm-yyyy";
            tbDateOfBirth.Size = new Size(201, 29);
            tbDateOfBirth.TabIndex = 24;
            // 
            // btnSelectSpecies
            // 
            btnSelectSpecies.Font = new Font("Microsoft Sans Serif", 12F);
            btnSelectSpecies.Location = new Point(393, 38);
            btnSelectSpecies.Margin = new Padding(1);
            btnSelectSpecies.Name = "btnSelectSpecies";
            btnSelectSpecies.Size = new Size(100, 32);
            btnSelectSpecies.TabIndex = 23;
            btnSelectSpecies.Text = "Select";
            btnSelectSpecies.UseVisualStyleBackColor = true;
            btnSelectSpecies.Click += btnSelectSpecies_Click;
            // 
            // tbSpecies
            // 
            tbSpecies.Font = new Font("Microsoft Sans Serif", 14F);
            tbSpecies.Location = new Point(190, 41);
            tbSpecies.Margin = new Padding(1);
            tbSpecies.Name = "tbSpecies";
            tbSpecies.Size = new Size(201, 29);
            tbSpecies.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            btnAdd.Location = new Point(24, 363);
            btnAdd.Margin = new Padding(1);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(462, 53);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(115, 228);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 4;
            label6.Text = "Image:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(96, 187);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 3;
            label5.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 141);
            label4.Name = "label4";
            label4.Size = new Size(162, 25);
            label4.TabIndex = 2;
            label4.Text = "Reason For Entry:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 93);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 1;
            label3.Text = "Date of Birth:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(106, 45);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 0;
            label2.Text = "Species:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(204, 22);
            label1.Name = "label1";
            label1.Size = new Size(164, 36);
            label1.TabIndex = 1;
            label1.Text = "New Animal";
            // 
            // AddAnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(573, 536);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "AddAnimalForm";
            Text = "AddAnimalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnSelectImage;
        private TextBox tbImgURL;
        private ComboBox cbReasonForEntry;
        private TextBox tbDateOfBirth;
        private Button btnSelectSpecies;
        private TextBox tbSpecies;
        private Label lblLocation;
        private Label label8;
        private Label label7;
        private Label label10;
        private Label label9;
        private Button btnChooseFather;
        private Button btnChooseMother;
        private TextBox tbFatherId;
        private TextBox tbMotherId;
    }
}