namespace Tyuiu.PautovaMO.Sprint6.Task7.V20
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonOk_PMO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 207);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(292, 69);
            textBox1.TabIndex = 1;
            textBox1.Text = "Выполнил работу студент группы ИБКС Паутова Мария";
            // 
            // buttonOk_PMO
            // 
            buttonOk_PMO.Location = new Point(373, 173);
            buttonOk_PMO.Name = "buttonOk_PMO";
            buttonOk_PMO.Size = new Size(75, 23);
            buttonOk_PMO.TabIndex = 2;
            buttonOk_PMO.Text = "ОК";
            buttonOk_PMO.UseVisualStyleBackColor = true;
            buttonOk_PMO.Click += buttonOk_PMO_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 208);
            ControlBox = false;
            Controls.Add(buttonOk_PMO);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            MaximumSize = new Size(476, 247);
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonOk_PMO;
    }
}