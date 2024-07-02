
// using YG;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int ScoreCount;
    public int HightScore;
    
    public TMP_Text currencyScore;

    private const string YandexLeaderBoardName = "Score";
    
    public void TrySaveScrore()
    {
        if(ScoreCount <= HightScore)
        return;

        HightScore = ScoreCount;
        // YandexGame.NewLeaderboardScores(YandexLeaderBoardName, HightScore);
    }

    public void Start()
    {
        currencyScore.text = ScoreCount.ToString();
    }

    public void SetScore()
    {
        ScoreCount++;
        currencyScore.text = ScoreCount.ToString();
    }
}
