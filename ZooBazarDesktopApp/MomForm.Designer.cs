namespace ZooBazarDesktopApp
{
    partial class MomForm
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
            flpAnimals = new FlowLayoutPanel();
            label1 = new Label();
            txtID = new TextBox();
            label2 = new Label();
            txtSpecies = new TextBox();
            label3 = new Label();
            cboLocation = new ComboBox();
            btnSearch = new Button();
            SuspendLayout();
            // 
            // flpAnimals
            // 
            flpAnimals.Location = new Point(12, 69);
            flpAnimals.Name = "flpAnimals";
            flpAnimals.Size = new Size(1452, 723);
            flpAnimals.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 40);
            label1.TabIndex = 1;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtID.Location = new Point(61, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 36);
            txtID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(256, 21);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 3;
            label2.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtSpecies.Location = new Point(384, 25);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(100, 36);
            txtSpecies.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(542, 20);
            label3.Name = "label3";
            label3.Size = new Size(136, 40);
            label3.TabIndex = 5;
            label3.Text = "Location:";
            // 
            // cboLocation
            // 
            cboLocation.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboLocation.FormattingEnabled = true;
            cboLocation.Location = new Point(671, 21);
            cboLocation.Name = "cboLocation";
            cboLocation.Size = new Size(216, 38);
            cboLocation.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(916, 20);
            btnSearch.Margin = new Padding(1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 38);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // MomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1484, 795);
            Controls.Add(btnSearch);
            Controls.Add(cboLocation);
            Controls.Add(label3);
            Controls.Add(txtSpecies);
            Controls.Add(label2);
            Controls.Add(txtID);
            Controls.Add(label1);
            Controls.Add(flpAnimals);
            Name = "MomForm";
            Text = "MomForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpAnimals;
        private Label label1;
        private TextBox txtID;
        private Label label2;
        private TextBox txtSpecies;
        private Label label3;
        private ComboBox cboLocation;
        private Button btnSearch;
    }
}