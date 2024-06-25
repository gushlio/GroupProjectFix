namespace ZooBazarDesktopApp
{
    partial class VetDetails
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
            btnRemoveAppointment = new Button();
            lblVetDetails = new Label();
            pictureBox1 = new PictureBox();
            lblDetailsVetName = new Label();
            lblAnimalDetailsVet = new Label();
            lblDateDetails = new Label();
            lblTimeDetails = new Label();
            lblVetNameDisplay = new Label();
            lblSpeciesDisplay = new Label();
            lblDateDisplay = new Label();
            lblTimeDisplay = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(btnRemoveAppointment);
            panel1.Controls.Add(lblVetDetails);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(188, 309);
            panel1.TabIndex = 0;
            // 
            // btnRemoveAppointment
            // 
            btnRemoveAppointment.BackColor = Color.LightGoldenrodYellow;
            btnRemoveAppointment.FlatAppearance.BorderColor = Color.FromArgb(208, 227, 204);
            btnRemoveAppointment.FlatAppearance.BorderSize = 2;
            btnRemoveAppointment.FlatAppearance.MouseOverBackColor = Color.FromArgb(208, 227, 204);
            btnRemoveAppointment.FlatStyle = FlatStyle.Flat;
            btnRemoveAppointment.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            btnRemoveAppointment.Location = new Point(13, 236);
            btnRemoveAppointment.Margin = new Padding(3, 2, 3, 2);
            btnRemoveAppointment.Name = "btnRemoveAppointment";
            btnRemoveAppointment.Size = new Size(162, 59);
            btnRemoveAppointment.TabIndex = 3;
            btnRemoveAppointment.Text = "Delete Appointment";
            btnRemoveAppointment.UseVisualStyleBackColor = false;
            btnRemoveAppointment.Click += btnRemoveAppointment_Click;
            // 
            // lblVetDetails
            // 
            lblVetDetails.AutoSize = true;
            lblVetDetails.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold);
            lblVetDetails.Location = new Point(28, 153);
            lblVetDetails.Name = "lblVetDetails";
            lblVetDetails.Size = new Size(129, 40);
            lblVetDetails.TabIndex = 1;
            lblVetDetails.Text = "Vet Appointment \r\nDetails";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.icons8_details_50;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(65, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 59);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblDetailsVetName
            // 
            lblDetailsVetName.AutoSize = true;
            lblDetailsVetName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDetailsVetName.Location = new Point(241, 38);
            lblDetailsVetName.Name = "lblDetailsVetName";
            lblDetailsVetName.Size = new Size(148, 21);
            lblDetailsVetName.TabIndex = 2;
            lblDetailsVetName.Text = "Veterinarian Name:";
            // 
            // lblAnimalDetailsVet
            // 
            lblAnimalDetailsVet.AutoSize = true;
            lblAnimalDetailsVet.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblAnimalDetailsVet.Location = new Point(265, 100);
            lblAnimalDetailsVet.Name = "lblAnimalDetailsVet";
            lblAnimalDetailsVet.Size = new Size(124, 21);
            lblAnimalDetailsVet.TabIndex = 3;
            lblAnimalDetailsVet.Text = "Animal Species:";
            // 
            // lblDateDetails
            // 
            lblDateDetails.AutoSize = true;
            lblDateDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDateDetails.Location = new Point(219, 170);
            lblDateDetails.Name = "lblDateDetails";
            lblDateDetails.Size = new Size(170, 21);
            lblDateDetails.TabIndex = 4;
            lblDateDetails.Text = "Date of Appointment:";
            // 
            // lblTimeDetails
            // 
            lblTimeDetails.AutoSize = true;
            lblTimeDetails.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTimeDetails.Location = new Point(288, 234);
            lblTimeDetails.Name = "lblTimeDetails";
            lblTimeDetails.Size = new Size(101, 21);
            lblTimeDetails.TabIndex = 5;
            lblTimeDetails.Text = "Time of Day:";
            // 
            // lblVetNameDisplay
            // 
            lblVetNameDisplay.AutoSize = true;
            lblVetNameDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblVetNameDisplay.Location = new Point(414, 38);
            lblVetNameDisplay.Name = "lblVetNameDisplay";
            lblVetNameDisplay.Size = new Size(81, 21);
            lblVetNameDisplay.TabIndex = 6;
            lblVetNameDisplay.Text = "Vet Name";
            // 
            // lblSpeciesDisplay
            // 
            lblSpeciesDisplay.AutoSize = true;
            lblSpeciesDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblSpeciesDisplay.Location = new Point(414, 100);
            lblSpeciesDisplay.Name = "lblSpeciesDisplay";
            lblSpeciesDisplay.Size = new Size(66, 21);
            lblSpeciesDisplay.TabIndex = 7;
            lblSpeciesDisplay.Text = "Species";
            // 
            // lblDateDisplay
            // 
            lblDateDisplay.AutoSize = true;
            lblDateDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblDateDisplay.Location = new Point(414, 170);
            lblDateDisplay.Name = "lblDateDisplay";
            lblDateDisplay.Size = new Size(44, 21);
            lblDateDisplay.TabIndex = 8;
            lblDateDisplay.Text = "Date";
            // 
            // lblTimeDisplay
            // 
            lblTimeDisplay.AutoSize = true;
            lblTimeDisplay.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblTimeDisplay.Location = new Point(414, 234);
            lblTimeDisplay.Name = "lblTimeDisplay";
            lblTimeDisplay.Size = new Size(46, 21);
            lblTimeDisplay.TabIndex = 9;
            lblTimeDisplay.Text = "Time";
            lblTimeDisplay.Click += lblTimeDisplay_Click;
            // 
            // VetDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 304);
            Controls.Add(lblTimeDisplay);
            Controls.Add(lblDateDisplay);
            Controls.Add(lblSpeciesDisplay);
            Controls.Add(lblVetNameDisplay);
            Controls.Add(lblTimeDetails);
            Controls.Add(lblDateDetails);
            Controls.Add(lblAnimalDetailsVet);
            Controls.Add(lblDetailsVetName);
            Controls.Add(panel1);
            Name = "VetDetails";
            Text = "VetDetails";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnRemoveAppointment;
        private Label lblVetDetails;
        private PictureBox pictureBox1;
        private Label lblDetailsVetName;
        private Label lblAnimalDetailsVet;
        private Label lblDateDetails;
        private Label lblTimeDetails;
        private Label lblVetNameDisplay;
        private Label lblSpeciesDisplay;
        private Label lblDateDisplay;
        private Label lblTimeDisplay;
    }
}