using System;
using System.IO;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] line = System.IO.File.ReadAllLines(@"C:\Users\Marat\source\repos\Week2\madara.txt");
            //System.Console.WriteLine(@"C:\Users\Marat\source\repos\Week2\madara.txt = {0}", line);
            FileStream fs = new FileStream(@"C:\Users\Marat\source\repos\Week2\output.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            string[] line1 = line[0].Split(' ');//убираем из строки пробелы
            int[] a = new int[line1.Length];//массив всех чисел
            int[] b = new int[line1.Length];// массив простых чисел

            for (int i = 0; i < line1.Length; i++)
            {
                a[i] = int.Parse(line1[i]);//каждый элемент строки превращаем в число
                bool NotPrime = false;//в начале все простые числа
                for (int j = 2; j <= Math.Sqrt(a[i]); j++)//пробегаем до подкорня a[i] так как дальше нет необходимости
                {
                    if (a[i] % j == 0)
                    {
                        NotPrime = true;//если a[i] делится хоть на какое-то число то она не простая
                        break;
                    }
                }

                if (!NotPrime && a[i] != 1)//если она простая и не равно 1
                {
                    b[i] = a[i]; //то кладем это число в массив с простыми числами
                }

            }
            for(int i=0; i < b.Length; i++)
            {
                if (b[i] != 0)
                    sw.Write($"{b[i]} ");//выводим простые числа
            }
            sw.Close(); 
            fs.Close();
                
        }
    }
}
