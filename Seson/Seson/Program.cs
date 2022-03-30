using System;

namespace Seson
{
    class Program
    {
        enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter,
            Unknown  
        }

        static void Main(string[] args)
        {
            int userInput = ReadUserInput();
            Season season = getSeason(userInput);
            string outputName = GetSeasonName(season);
            Console.WriteLine(outputName);
        }

        private static Season getSeason(int month)
        {
            switch(month)
            {
                case (1):
                case (2):
                case (12):
                    return Season.Winter;
                case (3):
                case (4):
                case (5):
                    return Season.Spring;
                case (6):
                case (7):
                case (8):
                    return Season.Summer;
                case (9):
                case (10):
                case (11):
                    return Season.Autumn;
                default:
                    return Season.Unknown;
            }

        }

        private static int ReadUserInput()
        {
            Console.WriteLine("Введите номер месяца");
            string userInput = Console.ReadLine();
            return int.Parse(userInput);
        }

        static string GetSeasonName(Season season)
        {
            switch (season)
            {
                case (Season.Autumn):
                    return "Весна";
                case (Season.Winter):
                    return "Зима";
                case (Season.Spring):
                    return "Весна";
                case (Season.Summer):
                    return "Лето";
                default:
                    return "Такого месяца не существует";
            }
        }
    }
}
