

namespace Tyuiu.PautovaMO.Sprint6.Task5.V28
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
            textBoxTask_PMO = new TextBox();
            buttonHelp_PMO = new Button();
            buttonDone_PMO = new Button();
            buttonOpenFile_PMO = new Button();
            groupBox = new GroupBox();
            dataGridViewNums_PMO = new DataGridView();
            splitter1 = new Splitter();
            groupBoxGraf = new GroupBox();
            splitter2 = new Splitter();
            chartDiag_PMO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask.SuspendLayout();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_PMO).BeginInit();
            groupBoxGraf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag_PMO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask_PMO);
            groupBoxTask.Controls.Add(buttonHelp_PMO);
            groupBoxTask.Controls.Add(buttonDone_PMO);
            groupBoxTask.Controls.Add(buttonOpenFile_PMO);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 0);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(836, 72);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие";
            groupBoxTask.Enter += groupBoxTask_Enter;
            // 
            // textBoxTask_PMO
            // 
            textBoxTask_PMO.Location = new Point(6, 22);
            textBoxTask_PMO.Multiline = true;
            textBoxTask_PMO.Name = "textBoxTask_PMO";
            textBoxTask_PMO.ReadOnly = true;
            textBoxTask_PMO.Size = new Size(525, 44);
            textBoxTask_PMO.TabIndex = 2;
            textBoxTask_PMO.Text = "Прочитать данные из файла InPutFileTask5V28.txt. Вывести в dataGridView. Вывести все числа, меньше 10. Построить диаграмму по этим значениям. ";
            textBoxTask_PMO.TextChanged += textBoxTask_PMO_TextChanged;
            // 
            // buttonHelp_PMO
            // 
            buttonHelp_PMO.Anchor = AnchorStyles.Top;
            buttonHelp_PMO.BackColor = Color.FromArgb(255, 192, 192);
            buttonHelp_PMO.Location = new Point(537, 22);
            buttonHelp_PMO.Name = "buttonHelp_PMO";
            buttonHelp_PMO.Size = new Size(75, 44);
            buttonHelp_PMO.TabIndex = 3;
            buttonHelp_PMO.Text = "Справка";
            buttonHelp_PMO.UseVisualStyleBackColor = false;
            buttonHelp_PMO.Click += buttonHelp_PMO_Click;
            // 
            // buttonDone_PMO
            // 
            buttonDone_PMO.Anchor = AnchorStyles.Top;
            buttonDone_PMO.BackColor = Color.FromArgb(192, 255, 192);
            buttonDone_PMO.Location = new Point(618, 22);
            buttonDone_PMO.Name = "buttonDone_PMO";
            buttonDone_PMO.Size = new Size(98, 44);
            buttonDone_PMO.TabIndex = 4;
            buttonDone_PMO.Text = "Выполнить";
            buttonDone_PMO.UseVisualStyleBackColor = false;
            buttonDone_PMO.Click += buttonDone_PMO_Click;
            // 
            // buttonOpenFile_PMO
            // 
            buttonOpenFile_PMO.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_PMO.BackColor = Color.FromArgb(192, 255, 255);
            buttonOpenFile_PMO.Location = new Point(731, 22);
            buttonOpenFile_PMO.Name = "buttonOpenFile_PMO";
            buttonOpenFile_PMO.Size = new Size(85, 44);
            buttonOpenFile_PMO.TabIndex = 5;
            buttonOpenFile_PMO.Text = "Открыть файл";
            buttonOpenFile_PMO.UseVisualStyleBackColor = false;
            buttonOpenFile_PMO.Click += buttonOpenFile_PMO_Click;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(dataGridViewNums_PMO);
            groupBox.Controls.Add(splitter1);
            groupBox.Dock = DockStyle.Left;
            groupBox.Location = new Point(0, 72);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(176, 374);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Вывод данных";
            // 
            // dataGridViewNums_PMO
            // 
            dataGridViewNums_PMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums_PMO.Location = new Point(6, 19);
            dataGridViewNums_PMO.Name = "dataGridViewNums_PMO";
            dataGridViewNums_PMO.RowHeadersVisible = false;
            dataGridViewNums_PMO.ScrollBars = ScrollBars.Vertical;
            dataGridViewNums_PMO.Size = new Size(158, 349);
            dataGridViewNums_PMO.TabIndex = 1;
            dataGridViewNums_PMO.Visible = false;
            dataGridViewNums_PMO.CellContentClick += dataGridViewNums_PMO_CellContentClick;
            // 
            // splitter1
            // 
            splitter1.Dock = DockStyle.Right;
            splitter1.Location = new Point(170, 19);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 352);
            splitter1.TabIndex = 0;
            splitter1.TabStop = false;
            // 
            // groupBoxGraf
            // 
            groupBoxGraf.Controls.Add(splitter2);
            groupBoxGraf.Controls.Add(chartDiag_PMO);
            groupBoxGraf.Dock = DockStyle.Fill;
            groupBoxGraf.Location = new Point(0, 72);
            groupBoxGraf.Name = "groupBoxGraf";
            groupBoxGraf.Size = new Size(836, 374);
            groupBoxGraf.TabIndex = 0;
            groupBoxGraf.TabStop = false;
            // 
            // splitter2
            // 
            splitter2.Location = new Point(3, 19);
            splitter2.Name = "splitter2";
            splitter2.Size = new Size(3, 352);
            splitter2.TabIndex = 1;
            splitter2.TabStop = false;
            // 
            // chartDiag_PMO
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag_PMO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartDiag_PMO.Legends.Add(legend1);
            chartDiag_PMO.Location = new Point(179, 19);
            chartDiag_PMO.Name = "chartDiag_PMO";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag_PMO.Series.Add(series1);
            chartDiag_PMO.Size = new Size(657, 369);
            chartDiag_PMO.TabIndex = 0;
            chartDiag_PMO.Text = "chart1";
            chartDiag_PMO.Click += chartDaig_PMO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 446);
            Controls.Add(groupBox);
            Controls.Add(groupBoxGraf);
            Controls.Add(groupBoxTask);
            MinimumSize = new Size(852, 400);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6| Таск 5|  Вариант 28 | Паутова М.О.";
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums_PMO).EndInit();
            groupBoxGraf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag_PMO).EndInit();
            ResumeLayout(false);
        }






        #endregion

        private GroupBox groupBoxTask;
        private GroupBox groupBox;
        private GroupBox groupBoxGraf;
        private Splitter splitter1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag_PMO;
        private DataGridView dataGridViewNums_PMO;
        private Splitter splitter2;
        private TextBox textBoxTask_PMO;
        private Button buttonHelp_PMO;
        private Button buttonDone_PMO;
        private Button buttonOpenFile_PMO;
    }
}
