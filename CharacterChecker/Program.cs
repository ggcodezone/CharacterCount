using System;

namespace CharacterChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int alphabet, digit, symbol;
            string str;
            int i = 0;
            alphabet = 0;
            digit = 0;
            symbol = 0;
            Console.WriteLine("Enter your data:"); //user input of data to analyze 
            str = Console.ReadLine();

            //Check alphabetical characters
            while (i < str.Length)
            {
                if ((str[i] >= 'A' && str[i] <= 'Z') || (str[i] >= 'a' && str[i] <= 'z')) //checks for both lowercase and uppercase
                {
                    alphabet++;
                }
                //Check numerical characters
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                //check symbol characters
                else
                {
                    symbol++;
                }
                i++;
            }
            Console.WriteLine("Number of Alphabetical characters={0}", alphabet);
            Console.WriteLine("Number of numerical characters={0}", digit);
            Console.WriteLine("Number of symbol characters={0}", symbol);
        }
    }
}
