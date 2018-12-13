using System;
using System.IO;

namespace FileInfo_İslemleri
{
    class Program
    {
        static void Main(string[] args)
        {
            FileInfo NewFile = new FileInfo(@"C:\Test\HedefDizini\NewFilw.txt");
            if (NewFile.Exists) //File sınıfı: if (File.Exist(@"C:\Test\NewFile.txt"))
            {
                //Dosya silme işlemi  //File sınıfı: File.Delete(@"C:\Test\NewFile.txt"))
                NewFile.Delete();
            }
            //Dosya oluşturma
            NewFile.CreateText();  // File sınıfı: File.CreateText(@"C:\Test\NewFilw.txt"))
            Console.WriteLine("Oluşturma tarihi:" + NewFile.CreationTime);
            Console.WriteLine("Son erişim  tarihi:" + NewFile.LastAccessTime);
            Console.WriteLine("Son değiştirilme tarihi:" + NewFile.LastWriteTime);
            Console.WriteLine("Bulunduğu dizinin adı:" + NewFile.DirectoryName);
            Console.WriteLine("Dosyanın adı:" + NewFile.Name);
            Console.WriteLine("Dosyanın tam adı:" + NewFile.FullName);
            Console.WriteLine("Dosyanın uzantısı" + NewFile.Extension);
            //Dosya kopyalama
            NewFile.CopyTo(@"C:\Test\nt.txt");
            Console.ReadKey();


        }
    }
}
