namespace ZooBazarDesktopApp
{
    partial class HomeForm
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
            listBoxReports = new ListBox();
            btnAddReport = new Button();
            btnViewDetails = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxReports
            // 
            listBoxReports.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            listBoxReports.FormattingEnabled = true;
            listBoxReports.ItemHeight = 30;
            listBoxReports.Location = new Point(24, 38);
            listBoxReports.Name = "listBoxReports";
            listBoxReports.Size = new Size(796, 424);
            listBoxReports.TabIndex = 1;
            // 
            // btnAddReport
            // 
            btnAddReport.ForeColor = SystemColors.ActiveCaptionText;
            btnAddReport.Location = new Point(826, 38);
            btnAddReport.Name = "btnAddReport";
            btnAddReport.Size = new Size(157, 79);
            btnAddReport.TabIndex = 3;
            btnAddReport.Text = "Submit Report";
            btnAddReport.UseVisualStyleBackColor = true;
            btnAddReport.Click += btnAddReport_Click;
            // 
            // btnViewDetails
            // 
            btnViewDetails.ForeColor = SystemColors.ActiveCaptionText;
            btnViewDetails.Location = new Point(24, 468);
            btnViewDetails.Name = "btnViewDetails";
            btnViewDetails.Size = new Size(796, 52);
            btnViewDetails.TabIndex = 4;
            btnViewDetails.Text = "View Report Details";
            btnViewDetails.UseVisualStyleBackColor = true;
            btnViewDetails.Click += btnViewDetails_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1690, 126);
            panel1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(781, 38);
            label1.Name = "label1";
            label1.Size = new Size(216, 47);
            label1.TabIndex = 0;
            label1.Text = "HOME PAGE";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSeaGreen;
            groupBox1.Controls.Add(listBoxReports);
            groupBox1.Controls.Add(btnAddReport);
            groupBox1.Controls.Add(btnViewDetails);
            groupBox1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(22, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 537);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reports ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkSeaGreen;
            groupBox2.Controls.Add(flowLayoutPanel1);
            groupBox2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(1045, 162);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(487, 537);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Your Tasks";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(22, 38);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(443, 482);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1738, 915);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Name = "HomeForm";
            Text = "HomeForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxReports;
        private Button btnAddReport;
        private Button btnViewDetails;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}