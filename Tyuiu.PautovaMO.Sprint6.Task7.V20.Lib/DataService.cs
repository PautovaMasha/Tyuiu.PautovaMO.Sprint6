using System;
using System.IO;
using System.Xml;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PautovaMO.Sprint6.Task7.V20.Lib
{
    public class DataService : ISprint6Task7V20
    {
        public int[,] GetMatrix(string path)
        {
            string fileData = File.ReadAllText(path);
            fileData = fileData.Replace('\n', '\r');
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;
            int columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }

            // Заменяем значения в третьем столбце (индекс 2) от 1 до 20 на 111
            for (int r = 0; r < rows; r++)
            {
                if (arrayValues[r, 2] >= 1 && arrayValues[r, 2] <= 20)
                {
                    arrayValues[r, 2] = 111;
                }
            }

            return arrayValues;
        }
    }
}
