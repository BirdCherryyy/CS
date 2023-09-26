﻿using System;
using Questions.QuestLib;
// See https://aka.ms/new-console-template for more information

namespace Questions.QuesrConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var Quest1 = new Quest("Кто мяукает?", "Кот");
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
           Console.ReadLine();

            string[] wrongAnswers = {"Кот", "Корова", "Утка"};
            string[] variantAnswers;
            var Quest2 = new QizQuest("Кто лает?", "Собака", wrongAnswers);
            variantAnswers = Quest2.GetVariantOfAnswers();

            Console.Write($"Вопрос: {Quest2.GetQuest()} \n Варианты ответов:\n");
            for (int i = 0; i < variantAnswers.Length; i++)
            {
                Console.Write($"{i+1}) {variantAnswers[i]}\n");
            }
            Console.WriteLine("Введите номер правильного ответа: ");

            userAnswer = Console.ReadLine();

            if (Quest2.CheckAnswer(userAnswer))
            {
                Console.WriteLine("Верно!");
            }
            else
            {
                Console.WriteLine("Неверно!");
            }

            Console.ReadLine();
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

        }
    }
}