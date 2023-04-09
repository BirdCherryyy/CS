namespace Questions.QuestLib;
public class Quest
{
    public string quest;
    public string trueAnswer;
    public string theme;

    public Quest(string _quest, string _trueAnswer, string _theme){
        quest = _quest;
        trueAnswer = _trueAnswer;
        theme = _theme;
    }
    public void ask(Theme _theme){

        string[] arr = new string[4];//массив ответов с 1 правильным
        string[] answer;//копия с массива неверных ответов
        Random rnd = new Random();
        int value;
        string tmp;
        if (theme == "people")
        {
            answer = _theme.people;
        }
        else
        {
            answer = _theme.animal;
        }

        arr[0] = trueAnswer;
        //Console.Clear();
        for (int i = 1; i < 4; i++){
            value = rnd.Next(0, answer.Length-1);
            arr[i] = answer[value];
            answer = answer.Where(e => e != answer[value]).ToArray(); // удаление элемента массива
        }

        for (int I = 0; I < 10; I++){//мешаем
            for (int i = 0; i < 4 ; i++){
                value = rnd.Next(0, arr.Length-1);
                tmp = arr[value];
                arr[value] = arr[i];
                arr[i] = tmp; 
            }
        }

        System.Console.WriteLine(quest);
        for (int i = 0; i < 4; i++){
            Console.WriteLine($"{i+1}) {arr[i]}");
        }
        Console.Write("Введите вариант ответа: ");
        string val = Console.ReadLine();
        value = Convert.ToInt32(val);
        if (arr[value-1] == trueAnswer){
            System.Console.WriteLine("Правильно!");
        }
        else{
            System.Console.WriteLine("Неправильно");
        }
        Console.ReadLine();
    }
}

public class Theme
{
    public string[] thems = {"animal", "people"};
    public string[] animal = {"Корова", "Жираф", "Тигр", "Тюлень", "Курица", "Пантера"};
    public string[] people = {"Пушкин", "Тесла", "Ньютон", "Сталин"};

    public void addAnswer(string answer, string theme){
        if (theme == thems[0])
            {
                animal.Append(answer);
            }
        if (theme == thems[1])
            {
                people.Append(answer);
            }  
    }
}
////Test git ignore
