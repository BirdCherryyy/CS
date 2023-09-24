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
    public bool CheckAnswer(string answer)
    {
        if (answer == _answer) return true;
        else return false;
    }
    public Quest(string quest, string answer)
    {
        _quest = quest;
        _answer = answer;
    }
}