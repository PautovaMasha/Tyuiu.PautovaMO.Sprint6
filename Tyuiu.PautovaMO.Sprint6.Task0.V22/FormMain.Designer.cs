namespace Tyuiu.PautovaMO.Sprint6.Task0.V22
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonDone = new Button();
            groupBox1 = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            groupBox2 = new GroupBox();
            textBox5 = new TextBox();
            textBoxResult = new TextBox();
            groupBox3 = new GroupBox();
            textBoxX = new TextBox();
            textBoxVarX = new TextBox();
            buttonHelp = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(405, 315);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(111, 34);
            buttonDone.TabIndex = 0;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBoxFormula);
            groupBox1.Controls.Add(textBoxTask);
            groupBox1.Location = new Point(24, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(492, 191);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(259, 39);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(216, 36);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 39);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(247, 146);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBoxResult);
            groupBox2.Location = new Point(251, 209);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Вывод данных";
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.Menu;
            textBox5.Location = new Point(64, 33);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 23);
            textBox5.TabIndex = 1;
            textBox5.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(64, 62);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(111, 23);
            textBoxResult.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxX);
            groupBox3.Controls.Add(textBoxVarX);
            groupBox3.Location = new Point(24, 209);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(200, 124);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Ввод данных";
            // 
            // textBoxX
            // 
            textBoxX.BackColor = SystemColors.Menu;
            textBoxX.Location = new Point(38, 33);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(100, 23);
            textBoxX.TabIndex = 1;
            textBoxX.Text = "Переменная Х";
            // 
            // textBoxVarX
            // 
            textBoxVarX.Location = new Point(38, 62);
            textBoxVarX.Name = "textBoxVarX";
            textBoxVarX.Size = new Size(100, 23);
            textBoxVarX.TabIndex = 2;
            textBoxVarX.KeyPress += textBoxVarX_KeyPress;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(362, 315);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(37, 34);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 374);
            Controls.Add(buttonHelp);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(buttonDone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 22 | Паутова М.О.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxTask;
        private TextBox textBoxX;
        private TextBox textBoxVarX;
        private PictureBox pictureBoxFormula;
        private TextBox textBox5;
        private TextBox textBoxResult;
        private Button buttonHelp;
    }
}
