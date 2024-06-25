namespace MyLittleHousing
{
    partial class UserControlDays
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(94, 19);
            label1.Name = "label1";
            label1.Size = new Size(34, 28);
            label1.TabIndex = 0;
            label1.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 53);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 1;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UserControlDays";
            Size = new Size(150, 87);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}
