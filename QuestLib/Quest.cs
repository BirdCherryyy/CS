using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Questions.QuestLib;
public class Quest
{
    private string _quest;
    private string _answer;
    public string GetQuest()
    {
        return _quest;
    }
    public virtual bool CheckAnswer(string? userAnswer)
    {
        return userAnswer == _answer;
    }
    public Quest(string initQuest, string initAnswer)
    {
        _quest = initQuest;
        _answer = initAnswer;
    }
}