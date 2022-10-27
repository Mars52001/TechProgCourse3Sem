using System;
using System.Collections.Generic;
using System.Text;

namespace CSVWorks
{
    public class StaticCsv
    {
        string[,] csv; // CSV-таблице в формате двумерного массива

        public int Rows // Количество строк
        {
            get { return csv.GetLength(0); }
        }

        public int Columns // Количество столбцов
        {
            get { return csv.GetLength(1); }
        }

        public string this[int p, int q] // Индексатор CSV-таблицы
        {
            get { return csv[p, q]; }
            set { csv[p, q] = value; }
        }

        public StaticCsv(string filePath, int extraColumns = 0) // Инициализация CSV-таблицы в двумерный массив (с добавлением (опционально столбцов))
        {
            string[,] temp = СsvIO.Parse(filePath); // Временная таблица

            if (extraColumns != 0)
            {
                csv = new string[temp.GetLength(0), temp.GetLength(1) + extraColumns];
                for (int i = 0; i < temp.GetLength(0); i++)
                    for (int j = 0; j < temp.GetLength(1); j++)
                        csv[i, j] = temp[i, j];
            }
            else
                csv = (string[,])temp.Clone();
        }
    }
}
