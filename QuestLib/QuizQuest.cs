namespace Questions.QuestLib;

public class QuestQiz: Quest
{
    private string[] _arrAnswers;
        public QuestQiz(string userQuest, string userAnswer, string[] userArrAnswers) : base(userQuest, userAnswer)
        {
            _arrAnswers = userArrAnswers;
        }
}