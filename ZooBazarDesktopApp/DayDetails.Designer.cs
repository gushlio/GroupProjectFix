namespace ZooBazarDesktopApp
{
    partial class DayDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DayDetails));
            labelDate = new Label();
            dataFeedingView = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataFeedingView).BeginInit();
            SuspendLayout();
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.Font = new Font("Segoe UI Semibold", 30F, FontStyle.Bold | FontStyle.Italic);
            labelDate.ForeColor = SystemColors.HighlightText;
            labelDate.Location = new Point(12, 9);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(129, 54);
            labelDate.TabIndex = 0;
            labelDate.Text = "label1";
            // 
            // dataFeedingView
            // 
            dataFeedingView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataFeedingView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataFeedingView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataFeedingView.Location = new Point(54, 129);
            dataFeedingView.Margin = new Padding(3, 2, 3, 2);
            dataFeedingView.Name = "dataFeedingView";
            dataFeedingView.RowHeadersWidth = 51;
            dataFeedingView.RowTemplate.Height = 29;
            dataFeedingView.Size = new Size(666, 226);
            dataFeedingView.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(189, 80);
            label1.Name = "label1";
            label1.Size = new Size(404, 47);
            label1.TabIndex = 14;
            label1.Text = "Daily Feeding Schedule";
            // 
            // DayDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(774, 381);
            Controls.Add(label1);
            Controls.Add(dataFeedingView);
            Controls.Add(labelDate);
            DoubleBuffered = true;
            Name = "DayDetails";
            Text = "DayDetails";
            ((System.ComponentModel.ISupportInitialize)dataFeedingView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDate;
        private DataGridView dataFeedingView;
        private Label label1;
    }
}