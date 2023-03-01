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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncrementPlayerScore()
    {
        playerScore += 1;
        playerText.text = playerScore.ToString();
    }

    public void IncrementEnemyScore()
    {
        enemyScore += 1;
        enemyText.text = enemyScore.ToString();
    }
}
