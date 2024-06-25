
namespace ZooBazarDesktopApp
{
    partial class ucDay
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
            lblUC = new Label();
            checkBox1 = new CheckBox();
            panelUserControlDay = new Panel();
            panelUserControlDay.SuspendLayout();
            SuspendLayout();
            // 
            // lblUC
            // 
            lblUC.AutoSize = true;
            lblUC.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            lblUC.Location = new Point(108, 13);
            lblUC.Name = "lblUC";
            lblUC.Size = new Size(34, 25);
            lblUC.TabIndex = 0;
            lblUC.Text = "oo";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(14, 13);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 1;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelUserControlDay
            // 
            panelUserControlDay.BackColor = Color.Linen;
            panelUserControlDay.Controls.Add(lblUC);
            panelUserControlDay.Controls.Add(checkBox1);
            panelUserControlDay.Dock = DockStyle.Fill;
            panelUserControlDay.Location = new Point(0, 0);
            panelUserControlDay.Margin = new Padding(3, 2, 3, 2);
            panelUserControlDay.Name = "panelUserControlDay";
            panelUserControlDay.Size = new Size(159, 85);
            panelUserControlDay.TabIndex = 3;
            panelUserControlDay.Paint += panelUserControlDay_Paint;
            // 
            // ucDay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelUserControlDay);
            Name = "ucDay";
            Size = new Size(159, 85);
            Load += ucDay_Load;
            panelUserControlDay.ResumeLayout(false);
            panelUserControlDay.PerformLayout();
            ResumeLayout(false);
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                checkBox1.Checked = true;
                this.BackColor = Color.FromArgb(255, 150, 79);
            }
            else
            {
                checkBox1.Checked = false;
                this.BackColor = Color.White;
            }
        }

        #endregion

        private Label lblUC;
        private CheckBox checkBox1;
        private Panel panelUserControlDay;
    }
}
