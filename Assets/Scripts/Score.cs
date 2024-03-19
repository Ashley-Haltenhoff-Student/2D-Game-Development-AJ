using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public float timer = 0f;
    public float timerRate = 1f;

    public Text scoreDisplay;

    void Start()
    {
        
    }

    void Update()
    {
        timer += Time.deltaTime * timerRate;

        if (timer > 1f)
        {
            score++;
            scoreDisplay.text = "Score : " + score.ToString();
            timer = 0f;
        }
    }
}