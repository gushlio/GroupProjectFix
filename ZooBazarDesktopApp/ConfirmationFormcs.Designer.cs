namespace ZooBazarDesktopApp
{
    partial class ConfirmationFormcs
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
            btnYes = new Button();
            btnNo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.Location = new Point(63, 90);
            label1.Name = "label1";
            label1.Size = new Size(672, 37);
            label1.TabIndex = 0;
            label1.Text = "Are You Sure You Want To Terminate This Contract?\r\n";
            // 
            // btnYes
            // 
            btnYes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnYes.Location = new Point(175, 152);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(172, 66);
            btnYes.TabIndex = 1;
            btnYes.Text = "Yes";
            btnYes.UseVisualStyleBackColor = true;
            btnYes.Click += btnYes_Click;
            // 
            // btnNo
            // 
            btnNo.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.Location = new Point(425, 153);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(190, 65);
            btnNo.TabIndex = 3;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = true;
            btnNo.Click += btnNo_Click;
            // 
            // ConfirmationFormcs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 355);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(label1);
            Name = "ConfirmationFormcs";
            Text = "ConfirmationFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnYes;
        private Button btnNo;
    }
}