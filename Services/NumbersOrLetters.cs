using System;

namespace NumbersOrLetters.Services
{
    internal class NumberOrLetter
    {

        private int countNumber = 0;
        private int countLetter = 0;
        internal void InputCounter(string input)
        {
            if (input == null)
            {
                Console.WriteLine("Input is NULL");
            }
            else
            {
                foreach (var item in input)
                {
                    if (Char.IsDigit(item))
                    {
                        countNumber++;
                    }
                    else
                    {
                        countLetter++;
                    }

                }
                Console.WriteLine($"There are {countNumber} numbers and {countLetter} letters in the input.");

            }

        }

    }
}