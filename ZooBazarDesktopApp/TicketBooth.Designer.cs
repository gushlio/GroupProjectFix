namespace ZooBazarDesktopApp
{
    partial class TicketBooth
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
            label1 = new Label();
            label2 = new Label();
            numberChild = new NumericUpDown();
            numberAdult = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            cbTime = new ComboBox();
            btnBuy = new Button();
            panel2 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lblChildrenInZoo = new Label();
            lblAdultsInZoo = new Label();
            lblOverallInZoo = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numberChild).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numberAdult).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnBuy);
            panel1.Controls.Add(cbTime);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(numberAdult);
            panel1.Controls.Add(numberChild);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(104, 152);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 391);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSeaGreen;
            label1.Location = new Point(538, 51);
            label1.Name = "label1";
            label1.Size = new Size(190, 40);
            label1.TabIndex = 1;
            label1.Text = "Ticket Booth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(237, 21);
            label2.Name = "label2";
            label2.Size = new Size(76, 25);
            label2.TabIndex = 0;
            label2.Text = "Tickets:";
            // 
            // numberChild
            // 
            numberChild.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberChild.Location = new Point(294, 82);
            numberChild.Margin = new Padding(4);
            numberChild.Name = "numberChild";
            numberChild.Size = new Size(120, 35);
            numberChild.TabIndex = 5;
            // 
            // numberAdult
            // 
            numberAdult.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberAdult.Location = new Point(294, 155);
            numberAdult.Margin = new Padding(5, 6, 5, 6);
            numberAdult.Name = "numberAdult";
            numberAdult.Size = new Size(120, 35);
            numberAdult.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(68, 82);
            label3.Name = "label3";
            label3.Size = new Size(157, 37);
            label3.TabIndex = 8;
            label3.Text = "Child (0-12)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(68, 155);
            label4.Name = "label4";
            label4.Size = new Size(180, 37);
            label4.TabIndex = 9;
            label4.Text = "Regular (12+)";
            // 
            // cbTime
            // 
            cbTime.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTime.FormattingEnabled = true;
            cbTime.Location = new Point(68, 236);
            cbTime.Name = "cbTime";
            cbTime.Size = new Size(346, 38);
            cbTime.TabIndex = 10;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(208, 227, 204);
            btnBuy.FlatAppearance.BorderColor = Color.FromArgb(252, 253, 175);
            btnBuy.FlatAppearance.BorderSize = 3;
            btnBuy.FlatAppearance.MouseOverBackColor = Color.FromArgb(252, 253, 175);
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.Location = new Point(68, 313);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(346, 51);
            btnBuy.TabIndex = 11;
            btnBuy.Text = "Sell Tickets";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(lblOverallInZoo);
            panel2.Controls.Add(lblAdultsInZoo);
            panel2.Controls.Add(lblChildrenInZoo);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(687, 152);
            panel2.Name = "panel2";
            panel2.Size = new Size(528, 391);
            panel2.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(114, 21);
            label5.Name = "label5";
            label5.Size = new Size(248, 25);
            label5.TabIndex = 1;
            label5.Text = "People in the Zoo currently:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(23, 82);
            label6.Name = "label6";
            label6.Size = new Size(212, 37);
            label6.TabIndex = 9;
            label6.Text = "Children in Zoo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(47, 187);
            label7.Name = "label7";
            label7.Size = new Size(188, 37);
            label7.TabIndex = 10;
            label7.Text = "Adults in Zoo:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(40, 291);
            label8.Name = "label8";
            label8.Size = new Size(195, 37);
            label8.TabIndex = 11;
            label8.Text = "Overall in Zoo:";
            // 
            // lblChildrenInZoo
            // 
            lblChildrenInZoo.AutoSize = true;
            lblChildrenInZoo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChildrenInZoo.ForeColor = SystemColors.ButtonHighlight;
            lblChildrenInZoo.Location = new Point(250, 82);
            lblChildrenInZoo.Name = "lblChildrenInZoo";
            lblChildrenInZoo.Size = new Size(212, 37);
            lblChildrenInZoo.TabIndex = 12;
            lblChildrenInZoo.Text = "Children in Zoo:";
            // 
            // lblAdultsInZoo
            // 
            lblAdultsInZoo.AutoSize = true;
            lblAdultsInZoo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdultsInZoo.ForeColor = SystemColors.ButtonHighlight;
            lblAdultsInZoo.Location = new Point(250, 187);
            lblAdultsInZoo.Name = "lblAdultsInZoo";
            lblAdultsInZoo.Size = new Size(188, 37);
            lblAdultsInZoo.TabIndex = 13;
            lblAdultsInZoo.Text = "Adults in Zoo:";
            // 
            // lblOverallInZoo
            // 
            lblOverallInZoo.AutoSize = true;
            lblOverallInZoo.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOverallInZoo.ForeColor = SystemColors.ButtonHighlight;
            lblOverallInZoo.Location = new Point(250, 291);
            lblOverallInZoo.Name = "lblOverallInZoo";
            lblOverallInZoo.Size = new Size(195, 37);
            lblOverallInZoo.TabIndex = 14;
            lblOverallInZoo.Text = "Overall in Zoo:";
            // 
            // TicketBooth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1283, 682);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "TicketBooth";
            Text = "TicketBooth";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numberChild).EndInit();
            ((System.ComponentModel.ISupportInitialize)numberAdult).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBuy;
        private ComboBox cbTime;
        private Label label4;
        private Label label3;
        private NumericUpDown numberAdult;
        private NumericUpDown numberChild;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label label5;
        private Label lblOverallInZoo;
        private Label lblAdultsInZoo;
        private Label lblChildrenInZoo;
        private Label label8;
        private Label label7;
        private Label label6;
    }
}