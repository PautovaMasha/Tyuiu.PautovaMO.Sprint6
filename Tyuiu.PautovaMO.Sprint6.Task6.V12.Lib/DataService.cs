using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.PautovaMO.Sprint6.Task6.V12.Lib
{
    public class DataService : ISprint6Task6V12
    {
        public string CollectTextFromFile(string path)
        {


            if (path == null)
            {
                return "Сначала выберите файл";
            }

            string result = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(' ', '\t');

                    foreach (string word in words)
                    {
                        if (!string.IsNullOrEmpty(word))
                        {
                            if (word.Contains("w") || word.Contains("W"))
                            {
                                result += word + " ";
                            }
                        }
                    }
                }
            }

            return result.Trim();
        }
        }
    }


