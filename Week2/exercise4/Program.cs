using System;
using System.IO;

class Test
{
    public static void Main()
    {
        string file = "input.txt";
        string path = @"C:\Users\Marat\source\repos\Week2\path\" + file;
        string path1 = @"C:\Users\Marat\source\repos\Week2\path1\" + file;

        //создаем файл в папке path
        FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write);
        //копируем в новую папку path1 от path
        fs.Close();
        File.Copy(path, path1);
        //удаляем старый файл
        File.Delete(path);
    }
}
