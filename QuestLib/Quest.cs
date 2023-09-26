using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;

namespace Questions.QuestLib;
public class Quest
{
    private string _quest = "none";
    private string _answer = "none";
    public string GetQuest()
    {
        return _quest;
    }
    public virtual bool CheckAnswer(string? userAnswer)
    {
        return userAnswer == _answer;
    }
    public Quest(string userQuest, string userAnswer)
    {
        _quest = userQuest;
        _answer = userAnswer;
    }
}