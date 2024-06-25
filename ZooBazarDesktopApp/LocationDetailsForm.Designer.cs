namespace ZooBazarDesktopApp
{
    partial class LocationDetailsForm
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
            pbLocation = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbAcceptedSpecies = new ListBox();
            label5 = new Label();
            lblDescription = new Label();
            lblName = new Label();
            lblZone = new Label();
            ((System.ComponentModel.ISupportInitialize)pbLocation).BeginInit();
            SuspendLayout();
            // 
            // pbLocation
            // 
            pbLocation.Location = new Point(34, 44);
            pbLocation.Name = "pbLocation";
            pbLocation.Size = new Size(637, 401);
            pbLocation.TabIndex = 0;
            pbLocation.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.Location = new Point(701, 34);
            label1.Name = "label1";
            label1.Size = new Size(69, 25);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.Location = new Point(701, 76);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 2;
            label2.Text = "Zone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.Location = new Point(701, 112);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 3;
            label3.Text = "Accepted species:";
            // 
            // lbAcceptedSpecies
            // 
            lbAcceptedSpecies.Font = new Font("Segoe UI", 12F);
            lbAcceptedSpecies.FormattingEnabled = true;
            lbAcceptedSpecies.ItemHeight = 21;
            lbAcceptedSpecies.Location = new Point(868, 112);
            lbAcceptedSpecies.Margin = new Padding(1);
            lbAcceptedSpecies.Name = "lbAcceptedSpecies";
            lbAcceptedSpecies.Size = new Size(238, 88);
            lbAcceptedSpecies.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.Location = new Point(701, 218);
            label5.Name = "label5";
            label5.Size = new Size(193, 25);
            label5.TabIndex = 44;
            label5.Text = "Location Description:";
            // 
            // lblDescription
            // 
            lblDescription.BackColor = Color.Transparent;
            lblDescription.Font = new Font("Microsoft Sans Serif", 14F);
            lblDescription.Location = new Point(701, 256);
            lblDescription.Margin = new Padding(1, 0, 1, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(405, 166);
            lblDescription.TabIndex = 45;
            lblDescription.Text = "Description:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Microsoft Sans Serif", 14F);
            lblName.Location = new Point(774, 35);
            lblName.Margin = new Padding(1, 0, 1, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(109, 24);
            lblName.TabIndex = 46;
            lblName.Text = "Description:";
            // 
            // lblZone
            // 
            lblZone.AutoSize = true;
            lblZone.BackColor = Color.Transparent;
            lblZone.Font = new Font("Microsoft Sans Serif", 14F);
            lblZone.Location = new Point(765, 77);
            lblZone.Margin = new Padding(1, 0, 1, 0);
            lblZone.Name = "lblZone";
            lblZone.Size = new Size(109, 24);
            lblZone.TabIndex = 47;
            lblZone.Text = "Description:";
            // 
            // LocationDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1140, 474);
            Controls.Add(lblZone);
            Controls.Add(lblName);
            Controls.Add(lblDescription);
            Controls.Add(label5);
            Controls.Add(lbAcceptedSpecies);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbLocation);
            Name = "LocationDetailsForm";
            Text = "LocationDetailsForm";
            ((System.ComponentModel.ISupportInitialize)pbLocation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbLocation;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox lbAcceptedSpecies;
        private Label label5;
        private Label lblDescription;
        private Label lblName;
        private Label lblZone;
    }
}