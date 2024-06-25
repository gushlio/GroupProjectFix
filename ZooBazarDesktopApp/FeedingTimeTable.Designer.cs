namespace ZooBazarDesktopApp
{
    partial class FeedingTimeTable
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
            labelMonth = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelMonth
            // 
            labelMonth.AutoSize = true;
            labelMonth.BackColor = Color.DarkSeaGreen;
            labelMonth.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            labelMonth.ForeColor = SystemColors.ButtonFace;
            labelMonth.Location = new Point(418, 43);
            labelMonth.Name = "labelMonth";
            labelMonth.Size = new Size(416, 51);
            labelMonth.TabIndex = 0;
            labelMonth.Text = "MONTHLY CALENDAR";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.DarkSeaGreen;
            flowLayoutPanel1.Location = new Point(31, 54);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1210, 540);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(76, 26);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 2;
            label2.Text = "Sunday";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(225, 26);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 3;
            label3.Text = "Monday";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(396, 26);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 4;
            label4.Text = "Tuesday";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(565, 26);
            label5.Name = "label5";
            label5.Size = new Size(111, 25);
            label5.TabIndex = 5;
            label5.Text = "Wednesday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(742, 26);
            label6.Name = "label6";
            label6.Size = new Size(90, 25);
            label6.TabIndex = 6;
            label6.Text = "Thursday";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(903, 26);
            label7.Name = "label7";
            label7.Size = new Size(65, 25);
            label7.TabIndex = 7;
            label7.Text = "Friday";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(1059, 26);
            label8.Name = "label8";
            label8.Size = new Size(88, 25);
            label8.TabIndex = 8;
            label8.Text = "Saturday";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_next_page_50;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.icons8_next_page_50;
            pictureBox1.Location = new Point(1019, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_next_page_51;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(907, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(106, 97);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(22, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(1258, 607);
            panel1.TabIndex = 11;
            // 
            // FeedingTimeTable
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1334, 731);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(labelMonth);
            Name = "FeedingTimeTable";
            Text = "FeedingTimeTable";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelMonth;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
    }
}