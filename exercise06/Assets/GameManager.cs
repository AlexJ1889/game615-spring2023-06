using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{

    int playerScore = 0;
    int enemyScore = 0;
    public TMP_Text playerText;
    public TMP_Text enemyText;
    public TMP_Text timerText;

    public float currentTime;
    public bool countDown;

    public bool hasLimit;
    public float timerLimit;
    public bool timeOver; 

    // Start is called before the first frame update
    void Start()
    {

        enemyText.text = "enemy Score: " + enemyScore.ToString();
        timeOver = false; 
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeOver)
        {
            currentTime = countDown ? currentTime - Time.deltaTime : currentTime + Time.deltaTime;
        }

        if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
        {
            currentTime = timerLimit;
            SetTimerText();
            timerText.color = Color.red;
            enabled = false; 
        }
    }

    public void IncrementPlayerScore()
    {
        playerScore += 1;
        playerText.text = playerScore.ToString();
    }

    public void IncrementEnemyScore()
    {
        enemyScore++; 
        enemyText.text = enemyScore.ToString("enemy Score: " + "0");
    }

    private void SetTimerText()
    {
        if(currentTime > 0)
        {
            timerText.text = currentTime.ToString("Time Remaining: " + "0");
        }
    }
}
