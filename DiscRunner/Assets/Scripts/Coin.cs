using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    AudioManager audioManager;

    public void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
            audioManager.PlaySFX(audioManager.coin);
        }
    }
}
