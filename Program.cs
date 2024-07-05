using System;
﻿using NumbersOrLetters.Services;

internal class Program
{
    public static void Main(string[] args)
    {

        bool isTrue = true;
        do
        {
            try
            {
                NumberOrLetter numbersOrLetters = new NumberOrLetter();

                Console.WriteLine("This program is count numbers and letters in string");
                Console.Write("Input the text:");
                string phrase = Console.ReadLine();
                // char[] inputChar = phrase.ToCharArray();
        
                numbersOrLetters.InputCounter(phrase);


                Console.WriteLine("Do you want to continue? (yes / no)");
                string checkWhile = Console.ReadLine().ToLower();
                isTrue = checkWhile is "yes" or "y";
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        } while (isTrue);
    }
}