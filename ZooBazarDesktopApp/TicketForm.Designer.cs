namespace ZooBazarDesktopApp
{
    partial class TicketForm
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
            panel2 = new Panel();
            dataGridViewTickets = new DataGridView();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonAddTickets = new Button();
            txtQuantityToAdd = new TextBox();
            label12 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            buttonEditPrice = new Button();
            txtNewPrice = new TextBox();
            label2 = new Label();
            cmbTicketType = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(34, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(1198, 90);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(456, 20);
            label1.Name = "label1";
            label1.Size = new Size(308, 50);
            label1.TabIndex = 0;
            label1.Text = "Tickets Manager";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(dataGridViewTickets);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(34, 134);
            panel2.Name = "panel2";
            panel2.Size = new Size(1198, 476);
            panel2.TabIndex = 1;
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridViewTickets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Location = new Point(553, 45);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.RowHeadersWidth = 51;
            dataGridViewTickets.Size = new Size(611, 360);
            dataGridViewTickets.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(553, 12);
            label3.Name = "label3";
            label3.Size = new Size(181, 30);
            label3.TabIndex = 1;
            label3.Text = "View Tickets Data";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cmbTicketType);
            groupBox1.Location = new Point(21, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(483, 402);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(buttonAddTickets);
            groupBox3.Controls.Add(txtQuantityToAdd);
            groupBox3.Controls.Add(label12);
            groupBox3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = SystemColors.ButtonHighlight;
            groupBox3.Location = new Point(223, 113);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(228, 208);
            groupBox3.TabIndex = 52;
            groupBox3.TabStop = false;
            groupBox3.Text = "Update Ticket Quantity";
            // 
            // buttonAddTickets
            // 
            buttonAddTickets.ForeColor = SystemColors.ActiveCaptionText;
            buttonAddTickets.Location = new Point(6, 155);
            buttonAddTickets.Name = "buttonAddTickets";
            buttonAddTickets.Size = new Size(216, 47);
            buttonAddTickets.TabIndex = 47;
            buttonAddTickets.Text = "Add Tickets";
            buttonAddTickets.UseVisualStyleBackColor = true;
            buttonAddTickets.Click += buttonAddTickets_Click;
            // 
            // txtQuantityToAdd
            // 
            txtQuantityToAdd.Location = new Point(31, 65);
            txtQuantityToAdd.Name = "txtQuantityToAdd";
            txtQuantityToAdd.Size = new Size(143, 33);
            txtQuantityToAdd.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(31, 37);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(143, 25);
            label12.TabIndex = 45;
            label12.Text = "Ticket Amount:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(buttonEditPrice);
            groupBox2.Controls.Add(txtNewPrice);
            groupBox2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(24, 113);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(177, 208);
            groupBox2.TabIndex = 51;
            groupBox2.TabStop = false;
            groupBox2.Text = "Edit Ticket Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 37);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(91, 25);
            label11.TabIndex = 42;
            label11.Text = "Set Price:";
            // 
            // buttonEditPrice
            // 
            buttonEditPrice.ForeColor = SystemColors.ActiveCaptionText;
            buttonEditPrice.Location = new Point(6, 155);
            buttonEditPrice.Name = "buttonEditPrice";
            buttonEditPrice.Size = new Size(165, 47);
            buttonEditPrice.TabIndex = 49;
            buttonEditPrice.Text = "Update Price";
            buttonEditPrice.UseVisualStyleBackColor = true;
            buttonEditPrice.Click += buttonEditPrice_Click;
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(40, 65);
            txtNewPrice.Margin = new Padding(2);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(91, 33);
            txtNewPrice.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(37, 31);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 50;
            label2.Text = "Select Ticket Type";
            // 
            // cmbTicketType
            // 
            cmbTicketType.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTicketType.FormattingEnabled = true;
            cmbTicketType.Location = new Point(198, 31);
            cmbTicketType.Name = "cmbTicketType";
            cmbTicketType.Size = new Size(199, 33);
            cmbTicketType.TabIndex = 49;
            cmbTicketType.SelectedIndexChanged += cmbTicketType_SelectedIndexChanged;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGoldenrodYellow;
            ClientSize = new Size(1283, 682);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "TicketForm";
            Text = "TicketForm";
            Load += TicketForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private GroupBox groupBox1;
        private ComboBox cmbTicketType;
        private Label label2;
        private GroupBox groupBox2;
        private Label label11;
        private Button buttonEditPrice;
        private TextBox txtNewPrice;
        private GroupBox groupBox3;
        private Button buttonAddTickets;
        private TextBox txtQuantityToAdd;
        private Label label12;
        private Label label3;
        private DataGridView dataGridViewTickets;
    }
}