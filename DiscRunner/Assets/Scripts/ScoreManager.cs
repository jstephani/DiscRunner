using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] public float timeRate = 0.1f;
    [SerializeField] public float multTimeRate = 10f;
    private float multiplicator = 1f;
    private float timer = 0f;
    private float multTimer = 0f;
    public static ScoreManager instance;
    public TextMeshProUGUI text;
    int score;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    void Update()
    {
        if(timer < timeRate)
        {
            timer += Time.deltaTime;
        }else
        {
            score += 1;
            text.text = "Score:" + score.ToString();
            timer = 0f;
        }


        if(multTimer < multTimeRate)
        {
            multTimer += Time.deltaTime;
        }else
        {
            multiplicator += 0.1f;
            multTimer = 0f;
        }
    }

    // Update is called once per frame
    public void ChangeScore(int coinValue)
    {
        score += (int)(coinValue * multiplicator);
        text.text = "Score:" + score.ToString();
    }
    public int getScore()
    {
        return score;
    }
}
