namespace Questions.QuestLib;
using System;

public class QizQuest: Quest
{
    //private string[] _arrAnswers = new string[]{};
    private List<string> _listAnswers = new List<string>() {};
        public QizQuest(string userQuest, string userAnswer, string[] userArrAnswers) : base(userQuest, userAnswer)
        {
            for (int i = 0; i < userArrAnswers.Length; i++)//добавляем в список все ответы
            {
                _listAnswers.Add(userArrAnswers[i]);
            }
            _listAnswers.Add(userAnswer);
            RandomList();//перемешиваем ответы
        }
        public override bool CheckAnswer(string? userAnswer)
        {
            if (userAnswer == null || userAnswer.Length == 0)
            {
                userAnswer = "10";
            }
            return base.CheckAnswer(_listAnswers[int.Parse(userAnswer)-1]);
        }
        private void RandomList()
        {
            Random rnd = new Random();
            for (int i = 0; i < _listAnswers.Count; i++)
            {
                int j = rnd.Next(_listAnswers.Count);
                string temp = _listAnswers[i]; 
                _listAnswers[i] = _listAnswers[j];
                _listAnswers[j] = temp;
            }
        }
        public string[] GetVariantOfAnswers()
        {
            return _listAnswers.ToArray();
        }
}