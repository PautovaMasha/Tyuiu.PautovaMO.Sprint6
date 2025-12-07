
namespace Tyuiu.PautovaMO.Sprint6.Task6.V12
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
            buttonOpenFile_PMO = new Button();
            buttonDone_PMO = new Button();
            buttonHelp_PMO = new Button();
            groupBoxTask = new GroupBox();
            groupBox2Task = new GroupBox();
            textBoxTask = new TextBox();
            openFileDialogTask = new OpenFileDialog();
            toolTipTask = new ToolTip(components);
            groupBoxOutPutData_PMO = new GroupBox();
            textBoxResult_PMO = new TextBox();
            groupBoxTask_PMO = new GroupBox();
            textBoxLoadFromFile_PMO = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBox2Task.SuspendLayout();
            groupBoxOutPutData_PMO.SuspendLayout();
            groupBoxTask_PMO.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpenFile_PMO
            // 
            buttonOpenFile_PMO.Image = (Image)resources.GetObject("buttonOpenFile_PMO.Image");
            buttonOpenFile_PMO.Location = new Point(20, 12);
            buttonOpenFile_PMO.Name = "buttonOpenFile_PMO";
            buttonOpenFile_PMO.Size = new Size(64, 49);
            buttonOpenFile_PMO.TabIndex = 0;
            toolTipTask.SetToolTip(buttonOpenFile_PMO, "Открыть нужный файл");
            buttonOpenFile_PMO.UseVisualStyleBackColor = true;
            buttonOpenFile_PMO.Click += buttonOpenFile_PMO_Click;
            // 
            // buttonDone_PMO
            // 
            buttonDone_PMO.Image = (Image)resources.GetObject("buttonDone_PMO.Image");
            buttonDone_PMO.Location = new Point(101, 12);
            buttonDone_PMO.Name = "buttonDone_PMO";
            buttonDone_PMO.Size = new Size(62, 49);
            buttonDone_PMO.TabIndex = 1;
            toolTipTask.SetToolTip(buttonDone_PMO, "Скаченный файл");
            buttonDone_PMO.UseVisualStyleBackColor = true;
            buttonDone_PMO.Click += buttonDone_PMO_Click;
            // 
            // buttonHelp_PMO
            // 
            buttonHelp_PMO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PMO.BackColor = Color.FromArgb(192, 255, 255);
            buttonHelp_PMO.Location = new Point(707, 12);
            buttonHelp_PMO.Name = "buttonHelp_PMO";
            buttonHelp_PMO.Size = new Size(65, 49);
            buttonHelp_PMO.TabIndex = 1;
            buttonHelp_PMO.Text = "?";
            toolTipTask.SetToolTip(buttonHelp_PMO, "о разработчике");
            buttonHelp_PMO.UseVisualStyleBackColor = false;
            buttonHelp_PMO.Click += buttonHelp_PMO_Click_1;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(buttonOpenFile_PMO);
            groupBoxTask.Controls.Add(buttonDone_PMO);
            groupBoxTask.Controls.Add(buttonHelp_PMO);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(800, 67);
            groupBoxTask.TabIndex = 2;
            groupBoxTask.TabStop = false;
            // 
            // groupBox2Task
            // 
            groupBox2Task.Controls.Add(textBoxTask);
            groupBox2Task.Dock = DockStyle.Top;
            groupBox2Task.Location = new Point(0, 67);
            groupBox2Task.Name = "groupBox2Task";
            groupBox2Task.Size = new Size(800, 63);
            groupBox2Task.TabIndex = 0;
            groupBox2Task.TabStop = false;
            groupBox2Task.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(2, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(784, 35);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            openFileDialogTask.FileOk += openFileDialogTask_FileOk;
            // 
            // toolTipTask
            // 
            toolTipTask.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask.ToolTipTitle = "Подскзка";
            // 
            // groupBoxOutPutData_PMO
            // 
            groupBoxOutPutData_PMO.Controls.Add(textBoxResult_PMO);
            groupBoxOutPutData_PMO.Dock = DockStyle.Right;
            groupBoxOutPutData_PMO.Location = new Point(402, 130);
            groupBoxOutPutData_PMO.Name = "groupBoxOutPutData_PMO";
            groupBoxOutPutData_PMO.Size = new Size(398, 320);
            groupBoxOutPutData_PMO.TabIndex = 3;
            groupBoxOutPutData_PMO.TabStop = false;
            groupBoxOutPutData_PMO.Text = "Выввод данных";
            // 
            // textBoxResult_PMO
            // 
            textBoxResult_PMO.Dock = DockStyle.Right;
            textBoxResult_PMO.Location = new Point(0, 19);
            textBoxResult_PMO.Multiline = true;
            textBoxResult_PMO.Name = "textBoxResult_PMO";
            textBoxResult_PMO.Size = new Size(395, 298);
            textBoxResult_PMO.TabIndex = 0;
            // 
            // groupBoxTask_PMO
            // 
            groupBoxTask_PMO.Controls.Add(textBoxLoadFromFile_PMO);
            groupBoxTask_PMO.Dock = DockStyle.Left;
            groupBoxTask_PMO.Location = new Point(0, 130);
            groupBoxTask_PMO.Name = "groupBoxTask_PMO";
            groupBoxTask_PMO.Size = new Size(394, 320);
            groupBoxTask_PMO.TabIndex = 0;
            groupBoxTask_PMO.TabStop = false;
            groupBoxTask_PMO.Text = "Ввод данных";
            // 
            // textBoxLoadFromFile_PMO
            // 
            textBoxLoadFromFile_PMO.Dock = DockStyle.Left;
            textBoxLoadFromFile_PMO.Location = new Point(3, 19);
            textBoxLoadFromFile_PMO.Multiline = true;
            textBoxLoadFromFile_PMO.Name = "textBoxLoadFromFile_PMO";
            textBoxLoadFromFile_PMO.Size = new Size(382, 298);
            textBoxLoadFromFile_PMO.TabIndex = 1;
            //textBoxLoadFromFile_PMO.TextChanged += textBox2_TextChanged;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxTask_PMO);
            Controls.Add(groupBoxOutPutData_PMO);
            Controls.Add(groupBox2Task);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 Таск 6 Вариант 12 Паутова М.О.";
            groupBoxTask.ResumeLayout(false);
            groupBox2Task.ResumeLayout(false);
            groupBox2Task.PerformLayout();
            groupBoxOutPutData_PMO.ResumeLayout(false);
            groupBoxOutPutData_PMO.PerformLayout();
            groupBoxTask_PMO.ResumeLayout(false);
            groupBoxTask_PMO.PerformLayout();
            ResumeLayout(false);
        }

        //private void textBox2_TextChanged(object sender, EventArgs e)
        //{
           // throw new NotImplementedException();
       // }

        #endregion

        private Button buttonOpenFile_PMO;
        private Button buttonDone_PMO;
        private Button buttonHelp_PMO;
        private GroupBox groupBoxTask;
        private GroupBox groupBox2Task;
        private TextBox textBoxTask;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTipTask;
        private GroupBox groupBoxOutPutData_PMO;
        private GroupBox groupBoxTask_PMO;
        private TextBox textBoxLoadFromFile_PMO;
        private TextBox textBoxResult_PMO;
    }
}
