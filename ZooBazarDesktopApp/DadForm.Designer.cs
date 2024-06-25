namespace ZooBazarDesktopApp
{
    partial class DadForm
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
            btnSearch = new Button();
            cboLocation = new ComboBox();
            label3 = new Label();
            txtSpecies = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // flpAnimals
            // 
            flpAnimals.Location = new Point(20, 60);
            flpAnimals.Name = "flpAnimals";
            flpAnimals.Size = new Size(1452, 723);
            flpAnimals.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(924, 8);
            btnSearch.Margin = new Padding(1);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 38);
            btnSearch.TabIndex = 14;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cboLocation
            // 
            cboLocation.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cboLocation.FormattingEnabled = true;
            cboLocation.Location = new Point(679, 9);
            cboLocation.Name = "cboLocation";
            cboLocation.Size = new Size(216, 38);
            cboLocation.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(550, 8);
            label3.Name = "label3";
            label3.Size = new Size(136, 40);
            label3.TabIndex = 12;
            label3.Text = "Location:";
            // 
            // txtSpecies
            // 
            txtSpecies.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtSpecies.Location = new Point(392, 13);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(100, 36);
            txtSpecies.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(264, 9);
            label2.Name = "label2";
            label2.Size = new Size(122, 40);
            label2.TabIndex = 10;
            label2.Text = "Species:";
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtID.Location = new Point(69, 14);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 36);
            txtID.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(53, 40);
            label1.TabIndex = 8;
            label1.Text = "ID:";
            // 
            // DadForm
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
            Name = "DadForm";
            Text = "DadForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpAnimals;
        private Button btnSearch;
        private ComboBox cboLocation;
        private Label label3;
        private TextBox txtSpecies;
        private Label label2;
        private TextBox txtID;
        private Label label1;
    }
}