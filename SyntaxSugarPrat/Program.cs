using System;

namespace SyntaxSugarPrat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var answer = 9;                // if true                     if false
            var reponse = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than or equal to 9 ";
            Console.WriteLine(reponse);

        }
    }
}
