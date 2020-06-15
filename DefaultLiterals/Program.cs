using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefaultLiterals
{
    class Program
    {
        static void Main(string[] args)
        {
            //old way  of writing default literals
            Console.WriteLine(DefaultLiteralSample.OldStyle());
            Console.WriteLine(DefaultLiteralSample.OldMethodWithArgs());
            Console.WriteLine(DefaultLiteralSample.NewStyle());
            Console.WriteLine(DefaultLiteralSample.NewMethodWithArgs());
            Console.WriteLine(DefaultLiteralSample.NewMethodWithArgs());
            Console.ReadLine();


        }
    }
}
