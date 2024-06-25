namespace ZooBazarDesktopApp
{
    partial class VetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VetForm));
            panel1 = new Panel();
            button1 = new Button();
            cmbAnimals = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txtVetName = new TextBox();
            txtDateVet = new TextBox();
            label3 = new Label();
            txtTimeVet = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            txtSearchSpecies = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtSearchDate = new TextBox();
            txtSearchTime = new TextBox();
            btnSearch = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTimeVet);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtDateVet);
            panel1.Controls.Add(txtVetName);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbAnimals);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(25, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 254);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(276, 173);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(253, 56);
            button1.TabIndex = 0;
            button1.Text = "Add Appointment";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // cmbAnimals
            // 
            cmbAnimals.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbAnimals.FormattingEnabled = true;
            cmbAnimals.Location = new Point(122, 30);
            cmbAnimals.Margin = new Padding(3, 2, 3, 2);
            cmbAnimals.Name = "cmbAnimals";
            cmbAnimals.Size = new Size(299, 38);
            cmbAnimals.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(31, 39);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 4;
            label1.Text = "Animals:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(16, 100);
            label2.Name = "label2";
            label2.Size = new Size(100, 25);
            label2.TabIndex = 5;
            label2.Text = "Vet Name:";
            // 
            // txtVetName
            // 
            txtVetName.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtVetName.Location = new Point(122, 100);
            txtVetName.Margin = new Padding(3, 2, 3, 2);
            txtVetName.Multiline = true;
            txtVetName.Name = "txtVetName";
            txtVetName.Size = new Size(299, 32);
            txtVetName.TabIndex = 13;
            // 
            // txtDateVet
            // 
            txtDateVet.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDateVet.Location = new Point(548, 34);
            txtDateVet.Margin = new Padding(3, 2, 3, 2);
            txtDateVet.Multiline = true;
            txtDateVet.Name = "txtDateVet";
            txtDateVet.Size = new Size(302, 32);
            txtDateVet.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(485, 43);
            label3.Name = "label3";
            label3.Size = new Size(57, 25);
            label3.TabIndex = 17;
            label3.Text = "Date:";
            // 
            // txtTimeVet
            // 
            txtTimeVet.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTimeVet.Location = new Point(548, 100);
            txtTimeVet.Margin = new Padding(3, 2, 3, 2);
            txtTimeVet.Multiline = true;
            txtTimeVet.Name = "txtTimeVet";
            txtTimeVet.Size = new Size(302, 32);
            txtTimeVet.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(485, 107);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 19;
            label4.Text = "Time:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearchTime);
            panel2.Controls.Add(txtSearchDate);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtSearchSpecies);
            panel2.Location = new Point(910, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(361, 254);
            panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Location = new Point(-5, 344);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1291, 340);
            flowLayoutPanel1.TabIndex = 20;
            // 
            // txtSearchSpecies
            // 
            txtSearchSpecies.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            txtSearchSpecies.Location = new Point(134, 26);
            txtSearchSpecies.Margin = new Padding(3, 2, 3, 2);
            txtSearchSpecies.Multiline = true;
            txtSearchSpecies.Name = "txtSearchSpecies";
            txtSearchSpecies.Size = new Size(211, 31);
            txtSearchSpecies.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(33, 34);
            label5.Name = "label5";
            label5.Size = new Size(80, 25);
            label5.TabIndex = 20;
            label5.Text = "Species:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(56, 87);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 20;
            label6.Text = "Date:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(56, 149);
            label7.Name = "label7";
            label7.Size = new Size(59, 25);
            label7.TabIndex = 20;
            label7.Text = "Time:";
            // 
            // txtSearchDate
            // 
            txtSearchDate.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            txtSearchDate.Location = new Point(134, 79);
            txtSearchDate.Margin = new Padding(3, 2, 3, 2);
            txtSearchDate.Multiline = true;
            txtSearchDate.Name = "txtSearchDate";
            txtSearchDate.Size = new Size(211, 32);
            txtSearchDate.TabIndex = 20;
            // 
            // txtSearchTime
            // 
            txtSearchTime.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            txtSearchTime.Location = new Point(134, 141);
            txtSearchTime.Margin = new Padding(3, 2, 3, 2);
            txtSearchTime.Multiline = true;
            txtSearchTime.Name = "txtSearchTime";
            txtSearchTime.Size = new Size(211, 33);
            txtSearchTime.TabIndex = 22;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(247, 255, 221);
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(208, 227, 204);
            btnSearch.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 227, 204);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10.8F);
            btnSearch.Location = new Point(91, 194);
            btnSearch.Margin = new Padding(3, 2, 3, 2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(189, 46);
            btnSearch.TabIndex = 23;
            btnSearch.Text = "Search Appointment";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // VetForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1283, 682);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "VetForm";
            Text = "VetForm";
            Load += VetForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label1;
        private ComboBox cmbAnimals;
        private Label label4;
        private TextBox txtTimeVet;
        private Label label3;
        private TextBox txtDateVet;
        private TextBox txtVetName;
        private Label label2;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSearch;
        private TextBox txtSearchTime;
        private TextBox txtSearchDate;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtSearchSpecies;
    }
}