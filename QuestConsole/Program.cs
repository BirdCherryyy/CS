using System;
using Questions.QuestLib;

namespace Questions.QuesrConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var Quest1 = new Quest("Кто мяукает?", "Кот");
            Console.Write($"Вопрос: {Quest1.GetQuest()} \nВведите ответ: ");
            //OutQuest(Quest1);
            OutResult(Quest1);

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
            
            //OutQuest(Quest2);
            OutResult(Quest2);

            static void OutResult(Quest Q)
            {
                string? userAnswer = Console.ReadLine();
                if (Q.CheckAnswer(userAnswer))
                {
                    Console.WriteLine("Верно!");
                }
                else
                {
                    Console.WriteLine("Неверно!");
                }
                Console.ReadLine();
                return;
            }
/*
            static void OutQuest(Quest Q)
            {
                if (!typeof(Quest).IsSubclassOf(typeof(Quest)))
                {
                    Console.Write($"Вопрос: {Q.GetQuest()} \nВведите ответ: ");
                    return;
                }
                string[] wrongAnswers = {"Кот", "Корова", "Утка"};
                string[] variantAnswers;
                variantAnswers = Q.GetVariantOfAnswers();
                Console.Write($"Вопрос: {Q.GetQuest()} \n Варианты ответов:\n");
                for (int i = 0; i < variantAnswers.Length; i++)
                {
                    Console.Write($"{i+1}) {variantAnswers[i]}\n");
                }
                Console.WriteLine("Введите номер правильного ответа: ");
                return;

            } 
            */
        }
    }

}