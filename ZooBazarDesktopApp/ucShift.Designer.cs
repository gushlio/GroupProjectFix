namespace ZooBazarDesktopApp
{
    partial class ucShift
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
            lblName = new Label();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            lblName.Location = new Point(29, 9);
            lblName.Name = "lblName";
            lblName.Size = new Size(72, 21);
            lblName.TabIndex = 0;
            lblName.Text = "lblName";
            lblName.Click += lblName_Click;
            // 
            // ucShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblName);
            Name = "ucShift";
            Size = new Size(350, 39);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
    }
}
