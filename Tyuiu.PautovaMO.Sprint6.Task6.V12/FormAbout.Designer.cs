namespace Tyuiu.PautovaMO.Sprint6.Task6.V12
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
            textBoxInfo = new TextBox();
            buttonOk_PMO = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 262);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxInfo.Location = new Point(177, 0);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(354, 188);
            textBoxInfo.TabIndex = 1;
            textBoxInfo.Text = "Работу выполнил студент группы  ИБКСб-25-1\r\nПаутова М.О.\r\nТюменский Идустриальный Универститет\r\n\r\n";
            // 
            // buttonOk_PMO
            // 
            buttonOk_PMO.Location = new Point(414, 194);
            buttonOk_PMO.Name = "buttonOk_PMO";
            buttonOk_PMO.Size = new Size(106, 55);
            buttonOk_PMO.TabIndex = 2;
            buttonOk_PMO.Text = "Ок";
            buttonOk_PMO.UseVisualStyleBackColor = true;
            buttonOk_PMO.Click += buttonOk_PMO_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 261);
            Controls.Add(buttonOk_PMO);
            Controls.Add(textBoxInfo);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAbout";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox textBoxInfo;
        private Button buttonOk_PMO;
    }
}