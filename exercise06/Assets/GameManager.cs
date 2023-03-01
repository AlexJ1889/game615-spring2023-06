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

    //public float TimeLeft;
    //public bool TimerOn = false;
    //public TMP_Text ScoreText;
    //public TMP_Text Timer;
    //public int playerscore = 0;
    //float moveSpeed = 60f;
    //float rotateSpeed = 75f;

    // Start is called before the first frame update
    void Start()
    {

        enemyText.text = "enemy Score: " + enemyScore.ToString();
        timeOver = false;
        //    playerscore = 0;
        //    TimerOn = true;
        //    TimeLeft = 50;
        //    ScoreText.text = "0";
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

            //if (TimerOn)
            //{
            //    if (TimeLeft > 0 && playerscore < 3)
            //    {
            //        TimeLeft -= Time.deltaTime;
            //        Timer.text = TimeLeft.ToString();
            //    }
            //    else if (TimeLeft > 0 && playerscore == 3)
            //    {
            //        ScoreText.text = " Winner!";
            //    }
            //    else
            //    {
            //        TimeLeft = 0;
            //        Timer.text = TimeLeft.ToString();
            //        TimerOn = false;
            //        ScoreText.text = "You lose! ";

            //    }

            //}
        }

    public void IncrementPlayerScore()
    {
        enemyScore = 0;
        playerScore += 1;
        playerText.text = playerScore.ToString();
    }

    public void IncrementEnemyScore()
    {
        enemyScore = 0;
        enemyScore += 1;
        enemyText.text = enemyScore.ToString();
    }


        private void SetTimerText()
        {
            if (currentTime > 0)
            {
                timerText.text = currentTime.ToString();
            }
        }
    }
