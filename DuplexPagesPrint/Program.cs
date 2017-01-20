using System;
using System.Diagnostics;
using System.IO;

namespace DuplexPagesPrint
{
    class Program
    {
        static string file = @"OddEven.txt";
        static int numberPages;

        static void Main(string[] args)
        {
            ReadNumberPages();
            PrintingPages pp = new PrintingPages(numberPages);

            using (var strm = new StreamWriter(file))
            {
                strm.WriteLine(pp.OddPages);
                strm.WriteLine(string.Empty);
                strm.WriteLine(pp.EvenPages);
            }

            OpenInExplorer();
        }

        private static void ReadNumberPages()
        {
            Console.Write("Enter the number of pages: ");
            try
            {
                numberPages = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Invalid input");
                ReadNumberPages();
            }
        }

        private static void OpenInExplorer()
        {
            new Process()
            {
                StartInfo = new ProcessStartInfo()
                {
                    FileName = "notepad.exe",
                    Arguments = file,
                }
            }
            .Start();
        }
    }
}
