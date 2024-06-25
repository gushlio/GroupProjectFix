namespace ZooBazarDesktopApp
{
    partial class Login
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-5, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(714, 118);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(134, 57);
            label2.Name = "label2";
            label2.Size = new Size(222, 37);
            label2.TabIndex = 1;
            label2.Text = "Employee Login";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(159, 12);
            label1.Name = "label1";
            label1.Size = new Size(171, 45);
            label1.TabIndex = 0;
            label1.Text = "Zoo Bazar";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtEmail.Location = new Point(129, 148);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(344, 36);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            txtPassword.Location = new Point(129, 210);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(340, 36);
            txtPassword.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 151);
            label3.Name = "label3";
            label3.Size = new Size(72, 30);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(111, 30);
            label4.TabIndex = 4;
            label4.Text = "Password:";
            // 
            // button1
            // 
            button1.BackColor = Color.DarkSeaGreen;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(8, 272);
            button1.Name = "button1";
            button1.Size = new Size(461, 58);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkSeaGreen;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(113, 386);
            button2.Name = "button2";
            button2.Size = new Size(248, 59);
            button2.TabIndex = 6;
            button2.Text = "Sign Up";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(481, 457);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}