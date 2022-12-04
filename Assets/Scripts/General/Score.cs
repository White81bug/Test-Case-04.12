using UnityEngine;

public class Score : MonoBehaviour
{
    public int PlayersScore
    {
        get => PlayerPrefs.GetInt(ScoreKey, 0);
         private set
        {
            PlayerPrefs.SetInt(ScoreKey, value);
            PlayerPrefs.Save();
        }
    }
    private const string ScoreKey = "Score";

    public void ResetScore()
    {
        PlayersScore = 0;
    }

    public void AddScore(int amount)
    {
        PlayersScore += amount;
    }
    
}
