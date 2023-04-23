namespace Questions.QuestLib;
public class Quest
{
    static string[] Thems = {"animal", "people"};
    static string[] Animal = {"Корова", "Жираф", "Тигр", "Тюлень", "Курица", "Пантера"};
    static string[] People = {"Пушкин", "Тесла", "Ньютон", "Сталин"};
    public string QuestText {get;set;}
    private int _numTheme = -1;
    public string NameTheme 
    {   
        get
        {
            return Thems[_numTheme];
        }
        set
        {
            for (int i = 0; i < Thems.Length; i++)
            {
                if (Thems[i] == value)
                {
                    _numTheme = i;
                }
            }
        }
    }
    private string _trueAnswer;
    public string TrueAnswer 
    {
        get
        {
            return _trueAnswer;
        }
        set
        {
            _trueAnswer = value;
            if (NameTheme == "people")
            {
                People.Append(value);
            }
            else if (NameTheme == "animal")
            {
                Animal.Append(value);
            }
        }
    }


    public Quest(string MyQuestText, string MyTrueAnswer, string MyNameTheme){
        QuestText = MyQuestText;
        NameTheme = MyNameTheme;
        TrueAnswer = MyTrueAnswer;
    }
    public void ask(){

        string[] Arr = new string[4];//массив ответов с 1 правильным
        string[] Answer;//копия с массива неверных ответов
        var rnd = new Random();
        var Value = new int();
        string tmp;

        CheckTheme();
        Arr[0] = TrueAnswer;
        AddInArr();
        MixArr();
        WriteAskConsole();
        GiveAnswer();
//Модули функций
/*----------------------------------------------------------------------------------------------------------------------------------------------*/
        void CheckTheme()
        {
            if (NameTheme == "people")
            {
                Answer = People;
            }
            else 
            {
                Answer = Animal;
            }
        }
        void AddInArr()
        {
            for (int i = 1; i < 4; i++)
            {
                Value = rnd.Next(0, Answer.Length-1);
                Arr[i] = Answer[Value];
                Answer = Answer.Where(e => e != Answer[Value]).ToArray(); // удаление элемента массива
            }
        }
        void MixArr()
        {
            for (int I = 0; I < 10; I++){//мешаем
                for (int i = 0; i < 4 ; i++){
                    Value = rnd.Next(0, Arr.Length-1);
                    tmp = Arr[Value];
                    Arr[Value] = Arr[i];
                    Arr[i] = tmp; 
                }
            }
        }
        void WriteAskConsole()
        {
            System.Console.WriteLine(QuestText);
            for (int i = 0; i < 4; i++){
                Console.WriteLine($"{i+1}) {Arr[i]}");
            }
            Console.Write("Введите вариант ответа: ");
        }
        void GiveAnswer()
        {
            string val = Console.ReadLine();
            Value = Convert.ToInt32(val);
            if (Arr[Value-1] == TrueAnswer){
                System.Console.WriteLine("Правильно!");
            }
            else{
                System.Console.WriteLine("Неправильно");
            }
            Console.ReadLine();
        }
    }


}

////Test git ignore
