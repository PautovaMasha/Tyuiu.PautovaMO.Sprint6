namespace Tyuiu.PautovaMO.Sprint6.Task7.V20
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_PMO = new Panel();
            buttonHelp_PMO = new Button();
            buttonSaveFile_PMO = new Button();
            buttonDone_PMO = new Button();
            buttonOpenFile_PMO = new Button();
            groupBoxTask_PMO = new GroupBox();
            textBox1 = new TextBox();
            groupBox1Task = new GroupBox();
            dataGridViewOut_PMO = new DataGridView();
            splitterTask = new Splitter();
            groupBoxTask = new GroupBox();
            dataGridViewIn_PMO = new DataGridView();
            openFileDialogTask_PMO = new OpenFileDialog();
            toolTipButton_PMO = new ToolTip(components);
            saveFileDialogMatrix_PMO = new SaveFileDialog();
            panelTop_PMO.SuspendLayout();
            groupBoxTask_PMO.SuspendLayout();
            groupBox1Task.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PMO).BeginInit();
            groupBoxTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PMO).BeginInit();
            SuspendLayout();
            // 
            // panelTop_PMO
            // 
            panelTop_PMO.Controls.Add(buttonHelp_PMO);
            panelTop_PMO.Controls.Add(buttonSaveFile_PMO);
            panelTop_PMO.Controls.Add(buttonDone_PMO);
            panelTop_PMO.Controls.Add(buttonOpenFile_PMO);
            panelTop_PMO.Dock = DockStyle.Top;
            panelTop_PMO.Location = new Point(0, 0);
            panelTop_PMO.Name = "panelTop_PMO";
            panelTop_PMO.Size = new Size(800, 62);
            panelTop_PMO.TabIndex = 0;
            // 
            // buttonHelp_PMO
            // 
            buttonHelp_PMO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMO.FlatStyle = FlatStyle.Flat;
            buttonHelp_PMO.Image = (Image)resources.GetObject("buttonHelp_PMO.Image");
            buttonHelp_PMO.Location = new Point(706, 3);
            buttonHelp_PMO.Name = "buttonHelp_PMO";
            buttonHelp_PMO.Size = new Size(67, 56);
            buttonHelp_PMO.TabIndex = 2;
            buttonHelp_PMO.UseVisualStyleBackColor = true;
            buttonHelp_PMO.Click += buttonHelp_PMO_Click;
            buttonHelp_PMO.MouseEnter += buttonHelp_PMO_MouseEnter;
            // 
            // buttonSaveFile_PMO
            // 
            buttonSaveFile_PMO.Enabled = false;
            buttonSaveFile_PMO.FlatStyle = FlatStyle.Flat;
            buttonSaveFile_PMO.Image = (Image)resources.GetObject("buttonSaveFile_PMO.Image");
            buttonSaveFile_PMO.Location = new Point(194, 3);
            buttonSaveFile_PMO.Name = "buttonSaveFile_PMO";
            buttonSaveFile_PMO.Size = new Size(75, 56);
            buttonSaveFile_PMO.TabIndex = 1;
            buttonSaveFile_PMO.UseVisualStyleBackColor = true;
            buttonSaveFile_PMO.Click += buttonSaveFile_PMO_Click;
            buttonSaveFile_PMO.MouseEnter += buttonSaveFile_PMO_MouseEnter;
            // 
            // buttonDone_PMO
            // 
            buttonDone_PMO.Enabled = false;
            buttonDone_PMO.FlatStyle = FlatStyle.Flat;
            buttonDone_PMO.Image = (Image)resources.GetObject("buttonDone_PMO.Image");
            buttonDone_PMO.Location = new Point(102, 3);
            buttonDone_PMO.Name = "buttonDone_PMO";
            buttonDone_PMO.Size = new Size(75, 56);
            buttonDone_PMO.TabIndex = 1;
            buttonDone_PMO.UseVisualStyleBackColor = true;
            buttonDone_PMO.Click += buttonDone_PMO_Click;
            buttonDone_PMO.MouseEnter += buttonDone_PMO_MouseEnter;
            // 
            // buttonOpenFile_PMO
            // 
            buttonOpenFile_PMO.FlatStyle = FlatStyle.Flat;
            buttonOpenFile_PMO.Image = (Image)resources.GetObject("buttonOpenFile_PMO.Image");
            buttonOpenFile_PMO.Location = new Point(12, 3);
            buttonOpenFile_PMO.Name = "buttonOpenFile_PMO";
            buttonOpenFile_PMO.Size = new Size(75, 56);
            buttonOpenFile_PMO.TabIndex = 0;
            buttonOpenFile_PMO.UseVisualStyleBackColor = true;
            buttonOpenFile_PMO.Click += buttonOpenFile_PMO_Click;
            buttonOpenFile_PMO.MouseEnter += buttonOpenFile_PMO_MouseEnter;
            // 
            // groupBoxTask_PMO
            // 
            groupBoxTask_PMO.Controls.Add(textBox1);
            groupBoxTask_PMO.Dock = DockStyle.Top;
            groupBoxTask_PMO.Location = new Point(0, 62);
            groupBoxTask_PMO.Name = "groupBoxTask_PMO";
            groupBoxTask_PMO.Size = new Size(800, 73);
            groupBoxTask_PMO.TabIndex = 1;
            groupBoxTask_PMO.TabStop = false;
            groupBoxTask_PMO.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(797, 48);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // groupBox1Task
            // 
            groupBox1Task.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            groupBox1Task.Controls.Add(dataGridViewOut_PMO);
            groupBox1Task.Controls.Add(splitterTask);
            groupBox1Task.Location = new Point(398, 141);
            groupBox1Task.Name = "groupBox1Task";
            groupBox1Task.Size = new Size(402, 307);
            groupBox1Task.TabIndex = 2;
            groupBox1Task.TabStop = false;
            groupBox1Task.Text = "Вывод";
            // 
            // dataGridViewOut_PMO
            // 
            dataGridViewOut_PMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut_PMO.Location = new Point(12, 19);
            dataGridViewOut_PMO.Name = "dataGridViewOut_PMO";
            dataGridViewOut_PMO.Size = new Size(389, 278);
            dataGridViewOut_PMO.TabIndex = 0;
            // 
            // splitterTask
            // 
            splitterTask.Location = new Point(3, 19);
            splitterTask.Name = "splitterTask";
            splitterTask.Size = new Size(3, 285);
            splitterTask.TabIndex = 0;
            splitterTask.TabStop = false;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTask.Controls.Add(dataGridViewIn_PMO);
            groupBoxTask.Location = new Point(3, 141);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(397, 307);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Ввод";
            // 
            // dataGridViewIn_PMO
            // 
            dataGridViewIn_PMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn_PMO.Location = new Point(3, 19);
            dataGridViewIn_PMO.Name = "dataGridViewIn_PMO";
            dataGridViewIn_PMO.Size = new Size(389, 278);
            dataGridViewIn_PMO.TabIndex = 0;
            // 
            // openFileDialogTask_PMO
            // 
            openFileDialogTask_PMO.FileName = "openFileDialog1";
            // 
            // toolTipButton_PMO
            // 
            toolTipButton_PMO.IsBalloon = true;
            toolTipButton_PMO.ToolTipIcon = ToolTipIcon.Info;
            toolTipButton_PMO.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTask);
            Controls.Add(groupBox1Task);
            Controls.Add(groupBoxTask_PMO);
            Controls.Add(panelTop_PMO);
            Name = "FormMain";
            Text = "Спринт 6 Таск 7 Вариант 20 Паутова М.О.";
            WindowState = FormWindowState.Maximized;
            panelTop_PMO.ResumeLayout(false);
            groupBoxTask_PMO.ResumeLayout(false);
            groupBoxTask_PMO.PerformLayout();
            groupBox1Task.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut_PMO).EndInit();
            groupBoxTask.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn_PMO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop_PMO;
        private Button buttonHelp_PMO;
        private Button buttonDone_PMO;
        private Button buttonOpenFile_PMO;
        private Button buttonSaveFile_PMO;
        private GroupBox groupBoxTask_PMO;
        private TextBox textBox1;
        private GroupBox groupBox1Task;
        private GroupBox groupBoxTask;
        private Splitter splitterTask;
        private DataGridView dataGridViewIn_PMO;
        private DataGridView dataGridViewOut_PMO;
        private OpenFileDialog openFileDialogTask_PMO;
        private ToolTip toolTipButton_PMO;
        private SaveFileDialog saveFileDialogMatrix_PMO;
    }
}
