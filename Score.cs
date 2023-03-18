using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Movement movementscript;
    public Text scoreText;
    public Text timeText;

    public float scoreAmount;
    public int finalscoreAmount;
    public float pointIncreasedPerSecond;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = (int)scoreAmount + "";
        scoreAmount +=pointIncreasedPerSecond * Time.deltaTime;
        timeText.text = (int)scoreAmount + "";


        if(Time.timeScale == 0F)
        {
            finalscoreAmount = (int)scoreAmount;
        }

        if(scoreAmount >= 5000)
        {
            pointIncreasedPerSecond = 200;
        }

        if (scoreAmount >= 10000)
        {
            pointIncreasedPerSecond = 400;
            movementscript.speed = 5;
        }

        if (scoreAmount >= 20000)
        {
            pointIncreasedPerSecond = 500;
        }
        if (scoreAmount >= 50000)
        {
            pointIncreasedPerSecond = 1000;
        }
        if (scoreAmount >= 100000)
        {
            pointIncreasedPerSecond = 2500;
        }
    }
}
