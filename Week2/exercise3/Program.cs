using System;
using System.IO;


namespace exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
           Function();
        }
       /// <summary>
       /// 
       /// </summary>
       /// <param name="f">ссылка на папки и на файлы</param>
       /// <param name="k">кол-во пробелов</param>
        private static void PrintInfo(FileSystemInfo f, int k) //создаем конструктор
        {
            string line = new string(' ', k); //создаем строку из к пробелов
            line = line + f.Name;  //выводит имена папок и файлов
            Console.WriteLine(line);  

            if (f.GetType() == typeof(DirectoryInfo)) //(бэйскейс) рекурсия будет работать до тех пор пока не дойдет до последней папки
            {
                var items = (f as DirectoryInfo).GetFileSystemInfos(); //структура всех папок
                foreach (var i in items) //на каждую папку значение i
                { 
                    PrintInfo(i, k + 4); 
                }
            }
        }
      
        private static void Function()
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\cpp");  
            PrintInfo(dir, 1);
            
        }
             
    }
}

    

