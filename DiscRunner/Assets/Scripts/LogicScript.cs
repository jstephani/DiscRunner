using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }
}

