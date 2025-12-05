namespace Tyuiu.PautovaMO.Sprint6.Task4.V15
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask = new GroupBox();
            textBoxStartStep_PMO = new TextBox();
            textBoxStopStep_PMO = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            textBoxTask = new TextBox();
            buttonSave_PMO = new Button();
            buttonDone_PMO = new Button();
            buttonHelp_PMO = new Button();
            groupBoxRes = new GroupBox();
            chartFunction_PMO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox3 = new GroupBox();
            textBoxResult_PMO = new TextBox();
            splitter1 = new Splitter();
            groupBoxTask.SuspendLayout();
            groupBoxRes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_PMO).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxStartStep_PMO);
            groupBoxTask.Controls.Add(textBoxStopStep_PMO);
            groupBoxTask.Controls.Add(textBox2);
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Controls.Add(buttonSave_PMO);
            groupBoxTask.Controls.Add(buttonDone_PMO);
            groupBoxTask.Controls.Add(buttonHelp_PMO);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(859, 94);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxStartStep_PMO
            // 
            textBoxStartStep_PMO.Location = new Point(412, 65);
            textBoxStartStep_PMO.Name = "textBoxStartStep_PMO";
            textBoxStartStep_PMO.Size = new Size(89, 23);
            textBoxStartStep_PMO.TabIndex = 6;
            // 
            // textBoxStopStep_PMO
            // 
            textBoxStopStep_PMO.Location = new Point(519, 65);
            textBoxStopStep_PMO.Name = "textBoxStopStep_PMO";
            textBoxStopStep_PMO.Size = new Size(85, 23);
            textBoxStopStep_PMO.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(412, 37);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(89, 23);
            textBox2.TabIndex = 4;
            textBox2.Text = "Старт шага";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(519, 36);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(85, 23);
            textBox1.TabIndex = 3;
            textBox1.Text = "Конец шага";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 21);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(389, 67);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции:\r\nF(x) = sin(x) + (2x)/3 - cos(x) * 4x\r\n\r\nПроизвести табулирование f(x) на заданном диапазоне";
            textBoxTask.TextChanged += textBoxTask_TextChanged;
            // 
            // buttonSave_PMO
            // 
            buttonSave_PMO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSave_PMO.BackColor = Color.FromArgb(255, 192, 255);
            buttonSave_PMO.Location = new Point(777, 22);
            buttonSave_PMO.Name = "buttonSave_PMO";
            buttonSave_PMO.Size = new Size(75, 51);
            buttonSave_PMO.TabIndex = 2;
            buttonSave_PMO.Text = "Сохранить";
            buttonSave_PMO.UseVisualStyleBackColor = false;
            buttonSave_PMO.Click += buttonSave_PMO_Click;
            // 
            // buttonDone_PMO
            // 
            buttonDone_PMO.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_PMO.Location = new Point(693, 22);
            buttonDone_PMO.Name = "buttonDone_PMO";
            buttonDone_PMO.Size = new Size(78, 51);
            buttonDone_PMO.TabIndex = 1;
            buttonDone_PMO.Text = "Выполнить";
            buttonDone_PMO.UseVisualStyleBackColor = false;
            buttonDone_PMO.Click += buttonDone_PMO_Click;
            // 
            // buttonHelp_PMO
            // 
            buttonHelp_PMO.BackColor = Color.FromArgb(192, 255, 255);
            buttonHelp_PMO.Location = new Point(623, 22);
            buttonHelp_PMO.Name = "buttonHelp_PMO";
            buttonHelp_PMO.Size = new Size(64, 51);
            buttonHelp_PMO.TabIndex = 0;
            buttonHelp_PMO.Text = "Справка";
            buttonHelp_PMO.UseVisualStyleBackColor = false;
            buttonHelp_PMO.Click += buttonHelp_PMO_Click;
            // 
            // groupBoxRes
            // 
            groupBoxRes.Controls.Add(chartFunction_PMO);
            groupBoxRes.Dock = DockStyle.Fill;
            groupBoxRes.Location = new Point(0, 94);
            groupBoxRes.Name = "groupBoxRes";
            groupBoxRes.Size = new Size(859, 357);
            groupBoxRes.TabIndex = 0;
            groupBoxRes.TabStop = false;
            groupBoxRes.Text = "Вывод";
            // 
            // chartFunction_PMO
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_PMO.ChartAreas.Add(chartArea1);
            chartFunction_PMO.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartFunction_PMO.Legends.Add(legend1);
            chartFunction_PMO.Location = new Point(3, 19);
            chartFunction_PMO.Name = "chartFunction_PMO";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_PMO.Series.Add(series1);
            chartFunction_PMO.Size = new Size(853, 335);
            chartFunction_PMO.TabIndex = 1;
            chartFunction_PMO.Text = "График";
            title1.Name = "фунция ";
            title1.Text = "График функции";
            chartFunction_PMO.Titles.Add(title1);
            chartFunction_PMO.Click += chartFunction_PMO_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_PMO);
            groupBox3.Controls.Add(splitter1);
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(0, 94);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(157, 357);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод";
            // 
            // textBoxResult_PMO
            // 
            textBoxResult_PMO.Dock = DockStyle.Left;
            textBoxResult_PMO.Location = new Point(3, 19);
            textBoxResult_PMO.Multiline = true;
            textBoxResult_PMO.Name = "textBoxResult_PMO";
            textBoxResult_PMO.ReadOnly = true;
            textBoxResult_PMO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_PMO.Size = new Size(143, 335);
            textBoxResult_PMO.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(151, 19);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 335);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 451);
            Controls.Add(groupBox3);
            Controls.Add(groupBoxRes);
            Controls.Add(groupBoxTask);
            MinimumSize = new Size(875, 490);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 15 | Паутова М.О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxRes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_PMO).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBoxRes;
        private GroupBox groupBox3;
        private Splitter splitter1;
        private Button buttonSave_PMO;
        private Button buttonDone_PMO;
        private Button buttonHelp_PMO;
        private TextBox textBoxTask;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_PMO;
        private TextBox textBoxResult_PMO;
        private TextBox textBoxStartStep_PMO;
        private TextBox textBoxStopStep_PMO;
        private TextBox textBox2;
        private TextBox textBox1;
    }
}
