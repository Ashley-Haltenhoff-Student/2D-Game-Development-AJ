using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public int score = 0;
    public int highScore = 0;
    public float timer = 0f;
    public float timerRate = 1f;

    public Text scoreDisplay;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
        PlayerPrefs.Save();
    }

    void Update()
    {
        timer += Time.deltaTime * timerRate;

        if (timer > 1f)
        {
            score++;
            scoreDisplay.text = "Score : " + score.ToString();
            timer = 0f;

            if (score > highScore) highScore = score;
        }
        
    }
}