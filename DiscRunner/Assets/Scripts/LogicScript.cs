using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    AudioManager audioManager;

    public void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void exitGame(){
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
        Application.Quit();
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
        int score =  ScoreManager.instance.getScore();
        HighScoreManager.instance.ChangeHighScore(score);
        audioManager.StopMusic();
        audioManager.PlaySFX(audioManager.death);


    }
}

