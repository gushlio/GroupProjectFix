namespace ZooBazarDesktopApp
{
    partial class StatisticsForm
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
            components = new System.ComponentModel.Container();
            refreshTimer = new System.Windows.Forms.Timer(components);
            plotTitleLBL = new Label();
            panel1 = new Panel();
            salesRB = new RadioButton();
            employeeRB = new RadioButton();
            animalRB = new RadioButton();
            label1 = new Label();
            grpBxForMoreStatistics = new GroupBox();
            lblForTicketStatistics = new Label();
            monthlyAdultTcktRB = new RadioButton();
            dailyAdultTcktRB = new RadioButton();
            monthlyChildTcktRB = new RadioButton();
            dailyChildTcktRB = new RadioButton();
            dailyTotalRB = new RadioButton();
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            panel1.SuspendLayout();
            grpBxForMoreStatistics.SuspendLayout();
            SuspendLayout();
            // 
            // plotTitleLBL
            // 
            plotTitleLBL.AutoSize = true;
            plotTitleLBL.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plotTitleLBL.Location = new Point(403, 27);
            plotTitleLBL.Name = "plotTitleLBL";
            plotTitleLBL.Size = new Size(109, 30);
            plotTitleLBL.TabIndex = 1;
            plotTitleLBL.Text = "Title label";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(salesRB);
            panel1.Controls.Add(employeeRB);
            panel1.Controls.Add(animalRB);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(301, 252);
            panel1.TabIndex = 2;
            // 
            // salesRB
            // 
            salesRB.AutoSize = true;
            salesRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            salesRB.ForeColor = SystemColors.ButtonHighlight;
            salesRB.Location = new Point(31, 180);
            salesRB.Name = "salesRB";
            salesRB.Size = new Size(218, 29);
            salesRB.TabIndex = 3;
            salesRB.TabStop = true;
            salesRB.Text = "Montly ticket statisticcs";
            salesRB.UseVisualStyleBackColor = true;
            salesRB.CheckedChanged += salesRB_CheckedChanged;
            // 
            // employeeRB
            // 
            employeeRB.AutoSize = true;
            employeeRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            employeeRB.ForeColor = SystemColors.ButtonHighlight;
            employeeRB.Location = new Point(31, 115);
            employeeRB.Name = "employeeRB";
            employeeRB.Size = new Size(252, 29);
            employeeRB.TabIndex = 2;
            employeeRB.TabStop = true;
            employeeRB.Text = "Montly employee statisticcs";
            employeeRB.UseVisualStyleBackColor = true;
            employeeRB.CheckedChanged += employeeRB_CheckedChanged;
            // 
            // animalRB
            // 
            animalRB.AutoSize = true;
            animalRB.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            animalRB.ForeColor = SystemColors.ButtonHighlight;
            animalRB.Location = new Point(31, 54);
            animalRB.Name = "animalRB";
            animalRB.Size = new Size(232, 29);
            animalRB.TabIndex = 1;
            animalRB.TabStop = true;
            animalRB.Text = "Montly animal statisticcs";
            animalRB.UseVisualStyleBackColor = true;
            animalRB.CheckedChanged += animalRB_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(74, 16);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 0;
            label1.Text = "Choose Statistics";
            // 
            // grpBxForMoreStatistics
            // 
            grpBxForMoreStatistics.Controls.Add(lblForTicketStatistics);
            grpBxForMoreStatistics.Controls.Add(monthlyAdultTcktRB);
            grpBxForMoreStatistics.Controls.Add(dailyAdultTcktRB);
            grpBxForMoreStatistics.Controls.Add(monthlyChildTcktRB);
            grpBxForMoreStatistics.Controls.Add(dailyChildTcktRB);
            grpBxForMoreStatistics.Controls.Add(dailyTotalRB);
            grpBxForMoreStatistics.Font = new Font("Segoe UI", 12F);
            grpBxForMoreStatistics.ForeColor = SystemColors.ActiveCaptionText;
            grpBxForMoreStatistics.Location = new Point(12, 330);
            grpBxForMoreStatistics.Name = "grpBxForMoreStatistics";
            grpBxForMoreStatistics.Size = new Size(301, 297);
            grpBxForMoreStatistics.TabIndex = 7;
            grpBxForMoreStatistics.TabStop = false;
            grpBxForMoreStatistics.Text = "Detailed ticket statistics";
            // 
            // lblForTicketStatistics
            // 
            lblForTicketStatistics.AutoSize = true;
            lblForTicketStatistics.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic);
            lblForTicketStatistics.ForeColor = Color.Olive;
            lblForTicketStatistics.Location = new Point(6, 25);
            lblForTicketStatistics.Name = "lblForTicketStatistics";
            lblForTicketStatistics.Size = new Size(228, 21);
            lblForTicketStatistics.TabIndex = 5;
            lblForTicketStatistics.Text = "Select a button to show statistics";
            // 
            // monthlyAdultTcktRB
            // 
            monthlyAdultTcktRB.AutoSize = true;
            monthlyAdultTcktRB.Location = new Point(16, 255);
            monthlyAdultTcktRB.Name = "monthlyAdultTcktRB";
            monthlyAdultTcktRB.Size = new Size(204, 25);
            monthlyAdultTcktRB.TabIndex = 4;
            monthlyAdultTcktRB.TabStop = true;
            monthlyAdultTcktRB.Text = "Monthly adult ticket sales";
            monthlyAdultTcktRB.UseVisualStyleBackColor = true;
            monthlyAdultTcktRB.CheckedChanged += monthlyAdultTcktRB_CheckedChanged;
            // 
            // dailyAdultTcktRB
            // 
            dailyAdultTcktRB.AutoSize = true;
            dailyAdultTcktRB.Location = new Point(16, 224);
            dailyAdultTcktRB.Name = "dailyAdultTcktRB";
            dailyAdultTcktRB.Size = new Size(181, 25);
            dailyAdultTcktRB.TabIndex = 3;
            dailyAdultTcktRB.TabStop = true;
            dailyAdultTcktRB.Text = "Daily adult ticket sales";
            dailyAdultTcktRB.UseVisualStyleBackColor = true;
            dailyAdultTcktRB.CheckedChanged += dailyAdultTcktRB_CheckedChanged;
            // 
            // monthlyChildTcktRB
            // 
            monthlyChildTcktRB.AutoSize = true;
            monthlyChildTcktRB.Location = new Point(16, 154);
            monthlyChildTcktRB.Name = "monthlyChildTcktRB";
            monthlyChildTcktRB.Size = new Size(202, 25);
            monthlyChildTcktRB.TabIndex = 2;
            monthlyChildTcktRB.TabStop = true;
            monthlyChildTcktRB.Text = "Monthly child ticket sales";
            monthlyChildTcktRB.UseVisualStyleBackColor = true;
            monthlyChildTcktRB.CheckedChanged += monthlyChildTcktRB_CheckedChanged;
            // 
            // dailyChildTcktRB
            // 
            dailyChildTcktRB.AutoSize = true;
            dailyChildTcktRB.Location = new Point(16, 123);
            dailyChildTcktRB.Name = "dailyChildTcktRB";
            dailyChildTcktRB.Size = new Size(179, 25);
            dailyChildTcktRB.TabIndex = 1;
            dailyChildTcktRB.TabStop = true;
            dailyChildTcktRB.Text = "Daily child ticket sales";
            dailyChildTcktRB.UseVisualStyleBackColor = true;
            dailyChildTcktRB.CheckedChanged += dailyChildTcktRB_CheckedChanged;
            // 
            // dailyTotalRB
            // 
            dailyTotalRB.AutoSize = true;
            dailyTotalRB.Location = new Point(16, 64);
            dailyTotalRB.Name = "dailyTotalRB";
            dailyTotalRB.Size = new Size(136, 25);
            dailyTotalRB.TabIndex = 0;
            dailyTotalRB.TabStop = true;
            dailyTotalRB.Text = "Daily total sales";
            dailyTotalRB.UseVisualStyleBackColor = true;
            dailyTotalRB.CheckedChanged += dailyTotalRB_CheckedChanged;
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(403, 60);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(842, 567);
            formsPlot1.TabIndex = 8;
            // 
            // StatisticsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1270, 650);
            Controls.Add(formsPlot1);
            Controls.Add(grpBxForMoreStatistics);
            Controls.Add(panel1);
            Controls.Add(plotTitleLBL);
            Name = "StatisticsForm";
            Text = "StatisticsForm";
            Load += StatisticsForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpBxForMoreStatistics.ResumeLayout(false);
            grpBxForMoreStatistics.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Timer refreshTimer;
        private Label plotTitleLBL;
        private Panel panel1;
        private RadioButton salesRB;
        private RadioButton employeeRB;
        private RadioButton animalRB;
        private Label label1;
        private GroupBox grpBxForMoreStatistics;
        private Label lblForTicketStatistics;
        private RadioButton monthlyAdultTcktRB;
        private RadioButton dailyAdultTcktRB;
        private RadioButton monthlyChildTcktRB;
        private RadioButton dailyChildTcktRB;
        private RadioButton dailyTotalRB;
        private ScottPlot.WinForms.FormsPlot statisticsPlot;
        private ScottPlot.WinForms.FormsPlot formsPlot1;
    }
}