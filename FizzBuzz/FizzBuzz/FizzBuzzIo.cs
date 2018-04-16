using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class FizzBuzzIo
    {
        public int EnterANumber()
        {
            int userInput;
            do
            {
                Console.Clear();
                Console.Write("Hello there, please enter a number: ");
            } while (!int.TryParse(Console.ReadLine(), out userInput));

            return userInput;
        }

        public List<string> WriteFizzBuzzUpTo(int NumberUpTo, FizzBuzzFunctions functions)
        {
            List<string> numToPrint = new List<string>();

            for (int i = 1; i <= NumberUpTo; i++)
            {
                numToPrint.Add(functions.IsNumberFizzBuzz(i));
            }
            return numToPrint;
        }

        public void WriteFizzBuzz(string userInput)
        {
            Console.WriteLine(userInput);
        }
        public bool PlayAgain()
        {           
            Console.WriteLine("Do you want to play again? Y/N");

            ConsoleKeyInfo keyPressed;
            do
            {
                keyPressed = Console.ReadKey(true);

            } while (keyPressed.Key != ConsoleKey.Y && keyPressed.Key != ConsoleKey.N);

            return keyPressed.Key == ConsoleKey.Y;
        }
    }
}
