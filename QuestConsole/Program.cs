using System;
using Questions.QuestLib;
// See https://aka.ms/new-console-template for more information

namespace Questions.QuesrConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
 //           Theme theme = new Theme();

            var quest1 = new Quest("Кто написал произведение горе от ума?","Грибоедов","people");
            var quest2 = new Quest("Кто открыл атмосферное давление?","Паскаль","people");
            var quest3 = new Quest("Кто гавкает?","Собака","animal");
            var quest4 = new Quest("Кто мяукает?","Котенок","animal");
            quest1.ask();
            quest2.ask();
            quest3.ask();
            quest4.ask();
        }
    }
}
//TODO Сделать массив классов
//TODO распределить по темам
//TODO добавить проверки на все возможные ошибки
//TODO добавить темы и автозанесение ответов выполненных вопрос в общий массив вопросов
//TODO добавить пользовательский интерфейс
//Test git ignore