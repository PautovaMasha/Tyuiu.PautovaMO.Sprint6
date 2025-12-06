using System.IO;
using Tyuiu.PautovaMO.Sprint6.Task5.V28.Lib;

namespace Tyuiu.PautovaMO.Sprint6.Task5.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        string path = @"C:\DataSprint6\InPutDataFileTask5V28.txt";

        private void buttonDone_PMO_Click(object sender, EventArgs e)
        {
            dataGridViewNums_PMO.ColumnCount = 2;
            dataGridViewNums_PMO.Columns[0].Width = 20;
            dataGridViewNums_PMO.Columns[1].Width = 50;

            this.chartDiag_PMO.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartDiag_PMO.ChartAreas[0].AxisY.Title = "Ось Y";

            chartDiag_PMO.Series[0].Points.Clear();
            dataGridViewNums_PMO.Rows.Clear();

            double[] numsMass = ds.LoadFromDataFile(path);

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewNums_PMO.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartDiag_PMO.Series[0].Points.AddXY(i, numsMass[i]);
            }

        }

        private void buttonOpenFile_PMO_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process(); txt.StartInfo.FileName = "notepad.exe"; txt.StartInfo.Arguments = path; txt.Start();
        }

        private void chartDaig_PMO_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewNums_PMO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxTask_PMO_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxTask_Enter(object sender, EventArgs e)
        {

        }
        private void buttonHelp_PMO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИБКСб-25-1 Паутова Мария Олеговна",
                          "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
