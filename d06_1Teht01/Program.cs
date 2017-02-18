using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_1Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lauseet = new List<string>();
            StreamWriter file = new StreamWriter(@"C:\Users\Eetu\Desktop\test.txt");
            ConsoleKeyInfo keyInfo;

            for (int i = 0; i < lauseet.Count + 1; i++)
            {
                Console.Write("Give a text line (Escape ends): ");
                lauseet.Add(Console.ReadLine());
                keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape) //(lauseet[i] == "x")
                {
                    break;
                }
                file.WriteLine(lauseet);
                
            }
            file.Close();

            Console.WriteLine("Contents of test.txt");

            foreach (string lause in lauseet)
            {
                Console.WriteLine(lause);
            }
        }
    }
}
