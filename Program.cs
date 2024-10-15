using System;
using System.IO;
class FileWriter
{
    public static void Main()
    {
        Console.WriteLine("Введите имя файла:");
        string filePath = @"/Users/Public/" + Console.ReadLine() + ".txt"; 

        if (!File.Exists(filePath)) 
        {
            //   Если не существует - создаём и записываем в строку
            using (StreamWriter sw = File.CreateText(filePath))  
            {
                Console.WriteLine("Введите текст:");
                sw.WriteLine(Console.ReadLine());                   
            }
        }
        else
        {
            Console.WriteLine("Продолжайте вводить текст:");
            File.AppendAllText(filePath, Console.ReadLine());
        }
        // Откроем файл и прочитаем его содержимое
        using (StreamReader sr = File.OpenText(filePath))
        {
            Console.WriteLine("Содержимое файла:");
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                Console.WriteLine(str);
            }
        }
    }
}