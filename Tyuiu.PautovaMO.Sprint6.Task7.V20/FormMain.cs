using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.PautovaMO.Sprint6.Task7.V20.Lib;
using System.IO;

namespace Tyuiu.PautovaMO.Sprint6.Task7.V20
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_PMO.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogMatrix_PMO.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        static int rows;
        static int columns;
        static string openFilePath;
        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;
        }

        private void buttonHelp_PMO_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_PMO_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFilePath);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOut_PMO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonSaveFile_PMO.Enabled = true;
        }

        private void buttonOpenFile_PMO_Click(object sender, EventArgs e)
        {
            openFileDialogTask_PMO.ShowDialog();
            openFilePath = openFileDialogTask_PMO.FileName;
            int[,] arrayValues = new int[rows, columns];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridViewIn_PMO.ColumnCount = columns;
            dataGridViewIn_PMO.RowCount = rows;
            dataGridViewOut_PMO.ColumnCount = columns;
            dataGridViewOut_PMO.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewIn_PMO.Columns[i].Width = 25;
                dataGridViewOut_PMO.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewIn_PMO.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }

            buttonDone_PMO.Enabled = true;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewIn_PMO.ColumnCount = 50;
            dataGridViewOut_PMO.ColumnCount = 50;

            dataGridViewIn_PMO.RowCount = 50;
            dataGridViewOut_PMO.RowCount = 50;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewIn_PMO.Columns[i].Width = 25;
                dataGridViewOut_PMO.Columns[i].Width = 25;
            }
        }

        private void buttonSaveFile_PMO_Click(object sender, EventArgs e)
        {
            saveFileDialogMatrix_PMO.FileName = "OutPutFileTask7V20.csv";
            saveFileDialogMatrix_PMO.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogMatrix_PMO.ShowDialog();

            string path = saveFileDialogMatrix_PMO.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOut_PMO.RowCount;
            int columns = dataGridViewOut_PMO.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewOut_PMO.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewOut_PMO.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonOpenFile_PMO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMO.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_PMO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMO.ToolTipTitle = "Выполнить";
        }

        private void buttonSaveFile_PMO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMO.ToolTipTitle = "Сохранить";
        }

        private void buttonHelp_PMO_MouseEnter(object sender, EventArgs e)
        {
            toolTipButton_PMO.ToolTipTitle = "Справка";
        }
    }
}
