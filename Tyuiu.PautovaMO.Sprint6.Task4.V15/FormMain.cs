using Tyuiu.PautovaMO.Sprint6.Task4.V15.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task4.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_PMO_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep_PMO.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_PMO.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);

                //this.chartFunction.Titles.Add("График функции sin(x)");
                this.chartFunction_PMO.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_PMO.ChartAreas[0].AxisY.Title = "Ось Y";

                textBoxResult_PMO.Text = "";

                chartFunction_PMO.Series[0].Points.Clear();
                for (int i = 0; i <= len - 1; i++)
                {
                    this.chartFunction_PMO.Series[0].Points.AddXY(startStep, valueArray[i]);
                    textBoxResult_PMO.AppendText(valueArray[i] + Environment.NewLine);
                    startStep++;
                }

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSave_PMO_Click(object sender, EventArgs e)
        {
            try
            {
                string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask4V15.txt";
                File.WriteAllText(path, textBoxResult_PMO.Text);

                DialogResult dialogResult = MessageBox.Show(
                    "Файл " + path + " сохранен успешно!\n Открыть?",
                    "Сообщение",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information
                );

                if (dialogResult == DialogResult.Yes)
                {
                    System.Diagnostics.Process txt = new System.Diagnostics.Process();
                    txt.StartInfo.FileName = "notepad.exe";
                    txt.StartInfo.Arguments = path;
                    txt.Start();
                }
            }
            catch
            {
                MessageBox.Show("Сбой при сохранении файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chartFunction_PMO_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTask_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonHelp_PMO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Паутова Мария Олеговна",
                          "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}   

    

