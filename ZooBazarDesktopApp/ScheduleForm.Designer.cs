namespace ZooBazarDesktopApp
{
    partial class ScheduleForm
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
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            flpDay = new FlowLayoutPanel();
            btnMonday = new Button();
            btnTuesday = new Button();
            btnWednesday = new Button();
            btnThursday = new Button();
            btnFriday = new Button();
            btnSaturday = new Button();
            btnSunday = new Button();
            pnlShifts = new Panel();
            panel4 = new Panel();
            buttonShift3 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            buttonShift1 = new Button();
            label3 = new Label();
            panel3 = new Panel();
            buttonShift2 = new Button();
            label4 = new Label();
            flpNight = new FlowLayoutPanel();
            flpAfternoon = new FlowLayoutPanel();
            flpMorning = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            flpDay.SuspendLayout();
            pnlShifts.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(546, 22);
            label1.Name = "label1";
            label1.Size = new Size(310, 47);
            label1.TabIndex = 0;
            label1.Text = "Shift Managment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.ForestGreen;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(50, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(1301, 54);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(559, 10);
            label2.Name = "label2";
            label2.Size = new Size(172, 30);
            label2.TabIndex = 0;
            label2.Text = "Weekly Schedule";
            // 
            // flpDay
            // 
            flpDay.BackColor = Color.DarkSeaGreen;
            flpDay.Controls.Add(btnMonday);
            flpDay.Controls.Add(btnTuesday);
            flpDay.Controls.Add(btnWednesday);
            flpDay.Controls.Add(btnThursday);
            flpDay.Controls.Add(btnFriday);
            flpDay.Controls.Add(btnSaturday);
            flpDay.Controls.Add(btnSunday);
            flpDay.Location = new Point(50, 145);
            flpDay.Name = "flpDay";
            flpDay.Size = new Size(230, 483);
            flpDay.TabIndex = 2;
            // 
            // btnMonday
            // 
            btnMonday.BackColor = Color.DarkSeaGreen;
            btnMonday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonday.Location = new Point(3, 3);
            btnMonday.Name = "btnMonday";
            btnMonday.Size = new Size(227, 63);
            btnMonday.TabIndex = 3;
            btnMonday.Text = "Monday";
            btnMonday.TextAlign = ContentAlignment.MiddleLeft;
            btnMonday.UseVisualStyleBackColor = false;
            btnMonday.Click += btnMonday_Click;
            // 
            // btnTuesday
            // 
            btnTuesday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTuesday.Location = new Point(3, 72);
            btnTuesday.Name = "btnTuesday";
            btnTuesday.Size = new Size(227, 63);
            btnTuesday.TabIndex = 4;
            btnTuesday.Text = "Tuesday";
            btnTuesday.TextAlign = ContentAlignment.MiddleLeft;
            btnTuesday.UseVisualStyleBackColor = true;
            btnTuesday.Click += btnTuesday_Click;
            // 
            // btnWednesday
            // 
            btnWednesday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWednesday.Location = new Point(3, 141);
            btnWednesday.Name = "btnWednesday";
            btnWednesday.Size = new Size(227, 63);
            btnWednesday.TabIndex = 4;
            btnWednesday.Text = "Wednesday";
            btnWednesday.TextAlign = ContentAlignment.MiddleLeft;
            btnWednesday.UseVisualStyleBackColor = true;
            btnWednesday.Click += btnWednesday_Click;
            // 
            // btnThursday
            // 
            btnThursday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThursday.Location = new Point(3, 210);
            btnThursday.Name = "btnThursday";
            btnThursday.Size = new Size(227, 63);
            btnThursday.TabIndex = 4;
            btnThursday.Text = "Thursday";
            btnThursday.TextAlign = ContentAlignment.MiddleLeft;
            btnThursday.UseVisualStyleBackColor = true;
            btnThursday.Click += btnThursday_Click;
            // 
            // btnFriday
            // 
            btnFriday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFriday.Location = new Point(3, 279);
            btnFriday.Name = "btnFriday";
            btnFriday.Size = new Size(227, 63);
            btnFriday.TabIndex = 4;
            btnFriday.Text = "Friday";
            btnFriday.TextAlign = ContentAlignment.MiddleLeft;
            btnFriday.UseVisualStyleBackColor = true;
            btnFriday.Click += btnFriday_Click;
            // 
            // btnSaturday
            // 
            btnSaturday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaturday.Location = new Point(3, 348);
            btnSaturday.Name = "btnSaturday";
            btnSaturday.Size = new Size(227, 63);
            btnSaturday.TabIndex = 4;
            btnSaturday.Text = "Saturday";
            btnSaturday.TextAlign = ContentAlignment.MiddleLeft;
            btnSaturday.UseVisualStyleBackColor = true;
            btnSaturday.Click += btnSaturday_Click;
            // 
            // btnSunday
            // 
            btnSunday.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSunday.Location = new Point(3, 417);
            btnSunday.Name = "btnSunday";
            btnSunday.Size = new Size(227, 63);
            btnSunday.TabIndex = 4;
            btnSunday.Text = "Sunday";
            btnSunday.TextAlign = ContentAlignment.MiddleLeft;
            btnSunday.UseVisualStyleBackColor = true;
            btnSunday.Click += btnSunday_Click;
            // 
            // pnlShifts
            // 
            pnlShifts.BackColor = Color.AntiqueWhite;
            pnlShifts.Controls.Add(panel4);
            pnlShifts.Controls.Add(panel2);
            pnlShifts.Controls.Add(panel3);
            pnlShifts.Controls.Add(flpNight);
            pnlShifts.Controls.Add(flpAfternoon);
            pnlShifts.Controls.Add(flpMorning);
            pnlShifts.Location = new Point(277, 148);
            pnlShifts.Name = "pnlShifts";
            pnlShifts.Size = new Size(1074, 559);
            pnlShifts.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkSeaGreen;
            panel4.Controls.Add(buttonShift3);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(707, 38);
            panel4.Name = "panel4";
            panel4.Size = new Size(284, 46);
            panel4.TabIndex = 1;
            // 
            // buttonShift3
            // 
            buttonShift3.BackgroundImage = Properties.Resources.icons8_details_50;
            buttonShift3.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShift3.Location = new Point(220, 1);
            buttonShift3.Name = "buttonShift3";
            buttonShift3.Size = new Size(64, 46);
            buttonShift3.TabIndex = 4;
            buttonShift3.UseVisualStyleBackColor = true;
            buttonShift3.Click += buttonShift3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(96, 12);
            label5.Name = "label5";
            label5.Size = new Size(96, 21);
            label5.TabIndex = 4;
            label5.Text = "5PM - 10PM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(buttonShift1);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(45, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(279, 46);
            panel2.TabIndex = 0;
            // 
            // buttonShift1
            // 
            buttonShift1.BackgroundImage = Properties.Resources.icons8_details_50;
            buttonShift1.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShift1.Location = new Point(215, 0);
            buttonShift1.Name = "buttonShift1";
            buttonShift1.Size = new Size(64, 46);
            buttonShift1.TabIndex = 3;
            buttonShift1.UseVisualStyleBackColor = true;
            buttonShift1.Click += buttonShift1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(91, 12);
            label3.Name = "label3";
            label3.Size = new Size(98, 21);
            label3.TabIndex = 3;
            label3.Text = "7AM - 12PM";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(buttonShift2);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(371, 38);
            panel3.Name = "panel3";
            panel3.Size = new Size(282, 46);
            panel3.TabIndex = 1;
            // 
            // buttonShift2
            // 
            buttonShift2.BackgroundImage = Properties.Resources.icons8_details_50;
            buttonShift2.BackgroundImageLayout = ImageLayout.Stretch;
            buttonShift2.Location = new Point(218, 1);
            buttonShift2.Name = "buttonShift2";
            buttonShift2.Size = new Size(64, 46);
            buttonShift2.TabIndex = 4;
            buttonShift2.UseVisualStyleBackColor = true;
            buttonShift2.Click += buttonShift2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(97, 12);
            label4.Name = "label4";
            label4.Size = new Size(96, 21);
            label4.TabIndex = 4;
            label4.Text = "12PM - 5PM";
            // 
            // flpNight
            // 
            flpNight.BackColor = Color.FloralWhite;
            flpNight.Location = new Point(707, 83);
            flpNight.Name = "flpNight";
            flpNight.Size = new Size(284, 358);
            flpNight.TabIndex = 2;
            // 
            // flpAfternoon
            // 
            flpAfternoon.BackColor = Color.FloralWhite;
            flpAfternoon.Location = new Point(371, 83);
            flpAfternoon.Name = "flpAfternoon";
            flpAfternoon.Size = new Size(282, 358);
            flpAfternoon.TabIndex = 1;
            // 
            // flpMorning
            // 
            flpMorning.BackColor = Color.FloralWhite;
            flpMorning.Location = new Point(45, 83);
            flpMorning.Name = "flpMorning";
            flpMorning.Size = new Size(279, 358);
            flpMorning.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_next_page_50;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(183, 634);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 73);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.icons8_next_page_51;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(53, 634);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(84, 73);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ScheduleForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1388, 730);
            Controls.Add(pnlShifts);
            Controls.Add(flpDay);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "ScheduleForm";
            Text = "ScheduleForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flpDay.ResumeLayout(false);
            pnlShifts.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private FlowLayoutPanel flpDay;
        private Button btnMonday;
        private Button btnTuesday;
        private Button btnWednesday;
        private Button btnThursday;
        private Button btnFriday;
        private Button btnSaturday;
        private Button btnSunday;
        private Panel pnlShifts;
        private FlowLayoutPanel flpNight;
        private Panel panel4;
        private Label label5;
        private FlowLayoutPanel flpAfternoon;
        private Panel panel3;
        private Label label4;
        private FlowLayoutPanel flpMorning;
        private Panel panel2;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonShift3;
        private Button buttonShift1;
        private Button buttonShift2;
    }
}