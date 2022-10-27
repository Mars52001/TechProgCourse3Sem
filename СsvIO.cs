using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace CSVWorks
{
    public class СsvIO
    {
        // Парсер csv, возвращает двумерный массив
        public static string[,] Parse(string filePath)
        {
            // Входные
            string[] rawText = File.ReadAllLines(filePath, Encoding.UTF8); ; // Чтение csv-таблицы в массив содержимого файла
            
            // Рабочие
            string[] dataRow = null; // i-ая строка csv-файла

            // Выходные
            string[,] parsed = new string[rawText.Length, rawText[0].Split(',').Length]; // Выходной двумерный массив
            
            for (int i = 0; i < parsed.GetLength(0); i++)
            {
                dataRow = rawText[i].Split(',');
                for (int j = 0; j < parsed.GetLength(1); j++)
                    parsed[i, j] = dataRow[j];
            }

            return parsed;
        }



        // Сохранение двумерного массива в csv (возвращает массив строк для сохранения в формат csv)
        public static string Write(string[,] table)
        {
            // Выходные
            string[] csv = new string[table.GetLength(0)]; // Выходной массив строк для csv

            for (int i = 0; i < table.GetLength(0); i++)
            {
                csv[i] = "";
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (j == table.GetLength(1) - 1)
                        csv[i] += table[i, j];
                    else
                        csv[i] += table[i, j] + ",";
                }
            }

            return String.Join("\n", csv);
        }

        // Перегрузка предыдущей функции. Особенность - сразу сохраняет в файл
        public static string Write(string[,] table, string filePath)
        {
            // Выходные
            string[] csv = new string[table.GetLength(0)]; // Выходной массив строк для csv

            for (int i = 0; i < table.GetLength(0); i++)
            {
                csv[i] = "";
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (j == table.GetLength(1) - 1)
                        csv[i] += table[i, j];
                    else
                        csv[i] += table[i, j] + ",";
                }
            }

            File.WriteAllText(filePath, String.Join("\n", csv));
            return String.Join("\n", csv);
        }
    }
}
