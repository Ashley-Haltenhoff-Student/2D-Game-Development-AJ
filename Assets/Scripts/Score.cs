using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public int score = 0;
    public int highScore = 0;
    public float timer = 0f;
    public float timerRate = 1f;

    public int scoreForLevelUp = 60;
    public int level = 1;

    public Text scoreDisplay;
    public Text levelDisplay;

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

        if (score >= scoreForLevelUp)
        {
            level++;
            levelDisplay.text = "Level " + level;
            scoreForLevelUp += scoreForLevelUp;
        }
        
    }
}