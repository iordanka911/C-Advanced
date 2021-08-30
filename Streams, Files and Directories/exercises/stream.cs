using System;
using System.IO;
using System.Threading.Channels;

namespace ConsoleApp122
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("../../../input.txt");
            
            string line = reader.ReadLine();
            Console.WriteLine(line);

            reader.Close();
         
            StreamWriter writer = new StreamWriter("../../../input.txt", true);
           
            writer.WriteLine("Filesa are cool");
            writer.Close();
        }
    }
}
