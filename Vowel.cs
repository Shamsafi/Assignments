using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Programs
{
    public class Vowel
    {
        static void Main(string[] args)
        {
            char alphabet;

            Console.Write("Enter an alphabet: ");
            alphabet = char.Parse(Console.ReadLine());

            switch (alphabet)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("{0} is a vowel.", alphabet);
                    break;
                default:
                    Console.WriteLine("{0} is a consonant.", alphabet);
                    break;
            }
        }
    }
}
