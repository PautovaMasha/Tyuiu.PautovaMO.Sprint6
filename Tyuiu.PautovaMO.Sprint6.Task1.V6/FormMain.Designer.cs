namespace Tyuiu.PautovaMO.Sprint6.Task1.V6
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
            groupBoxTask = new GroupBox();
            groupBoxResult = new GroupBox();
            groupBox3 = new GroupBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            textBoxTask = new TextBox();
            textBoxStop = new TextBox();
            textBoxStart = new TextBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            textBoxResult = new TextBox();
            textBox7 = new TextBox();
            groupBoxTask.SuspendLayout();
            groupBoxResult.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(354, 293);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBox7);
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(364, 12);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(235, 399);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Вывод данных";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxStop);
            groupBox3.Controls.Add(textBoxStart);
            groupBox3.Controls.Add(textBoxStopStep);
            groupBox3.Controls.Add(textBoxStartStep);
            groupBox3.Location = new Point(12, 311);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Chartreuse;
            buttonDone.Location = new Point(285, 328);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(81, 58);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Turquoise;
            buttonHelp.Location = new Point(218, 328);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(61, 58);
            buttonHelp.TabIndex = 1;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.Menu;
            textBoxTask.Location = new Point(6, 45);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(340, 163);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "\r\n\r\n\r\n\r\nНаписать программу, которая выводит таблицу значений функции: \r\n(sin(x) - 2x) / (3x - 1) + sin(x) - 3x + 2\r\n";
            //textBoxTask.TextChanged += textBox1_TextChanged;
            // 
            // textBoxStop
            // 
            textBoxStop.BackColor = SystemColors.Menu;
            textBoxStop.Location = new Point(103, 33);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(82, 23);
            textBoxStop.TabIndex = 3;
            textBoxStop.Text = "Конец шага";
            // 
            // textBoxStart
            // 
            textBoxStart.BackColor = SystemColors.Menu;
            textBoxStart.Location = new Point(6, 33);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(82, 23);
            textBoxStart.TabIndex = 4;
            textBoxStart.Text = "Старт шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(103, 62);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(82, 23);
            textBoxStopStep.TabIndex = 5;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 62);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(82, 23);
            textBoxStartStep.TabIndex = 6;
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.MenuBar;
            textBoxResult.Font = new Font("Consolas", 10F);
            textBoxResult.Location = new Point(6, 48);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(227, 339);
            textBoxResult.TabIndex = 7;
            // 
            // textBox7
            // 
            textBox7.BackColor = SystemColors.Menu;
            textBox7.Location = new Point(6, 19);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(97, 23);
            textBox7.TabIndex = 8;
            textBox7.Text = "Результат";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 450);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxResult);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 6 | Паутова М.О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxResult;
        private GroupBox groupBox3;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private TextBox textBoxStop;
        private TextBox textBoxStart;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private TextBox textBox7;
    }
}
