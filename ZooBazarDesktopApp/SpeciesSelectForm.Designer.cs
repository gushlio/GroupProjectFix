namespace ZooBazarDesktopApp
{
    partial class SpeciesSelectForm
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
            flpSpecies = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flpSpecies
            // 
            flpSpecies.Location = new Point(1, 3);
            flpSpecies.Name = "flpSpecies";
            flpSpecies.Size = new Size(1045, 795);
            flpSpecies.TabIndex = 0;
            // 
            // SpeciesSelectForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 800);
            Controls.Add(flpSpecies);
            Name = "SpeciesSelectForm";
            Text = "SpeciesSelectForm";
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flpSpecies;
    }
}