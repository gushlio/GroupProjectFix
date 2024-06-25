namespace ZooBazarDesktopApp.UserControls
{
    partial class TaskUC
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
            Panel panelEmpty;
            labelUpdateTask = new Label();
            label11 = new Label();
            labelAddTask = new Label();
            gbAddBook = new GroupBox();
            labelcurrentlocation = new Label();
            textBoxDescriprion = new TextBox();
            lanelCurrentTime = new Label();
            labelcurrenttime = new Label();
            displaycurrentfreq = new Label();
            labelCurrentFrequency = new Label();
            btnUpdateTask = new Button();
            labelShowArea = new Label();
            cbbSelectTaskForUpdate = new ComboBox();
            labelSelectTaskUpdate = new Label();
            checkedListBox1 = new CheckedListBox();
            label4 = new Label();
            cbbSelectArea = new ComboBox();
            label10 = new Label();
            setTimeForTheTask = new DateTimePicker();
            label5 = new Label();
            label2 = new Label();
            btnAddTask = new Button();
            label3 = new Label();
            txtAddTask = new TextBox();
            labelTaskAdd = new Label();
            btnRemoveTask = new Button();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            radioButtonAddTask = new RadioButton();
            radioButtonpdateTask = new RadioButton();
            panelEmpty = new Panel();
            panelEmpty.SuspendLayout();
            gbAddBook.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelEmpty
            // 
            panelEmpty.BackColor = Color.DarkGreen;
            panelEmpty.Controls.Add(labelUpdateTask);
            panelEmpty.Controls.Add(label11);
            panelEmpty.Controls.Add(labelAddTask);
            panelEmpty.Location = new Point(13, 73);
            panelEmpty.Name = "panelEmpty";
            panelEmpty.Size = new Size(706, 28);
            panelEmpty.TabIndex = 57;
            // 
            // labelUpdateTask
            // 
            labelUpdateTask.AutoSize = true;
            labelUpdateTask.BackColor = Color.DarkGreen;
            labelUpdateTask.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelUpdateTask.ForeColor = Color.White;
            labelUpdateTask.Location = new Point(0, 5);
            labelUpdateTask.Name = "labelUpdateTask";
            labelUpdateTask.Size = new Size(109, 23);
            labelUpdateTask.TabIndex = 0;
            labelUpdateTask.Text = "Update Task";
            labelUpdateTask.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkGreen;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label11.ForeColor = Color.White;
            label11.Location = new Point(0, 0);
            label11.Name = "label11";
            label11.Size = new Size(0, 23);
            label11.TabIndex = 0;
            // 
            // labelAddTask
            // 
            labelAddTask.AutoSize = true;
            labelAddTask.BackColor = Color.DarkGreen;
            labelAddTask.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelAddTask.ForeColor = Color.White;
            labelAddTask.Location = new Point(0, 5);
            labelAddTask.Name = "labelAddTask";
            labelAddTask.Size = new Size(84, 23);
            labelAddTask.TabIndex = 0;
            labelAddTask.Text = "Add Task";
            labelAddTask.Visible = false;
            // 
            // gbAddBook
            // 
            gbAddBook.BackColor = Color.White;
            gbAddBook.Controls.Add(labelcurrentlocation);
            gbAddBook.Controls.Add(textBoxDescriprion);
            gbAddBook.Controls.Add(lanelCurrentTime);
            gbAddBook.Controls.Add(labelcurrenttime);
            gbAddBook.Controls.Add(displaycurrentfreq);
            gbAddBook.Controls.Add(labelCurrentFrequency);
            gbAddBook.Controls.Add(btnUpdateTask);
            gbAddBook.Controls.Add(labelShowArea);
            gbAddBook.Controls.Add(cbbSelectTaskForUpdate);
            gbAddBook.Controls.Add(labelSelectTaskUpdate);
            gbAddBook.Controls.Add(checkedListBox1);
            gbAddBook.Controls.Add(label4);
            gbAddBook.Controls.Add(cbbSelectArea);
            gbAddBook.Controls.Add(label10);
            gbAddBook.Controls.Add(setTimeForTheTask);
            gbAddBook.Controls.Add(label5);
            gbAddBook.Controls.Add(label2);
            gbAddBook.Controls.Add(btnAddTask);
            gbAddBook.Controls.Add(label3);
            gbAddBook.Controls.Add(txtAddTask);
            gbAddBook.Controls.Add(labelTaskAdd);
            gbAddBook.Location = new Point(13, 73);
            gbAddBook.Name = "gbAddBook";
            gbAddBook.Size = new Size(703, 871);
            gbAddBook.TabIndex = 1;
            gbAddBook.TabStop = false;
            gbAddBook.Text = "Add Task";
            gbAddBook.Enter += gbAddBook_Enter;
            // 
            // labelcurrentlocation
            // 
            labelcurrentlocation.AutoSize = true;
            labelcurrentlocation.Location = new Point(357, 344);
            labelcurrentlocation.Name = "labelcurrentlocation";
            labelcurrentlocation.RightToLeft = RightToLeft.No;
            labelcurrentlocation.Size = new Size(118, 20);
            labelcurrentlocation.TabIndex = 61;
            labelcurrentlocation.Text = "Current location:";
            labelcurrentlocation.Visible = false;
            // 
            // textBoxDescriprion
            // 
            textBoxDescriprion.Location = new Point(141, 139);
            textBoxDescriprion.Multiline = true;
            textBoxDescriprion.Name = "textBoxDescriprion";
            textBoxDescriprion.Size = new Size(282, 148);
            textBoxDescriprion.TabIndex = 60;
            // 
            // lanelCurrentTime
            // 
            lanelCurrentTime.AutoSize = true;
            lanelCurrentTime.Location = new Point(357, 433);
            lanelCurrentTime.Name = "lanelCurrentTime";
            lanelCurrentTime.RightToLeft = RightToLeft.No;
            lanelCurrentTime.Size = new Size(94, 20);
            lanelCurrentTime.TabIndex = 59;
            lanelCurrentTime.Text = "Current time:";
            lanelCurrentTime.Visible = false;
            // 
            // labelcurrenttime
            // 
            labelcurrenttime.AutoSize = true;
            labelcurrenttime.Location = new Point(494, 433);
            labelcurrenttime.Name = "labelcurrenttime";
            labelcurrenttime.Size = new Size(0, 20);
            labelcurrenttime.TabIndex = 58;
            labelcurrenttime.Visible = false;
            // 
            // displaycurrentfreq
            // 
            displaycurrentfreq.AutoSize = true;
            displaycurrentfreq.Location = new Point(170, 517);
            displaycurrentfreq.Name = "displaycurrentfreq";
            displaycurrentfreq.Size = new Size(0, 20);
            displaycurrentfreq.TabIndex = 57;
            displaycurrentfreq.Visible = false;
            // 
            // labelCurrentFrequency
            // 
            labelCurrentFrequency.AutoSize = true;
            labelCurrentFrequency.Location = new Point(19, 517);
            labelCurrentFrequency.Name = "labelCurrentFrequency";
            labelCurrentFrequency.RightToLeft = RightToLeft.No;
            labelCurrentFrequency.Size = new Size(131, 20);
            labelCurrentFrequency.TabIndex = 56;
            labelCurrentFrequency.Text = "Current Frequency:";
            labelCurrentFrequency.Visible = false;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.BackColor = Color.OldLace;
            btnUpdateTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnUpdateTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnUpdateTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateTask.ForeColor = Color.DarkGreen;
            btnUpdateTask.Location = new Point(259, 797);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(201, 31);
            btnUpdateTask.TabIndex = 55;
            btnUpdateTask.Text = "Update";
            btnUpdateTask.UseVisualStyleBackColor = false;
            btnUpdateTask.Visible = false;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // labelShowArea
            // 
            labelShowArea.AutoSize = true;
            labelShowArea.Location = new Point(505, 344);
            labelShowArea.Name = "labelShowArea";
            labelShowArea.Size = new Size(0, 20);
            labelShowArea.TabIndex = 54;
            labelShowArea.Visible = false;
            // 
            // cbbSelectTaskForUpdate
            // 
            cbbSelectTaskForUpdate.FormattingEnabled = true;
            cbbSelectTaskForUpdate.Location = new Point(138, 61);
            cbbSelectTaskForUpdate.Name = "cbbSelectTaskForUpdate";
            cbbSelectTaskForUpdate.Size = new Size(239, 28);
            cbbSelectTaskForUpdate.TabIndex = 53;
            cbbSelectTaskForUpdate.Visible = false;
            cbbSelectTaskForUpdate.SelectedIndexChanged += cbbSelectTaskForUpdate_SelectedIndexChanged;
            // 
            // labelSelectTaskUpdate
            // 
            labelSelectTaskUpdate.AutoSize = true;
            labelSelectTaskUpdate.Location = new Point(17, 60);
            labelSelectTaskUpdate.Name = "labelSelectTaskUpdate";
            labelSelectTaskUpdate.Size = new Size(82, 20);
            labelSelectTaskUpdate.TabIndex = 52;
            labelSelectTaskUpdate.Text = "Select task:";
            labelSelectTaskUpdate.Visible = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            checkedListBox1.Location = new Point(176, 571);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(247, 158);
            checkedListBox1.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 6.5F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(21, 603);
            label4.Name = "label4";
            label4.Size = new Size(63, 13);
            label4.TabIndex = 50;
            label4.Text = "Select days";
            // 
            // cbbSelectArea
            // 
            cbbSelectArea.FormattingEnabled = true;
            cbbSelectArea.Location = new Point(138, 336);
            cbbSelectArea.Name = "cbbSelectArea";
            cbbSelectArea.Size = new Size(199, 28);
            cbbSelectArea.TabIndex = 49;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(19, 344);
            label10.Name = "label10";
            label10.Size = new Size(43, 20);
            label10.TabIndex = 47;
            label10.Text = "Area:";
            // 
            // setTimeForTheTask
            // 
            setTimeForTheTask.Format = DateTimePickerFormat.Time;
            setTimeForTheTask.Location = new Point(138, 428);
            setTimeForTheTask.Name = "setTimeForTheTask";
            setTimeForTheTask.Size = new Size(128, 27);
            setTimeForTheTask.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 440);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 45;
            label5.Text = "Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 571);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 42;
            label2.Text = "Frequency:";
            // 
            // btnAddTask
            // 
            btnAddTask.BackColor = Color.OldLace;
            btnAddTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnAddTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnAddTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddTask.ForeColor = Color.DarkGreen;
            btnAddTask.Location = new Point(259, 797);
            btnAddTask.Name = "btnAddTask";
            btnAddTask.Size = new Size(201, 31);
            btnAddTask.TabIndex = 39;
            btnAddTask.Text = "Add";
            btnAddTask.UseVisualStyleBackColor = false;
            btnAddTask.Visible = false;
            btnAddTask.Click += btnAddTask_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 142);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 29;
            label3.Text = "Description:";
            // 
            // txtAddTask
            // 
            txtAddTask.Location = new Point(138, 61);
            txtAddTask.Name = "txtAddTask";
            txtAddTask.Size = new Size(239, 27);
            txtAddTask.TabIndex = 28;
            txtAddTask.Visible = false;
            // 
            // labelTaskAdd
            // 
            labelTaskAdd.AutoSize = true;
            labelTaskAdd.Location = new Point(15, 61);
            labelTaskAdd.Name = "labelTaskAdd";
            labelTaskAdd.Size = new Size(39, 20);
            labelTaskAdd.TabIndex = 25;
            labelTaskAdd.Text = "Task:";
            // 
            // btnRemoveTask
            // 
            btnRemoveTask.BackColor = Color.OldLace;
            btnRemoveTask.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            btnRemoveTask.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            btnRemoveTask.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveTask.ForeColor = Color.DarkGreen;
            btnRemoveTask.Location = new Point(638, 821);
            btnRemoveTask.Name = "btnRemoveTask";
            btnRemoveTask.Size = new Size(201, 31);
            btnRemoveTask.TabIndex = 55;
            btnRemoveTask.Text = "Remove";
            btnRemoveTask.UseVisualStyleBackColor = false;
            btnRemoveTask.Click += btnRemoveTask_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnRemoveTask);
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(panel1);
            groupBox1.Location = new Point(725, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(954, 906);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Task";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(941, 729);
            dataGridView1.TabIndex = 56;
            // 
            // button1
            // 
            button1.BackColor = Color.OldLace;
            button1.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 0);
            button1.FlatAppearance.MouseDownBackColor = Color.DarkGreen;
            button1.Font = new Font("Showcard Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(167, 821);
            button1.Name = "button1";
            button1.Size = new Size(201, 31);
            button1.TabIndex = 55;
            button1.Text = "Open Calendar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGreen;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(977, 28);
            panel1.TabIndex = 53;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkGreen;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(6, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 23);
            label1.TabIndex = 0;
            label1.Text = "View All Tasks/ Remove Task";
            // 
            // radioButtonAddTask
            // 
            radioButtonAddTask.AutoSize = true;
            radioButtonAddTask.Location = new Point(151, 39);
            radioButtonAddTask.Name = "radioButtonAddTask";
            radioButtonAddTask.Size = new Size(89, 24);
            radioButtonAddTask.TabIndex = 55;
            radioButtonAddTask.TabStop = true;
            radioButtonAddTask.Text = "Add Task";
            radioButtonAddTask.UseVisualStyleBackColor = true;
            radioButtonAddTask.CheckedChanged += radioButtonAddTask_CheckedChanged;
            // 
            // radioButtonpdateTask
            // 
            radioButtonpdateTask.AutoSize = true;
            radioButtonpdateTask.Location = new Point(423, 38);
            radioButtonpdateTask.Name = "radioButtonpdateTask";
            radioButtonpdateTask.Size = new Size(110, 24);
            radioButtonpdateTask.TabIndex = 56;
            radioButtonpdateTask.TabStop = true;
            radioButtonpdateTask.Text = "Update Task";
            radioButtonpdateTask.UseVisualStyleBackColor = true;
            radioButtonpdateTask.CheckedChanged += radioButtonpdateTask_CheckedChanged;
            // 
            // TaskUC
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelEmpty);
            Controls.Add(radioButtonpdateTask);
            Controls.Add(radioButtonAddTask);
            Controls.Add(groupBox1);
            Controls.Add(gbAddBook);
            Location = new Point(140, 40);
            Name = "TaskUC";
            Size = new Size(1692, 984);
            Load += TaskUC_Load;
            panelEmpty.ResumeLayout(false);
            panelEmpty.PerformLayout();
            gbAddBook.ResumeLayout(false);
            gbAddBook.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbAddBook;
        private Button btnAddTask;
        private Label label3;
        private TextBox txtAddTask;
        private Label labelTaskAdd;
        private Label label5;
        private Label label2;
        private DateTimePicker setTimeForTheTask;
        private Label label10;
        private CheckedListBox checkedListBox1;
        private Label label4;
        private ComboBox cbbSelectArea;
        private Button btnRemoveTask;
        private GroupBox groupBox1;
        private Button button1;
        private Panel panel1;
        private Label label1;
        private RadioButton radioButtonAddTask;
        private RadioButton radioButtonpdateTask;
        private Label labelSelectTaskUpdate;
        private ComboBox cbbSelectTaskForUpdate;
        private Label labelShowArea;
        private Button btnUpdateTask;
        private Label displaycurrentfreq;
        private Label labelCurrentFrequency;
        private Label label11;
        private Label labelUpdateTask;
        private Label labelAddTask;
        private Label labelcurrenttime;
        private Label lanelCurrentTime;
        private TextBox textBoxDescriprion;
        private DataGridView dataGridView1;
        private Label labelcurrentlocation;
    }
}
