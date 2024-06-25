namespace ZooBazarDesktopApp
{
    partial class uCVet
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAnimal = new Label();
            lblVetName = new Label();
            lblDate = new Label();
            lblTime = new Label();
            SuspendLayout();
            // 
            // lblAnimal
            // 
            lblAnimal.AutoSize = true;
            lblAnimal.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            lblAnimal.Location = new Point(12, 29);
            lblAnimal.Name = "lblAnimal";
            lblAnimal.Size = new Size(91, 25);
            lblAnimal.TabIndex = 0;
            lblAnimal.Text = "lblAnimal";
            // 
            // lblVetName
            // 
            lblVetName.AutoSize = true;
            lblVetName.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblVetName.Location = new Point(22, 75);
            lblVetName.Name = "lblVetName";
            lblVetName.Size = new Size(61, 25);
            lblVetName.TabIndex = 1;
            lblVetName.Text = "label2";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDate.Location = new Point(22, 125);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(61, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "label2";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTime.Location = new Point(22, 174);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(61, 25);
            lblTime.TabIndex = 3;
            lblTime.Text = "label2";
            // 
            // uCVet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblVetName);
            Controls.Add(lblAnimal);
            Name = "uCVet";
            Size = new Size(278, 239);
            Click += uCVet_Click;
            MouseEnter += uCVet_MouseEnter;
            MouseLeave += uCVet_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAnimal;
        private Label lblVetName;
        private Label lblDate;
        private Label lblTime;
    }
}
