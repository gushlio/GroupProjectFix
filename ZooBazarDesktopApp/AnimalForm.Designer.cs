namespace ZooBazarDesktopApp
{
    partial class AnimalForm
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
            cbLocation = new ComboBox();
            label3 = new Label();
            tbSpecies = new TextBox();
            label2 = new Label();
            tbId = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnHistory = new Button();
            btnGoBack = new Button();
            flpAnimals = new FlowLayoutPanel();
            btnSearch = new Button();
            btnAdd = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(cbLocation);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbSpecies);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbId);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(62, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 54);
            panel1.TabIndex = 0;
            // 
            // cbLocation
            // 
            cbLocation.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbLocation.FormattingEnabled = true;
            cbLocation.Location = new Point(588, 12);
            cbLocation.Name = "cbLocation";
            cbLocation.Size = new Size(207, 33);
            cbLocation.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(492, 17);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 4;
            label3.Text = "Location:";
            // 
            // tbSpecies
            // 
            tbSpecies.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbSpecies.Location = new Point(355, 12);
            tbSpecies.Name = "tbSpecies";
            tbSpecies.Size = new Size(104, 33);
            tbSpecies.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(269, 17);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 2;
            label2.Text = "Species:";
            // 
            // tbId
            // 
            tbId.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbId.Location = new Point(121, 12);
            tbId.Name = "tbId";
            tbId.Size = new Size(104, 33);
            tbId.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(14, 17);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 0;
            label1.Text = "Animal ID:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(btnHistory);
            panel2.Controls.Add(btnGoBack);
            panel2.Controls.Add(flpAnimals);
            panel2.Location = new Point(62, 145);
            panel2.Name = "panel2";
            panel2.Size = new Size(1275, 616);
            panel2.TabIndex = 1;
            // 
            // btnHistory
            // 
            btnHistory.Font = new Font("Microsoft Sans Serif", 12F);
            btnHistory.Location = new Point(1028, 8);
            btnHistory.Margin = new Padding(1);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(125, 30);
            btnHistory.TabIndex = 14;
            btnHistory.Text = "Out of zoo";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Visible = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnGoBack
            // 
            btnGoBack.Font = new Font("Microsoft Sans Serif", 12F);
            btnGoBack.Location = new Point(1028, 8);
            btnGoBack.Margin = new Padding(1);
            btnGoBack.Name = "btnGoBack";
            btnGoBack.Size = new Size(125, 30);
            btnGoBack.TabIndex = 13;
            btnGoBack.Text = "In the zoo";
            btnGoBack.UseVisualStyleBackColor = true;
            btnGoBack.Visible = false;
            btnGoBack.Click += btnGoBack_Click;
            // 
            // flpAnimals
            // 
            flpAnimals.Location = new Point(14, 42);
            flpAnimals.Name = "flpAnimals";
            flpAnimals.Size = new Size(1242, 557);
            flpAnimals.TabIndex = 0;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(879, 74);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(104, 54);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(1009, 74);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 54);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add New Animal";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.ForestGreen;
            label4.Location = new Point(554, 19);
            label4.Name = "label4";
            label4.Size = new Size(242, 37);
            label4.TabIndex = 4;
            label4.Text = "Animals Manager";
            // 
            // AnimalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1349, 773);
            Controls.Add(label4);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AnimalForm";
            Text = "AnimalForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ComboBox cbLocation;
        private Label label3;
        private TextBox tbSpecies;
        private Label label2;
        private TextBox tbId;
        private Label label1;
        private Panel panel2;
        private Button btnGoBack;
        private FlowLayoutPanel flpAnimals;
        private Button btnSearch;
        private Button btnAdd;
        private Label label4;
        private Button btnHistory;
    }
}