using Tyuiu.PautovaMO.Sprint6.Task2.V16.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task2.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        
        DataService ds = new DataService();

        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStartStep.Text);
                int stoptStep = Convert.ToInt32(textBoxStopStep.Text);

                
                int len = ds.GetMassFunction(startStep, stoptStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stoptStep);

                this.chartFunction.Titles.Add("График функции ");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Y";
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";

                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewFunction.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);

                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonDone_MouseDown(object sender, MouseEventArgs e)
        {
            // Код при нажатии кнопки мыши на кнопке
            buttonDone.BackColor = Color.Gray;
        }

        private void buttonDone_MouseEnter(object sender, EventArgs e)
        {
            // Код при наведении курсора на кнопку
            buttonDone.BackColor = Color.LightBlue;
        }

        private void buttonDone_MouseLeave(object sender, EventArgs e)
        {
            // Код при уходе курсора с кнопки
            buttonDone.BackColor = SystemColors.Control;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Паутова Мария Олеговна", "Сообщение");
        }
    }
    }

