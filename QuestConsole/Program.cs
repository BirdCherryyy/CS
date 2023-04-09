using System;
using Questions.QuestLib;
// See https://aka.ms/new-console-template for more information

namespace Questions.QuesrConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Theme theme = new Theme();

            Quest quest1 = new Quest("Кто написал произведение горе от ума?","Грибоедов","people");
            Quest quest2 = new Quest("Кто открыл атмосферное давление?","Паскаль","people");
            Quest quest3 = new Quest("Кто гавкает?","Собака","animal");
            Quest quest4 = new Quest("Кто мяукает?","Котенок","animal");
            quest1.ask(theme);
            quest2.ask(theme);
            quest3.ask(theme);
            quest4.ask(theme);
        }
    }
}
//TODO Сделать массив классов
//TODO распределить по темам
//TODO добавить проверки на все возможные ошибки
//TODO добавить темы и автозанесение ответов выполненных вопрос в общий массив вопросов
//TODO добавить пользовательский интерфейс