using System;
using Questions.QuestLib;
// See https://aka.ms/new-console-template for more information

namespace Questions.QuesrConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var Quest1 = new Quest("Кто мяукает?", "Кот");
            string[] arrStr = {"Собака", "Корова", "Пингвин", "Кот"};
            Console.Write($"Вопрос: {Quest1.GetQuest()} \nВведите ответ: ");
            string? userAnswer = Console.ReadLine();
            if (Quest1.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                Console.WriteLine("Неверно!");
            }

            
/*
            for (int i = 0; i < arrStr.Length; i++)
            {
                Console.WriteLine($"{i+1}) {arrStr[i]}");
            }
            Console.Write("Введите вариант ответа:  от 1 до 4\n");

            string? val = Console.ReadLine();
            if(Convert.ToInt32(val) >= 1 & Convert.ToInt32(val) <= 4)
            {
                if (Quest1.CheckAnswer(arrStr[Convert.ToInt32(val)-1]))
                {
                    Console.Write("Правильно");
                }
                else
                {
                    Console.Write("Неправильно");
                }

            }
            else Console.Write("Ввели неправильное число");
                */
                Console.ReadLine();
        }
    }
}