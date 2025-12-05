using Tyuiu.PautovaMO.Sprint6.Task3.V12.Lib;
namespace Tyuiu.PautovaMO.Sprint6.Task3.V12
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] mtrx = new int[5, 5]
         {
            { -6, -13, -1, -7, 10 },
            { 14, -18, 18, 1, 11 },
            { -2, -17, -15, -10, -8 },
            { 19, -4, -6, -11, 8 },
            { -17, 17, 14, 13, 19 }
        };
        private void buttonHelp_PMO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИБКСб-25-1 Паутова Мария Олеговна",
                          "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void FormMain_Load(object sender, EventArgs e)
        {

            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewMatrix_PMO.ColumnCount = columns;
            dataGridViewMatrix_PMO.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_PMO.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_PMO.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                }
            }
        }
        
        private void buttonDone_PMO_Click(object sender, EventArgs e)
        {
            int[,] resultMatrix = ds.Calculate(mtrx);
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.Length / rows;

            dataGridViewResult_PMO.ColumnCount = columns;
            dataGridViewResult_PMO.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_PMO.Columns[i].Width = 25;
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult_PMO.Rows[i].Cells[j].Value = resultMatrix[i, j];
                }
            }
        }
    }
}
