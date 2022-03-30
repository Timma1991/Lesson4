using System;
using System.Collections.Generic;
using System.Linq;

namespace Metod2
{//Написать программу,
 //принимающую на вход строку —
 //набор чисел, разделенных пробелом,
 //и возвращающую число — сумму всех чисел
 //в строке. Ввести данные с клавиатуры и
 //вывести результат на экран.

    class Program
    {
        public static void Main(string[] args)
        {
            string input = RecieveData();
            int result = Calculate(input);
            Console.WriteLine($"result is: {result}");
        }

        private static string RecieveData()
        {
            Console.WriteLine("Введите строку: ");
            return Console.ReadLine();
        }

        
        private static int Calculate(string someText) // 15 34 53 1
        {
            string currentNumber = ""; //
            int result = 0; //102

            for(int i = 0; i < someText.Length; i++)
            {
                if (char.IsDigit(someText[i]))
                {
                    currentNumber += someText[i];
                }

                if(someText[i] == ' ' || i == someText.Length - 1)
                {
                    result = result + int.Parse(currentNumber); // result = 49 + int.Parse("53") = result = 49 + 53 => result = 102
                    currentNumber = "";
                }
            }
            return result;
        }
    }
}




