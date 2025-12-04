namespace Tyuiu.PautovaMO.Sprint6.Task2.V16
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
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBox2 = new GroupBox();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            textBoxResult = new TextBox();
            groupBox3 = new GroupBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBoxStopStep = new TextBox();
            textBoxStartStep = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            groupBoxTask.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Location = new Point(12, 12);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(350, 299);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.BackColor = SystemColors.MenuBar;
            textBoxTask.Location = new Point(6, 66);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(338, 125);
            textBoxTask.TabIndex = 2;
            textBoxTask.Text = "Написать программу, которая выводит таблицу значений функции:\r\n\r\nF(x) = cos(x)/(x-0.4) + sin(x)*8*x + 2\r\n\r\nПроизвести табулирование";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chartFunction);
            groupBox2.Controls.Add(dataGridViewFunction);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(368, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(530, 388);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartFunction.Legends.Add(legend1);
            chartFunction.Location = new Point(126, 22);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(391, 360);
            chartFunction.TabIndex = 4;
            chartFunction.Text = "chart1";
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction.Location = new Point(6, 51);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.ScrollBars = ScrollBars.Vertical;
            dataGridViewFunction.Size = new Size(121, 331);
            dataGridViewFunction.TabIndex = 3;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.Name = "X";
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(X)";
            F.Name = "F";
            F.Width = 50;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(100, 23);
            textBoxResult.TabIndex = 3;
            textBoxResult.Text = "Результат";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBox3);
            groupBox3.Controls.Add(textBox4);
            groupBox3.Controls.Add(textBoxStopStep);
            groupBox3.Controls.Add(textBoxStartStep);
            groupBox3.Location = new Point(12, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(176, 83);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(98, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(72, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "Конец шага";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(6, 26);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(69, 23);
            textBox4.TabIndex = 5;
            textBox4.Text = "Старт шага";
            // 
            // textBoxStopStep
            // 
            textBoxStopStep.Location = new Point(98, 54);
            textBoxStopStep.Name = "textBoxStopStep";
            textBoxStopStep.Size = new Size(72, 23);
            textBoxStopStep.TabIndex = 6;
            // 
            // textBoxStartStep
            // 
            textBoxStartStep.Location = new Point(6, 54);
            textBoxStartStep.Name = "textBoxStartStep";
            textBoxStartStep.Size = new Size(69, 23);
            textBoxStartStep.TabIndex = 7;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.ActiveCaption;
            buttonHelp.Location = new Point(194, 343);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(67, 40);
            buttonHelp.TabIndex = 0;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LawnGreen;
            buttonDone.Location = new Point(267, 343);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(95, 40);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 450);
            Controls.Add(groupBox3);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBox2);
            Controls.Add(groupBoxTask);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 16 | Паутова М.О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonHelp;
        private Button buttonDone;
        private TextBox textBoxTask;
        private TextBox textBoxResult;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBoxStopStep;
        private TextBox textBoxStartStep;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }
}
