using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text recentScoreText;
    public Text highScoreText;
    public Text coinCountText;

    public int recentScore;
    public int highScore;
    public int coins;
    public static Score score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        recentScore = PlayerPrefs.GetInt("RecentScore");
        recentScoreText.text = recentScore.ToString();

        highScore = PlayerPrefs.GetInt("HighScore");
        highScoreText.text = highScore.ToString();

        coins = PlayerPrefs.GetInt("CoinCount");
        coinCountText.text = coins.ToString();


        if (Input.GetKeyDown(KeyCode.A))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
