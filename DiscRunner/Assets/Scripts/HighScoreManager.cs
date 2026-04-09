using UnityEngine;
using TMPro;

public class HighScoreManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static HighScoreManager instance;
    public TextMeshProUGUI text;
    int highScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if(instance == null)
        {
            instance = this;
        }
        highScore = PlayerPrefs.GetInt("SavedHighScore", 0);
        text.text = "Highscore: " + highScore.ToString();
    }

    // Update is called once per frame
    public void ChangeHighScore(int score)
    {
        if(highScore < score){
            highScore = score;
            text.text = "Highscore:" + highScore.ToString();
        }
        PlayerPrefs.SetInt("SavedHighScore", highScore);
        PlayerPrefs.Save();

    }

}
