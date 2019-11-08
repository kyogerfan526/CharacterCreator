using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App1.FileIO
{
    class FileIO
    {
        static void main(string[] args)
        {

            if (File.Exists("Test.txt"))
            {
                string content = File.ReadAllText("test.txt");
                Console.WriteLine("Current content of file:");
                Console.WriteLine(content);
            }
            else
            {
                string newContent = Console.ReadLine();
                File.WriteAllText("test.txt", newContent);
            }
            //this is a change

        }

    }
}
