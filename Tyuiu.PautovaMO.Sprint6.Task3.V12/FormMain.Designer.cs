namespace Tyuiu.PautovaMO.Sprint6.Task3.V12
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
            groupBoxResult_PMO = new GroupBox();
            dataGridViewResult_PMO = new DataGridView();
            textBoxRes_PMO = new TextBox();
            groupBoxTask_PMO = new GroupBox();
            dataGridViewMatrix_PMO = new DataGridView();
            textBoxTask_PMO = new TextBox();
            buttonHelp_PMO = new Button();
            buttonDone_PMO = new Button();
            groupBoxResult_PMO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PMO).BeginInit();
            groupBoxTask_PMO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_PMO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxResult_PMO
            // 
            groupBoxResult_PMO.Controls.Add(dataGridViewResult_PMO);
            groupBoxResult_PMO.Controls.Add(textBoxRes_PMO);
            groupBoxResult_PMO.Location = new Point(467, 12);
            groupBoxResult_PMO.Name = "groupBoxResult_PMO";
            groupBoxResult_PMO.Size = new Size(200, 301);
            groupBoxResult_PMO.TabIndex = 0;
            groupBoxResult_PMO.TabStop = false;
            groupBoxResult_PMO.Text = "Вывод данных";
            // 
            // dataGridViewResult_PMO
            // 
            dataGridViewResult_PMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_PMO.Location = new Point(14, 51);
            dataGridViewResult_PMO.Name = "dataGridViewResult_PMO";
            dataGridViewResult_PMO.ReadOnly = true;
            dataGridViewResult_PMO.RowHeadersVisible = false;
            dataGridViewResult_PMO.Size = new Size(163, 234);
            dataGridViewResult_PMO.TabIndex = 5;
            // 
            // textBoxRes_PMO
            // 
            textBoxRes_PMO.Location = new Point(6, 22);
            textBoxRes_PMO.Name = "textBoxRes_PMO";
            textBoxRes_PMO.Size = new Size(100, 23);
            textBoxRes_PMO.TabIndex = 4;
            textBoxRes_PMO.Text = "Результат";
            // 
            // groupBoxTask_PMO
            // 
            groupBoxTask_PMO.Controls.Add(dataGridViewMatrix_PMO);
            groupBoxTask_PMO.Controls.Add(textBoxTask_PMO);
            groupBoxTask_PMO.Location = new Point(12, 12);
            groupBoxTask_PMO.Name = "groupBoxTask_PMO";
            groupBoxTask_PMO.Size = new Size(449, 379);
            groupBoxTask_PMO.TabIndex = 0;
            groupBoxTask_PMO.TabStop = false;
            groupBoxTask_PMO.Text = "Условие";
            // 
            // dataGridViewMatrix_PMO
            // 
            dataGridViewMatrix_PMO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_PMO.Location = new Point(203, 22);
            dataGridViewMatrix_PMO.Name = "dataGridViewMatrix_PMO";
            dataGridViewMatrix_PMO.RowHeadersVisible = false;
            dataGridViewMatrix_PMO.Size = new Size(240, 252);
            dataGridViewMatrix_PMO.TabIndex = 3;
            // 
            // textBoxTask_PMO
            // 
            textBoxTask_PMO.Location = new Point(6, 22);
            textBoxTask_PMO.Multiline = true;
            textBoxTask_PMO.Name = "textBoxTask_PMO";
            textBoxTask_PMO.ReadOnly = true;
            textBoxTask_PMO.Size = new Size(191, 252);
            textBoxTask_PMO.TabIndex = 2;
            textBoxTask_PMO.Text = "Дан массив 5 на 5 элементов. Заменить четные значения в первой строке на 0.\r\n\r\n\r\n-6 -13  -1  -7  10\r\n\r\n  14 -18  18   1  11\r\n\r\n  -2 -17 -15 -10  -8\r\n\r\n  19  -4  -6 -11   8\r\n\r\n -17  17  14  13  19";
            // 
            // buttonHelp_PMO
            // 
            buttonHelp_PMO.Location = new Point(481, 337);
            buttonHelp_PMO.Name = "buttonHelp_PMO";
            buttonHelp_PMO.Size = new Size(63, 43);
            buttonHelp_PMO.TabIndex = 0;
            buttonHelp_PMO.Text = "Справка";
            buttonHelp_PMO.UseVisualStyleBackColor = true;
            buttonHelp_PMO.Click += buttonHelp_PMO_Click;
            // 
            // buttonDone_PMO
            // 
            buttonDone_PMO.Location = new Point(562, 337);
            buttonDone_PMO.Name = "buttonDone_PMO";
            buttonDone_PMO.Size = new Size(105, 43);
            buttonDone_PMO.TabIndex = 1;
            buttonDone_PMO.Text = "Выполнить";
            buttonDone_PMO.UseVisualStyleBackColor = true;
            buttonDone_PMO.Click += buttonDone_PMO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 450);
            Controls.Add(buttonHelp_PMO);
            Controls.Add(buttonDone_PMO);
            Controls.Add(groupBoxTask_PMO);
            Controls.Add(groupBoxResult_PMO);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 12 | Паутова М.О.";
            Load += FormMain_Load;
            groupBoxResult_PMO.ResumeLayout(false);
            groupBoxResult_PMO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_PMO).EndInit();
            groupBoxTask_PMO.ResumeLayout(false);
            groupBoxTask_PMO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_PMO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxResult_PMO;
        private GroupBox groupBoxTask_PMO;
        private Button buttonHelp_PMO;
        private Button buttonDone_PMO;
        private TextBox textBoxRes_PMO;
        private TextBox textBoxTask_PMO;
        private DataGridView dataGridViewMatrix_PMO;
        private DataGridView dataGridViewResult_PMO;
    }
}
