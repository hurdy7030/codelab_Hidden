using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public InputHandler InputHandler;
    public TMP_Text scoreText;
    public AudioSource audioSource;
    public GameObject GameOver;
    
    int score;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText.text = score.ToString("0");
        GameOver.SetActive(false);
    }

    public void AddScore()
    {
        score++;
        scoreText.text = score.ToString();
        audioSource.Play();
        
        if (score == 12)
        {
            GameOver.SetActive(true);
            InputHandler.gameObject.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
