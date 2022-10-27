using System;
using System.Collections.Generic;
using System.Text;

namespace CSVWorks
{
    // Класс с информацией (разработчик, функции...)
    public class Info
    {
        const string libName = "CSVBuilder";
        const string developer = "Румянцев Максим";
        const string version = "0.1";
        const string buildDate = "05.03.2021"; // DD.MM.YYYY

        // О библиотеке
        public static string About()
        {
            return libName + " by " + developer + "\n"
                + "v" + version + " from " + buildDate;
        }

        // Функции библиотеки
        public static string Help()
        {
            string outHelp = ""; // Выходная переменная

            outHelp += "Класс CsvIO - обработка файла CSV (чтение и запись):";
            outHelp += "\n\tpublic static string[,] Parse(string filePath) - чтение csv файла в двумерный массив:";
            outHelp += "\n\t\tstring filePath - путь к файлу.";
            outHelp += "\n\t\tВозвращает двумерный массив-таблицу.";
            outHelp += "\n\n\tpublic static string Write(string[,] table) - запись двумерного массива в строку.";
            outHelp += "\n\t\tstring[,] table - двумерный массив.";
            outHelp += "\n\t\tВозвращает строку, достаточную для записи при помощи System.IO.File.WriteAllText.";
            outHelp += "\n\n\tpublic static string Write(string[,] table, string filePath) - запись двумерного массива в строку.";
            outHelp += "\n\t\tstring[,] table - двумерный массив.";
            outHelp += "\n\t\tstring filePath - путь к файлу.";
            outHelp += "\n\t\tВозвращает строку, достаточную для записи при помощи System.IO.File.WriteAllText, а также сохраняет в filePath.";

            return outHelp;
        }
    }
}
