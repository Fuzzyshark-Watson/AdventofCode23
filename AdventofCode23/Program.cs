using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventofCode23
{
    class Program
    {
        static void Main()
        {
            // Specify the path to your text document
            string firstFilePath = "C:\\Users\\Watso\\source\\repos\\AdventofCode23\\AdventofCode23\\AdventDataset\\FirstAdventDataset.txt";

            // Call the method from the FirstAdvent class
            
            FirstAdvent.ProcessTextDocument(firstFilePath);
            Console.WriteLine("Advent 1 Part 1");

            FirstAdvent.ProcessTextDocumentPartTwo(firstFilePath);
            Console.WriteLine("Advent 1 Part 2");

            Console.ReadLine();
        }
    }
}
