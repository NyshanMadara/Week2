using System;
using System.IO;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = 0; //кол-во не равных
            FileStream fs = new FileStream(@"C:\Users\Marat\source\repos\Week2\lab2_1.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            String str = sr.ReadLine(); //то что есть в sr сохраняем в str

            int i = 0;
            int j = str.Length - 1;

            while (i < j)
            {
                if (str[i] != str[j]) 
                {
                    cnt++; 
                    i++;
                    j--;
                }
                else
                {
                    i++;
                    j--;
                }

            }
            if (cnt > 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }
            
            sr.Close();
            fs.Close();

        }
    }
}