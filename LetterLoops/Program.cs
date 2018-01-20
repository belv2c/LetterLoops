using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Write a console application that takes a string from the console input and outputs it as shown below:

// Input       Output
// abcd        A-Bb-Ccc-Dddd
// RqaEzty     R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy
// cwAt        C-Ww-Aaa-Tttt
namespace LetterLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type some letters");
            string letterInput = Console.ReadLine();
            string finalOutput = "";

            for (int i=0; i < letterInput.Length; i++)
            {
                var letters = letterInput[i];
                var chars = letterInput[i].ToString();
                string upperCase = chars.ToUpper();
                string lowerCase = chars.ToLower();
                if (i == 0)
                {
                    finalOutput += $"{upperCase}-";
                }
                else if (i == letterInput.Length-1)
                {
                    string echo = new String(letters, i);
                    finalOutput += $"{upperCase}{echo}";
                }
                else
                {
                    string echo = new String(letters, i);
                    finalOutput += $"{upperCase}{echo}-";
                }

                Console.WriteLine(finalOutput);
                Console.ReadLine();
            }
        }
    }
}
