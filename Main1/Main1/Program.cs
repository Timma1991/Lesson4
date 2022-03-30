using System;

namespace Main1
{
    class Program
    {
        //Написать метод GetFullName(string firstName, string lastName, string patronymic),
        //принимающий на вход ФИО в разных аргументах и возвращающий
        //объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.

        static void Main(string[] args)
        {
            

            Console.WriteLine(GetFullName("Тимофей","Лебедев","Викторович"));
            Console.WriteLine(GetFullName("Тимофей", "Лебедев", "Викторович"));
            Console.WriteLine(GetFullName("Тим", "Ле", "Ви"));

        }

        static string GetFullName(string firstName, string lastName, string patronymic)
        {
            return $"{lastName} {firstName} {patronymic}";
        }


      
       
    }
}
