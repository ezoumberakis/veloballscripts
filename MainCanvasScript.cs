using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainCanvasScript : MonoBehaviour
{


    public GameObject NormalUI;
    public GameObject PauseUI;

    public Text coinsText;
    public Text scoreText;

    public Text GOcoinsText;
    public Text GOscoreText;

    public Score Score;
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1F;
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("VeloBall");
        Time.timeScale = 1F;
    }

    public void Resume()
    {
        Time.timeScale = 1F;
        PauseUI.SetActive(false);
        NormalUI.SetActive(true);
    }

    public void Pause()
    {
        Time.timeScale = 0F;
        PauseUI.SetActive(true);
        NormalUI.SetActive(false);
    }

    void Update()
    {
        GOcoinsText.text = "" + PlayerPrefs.GetInt("CoinCount");
        GOscoreText.text = "" + PlayerPrefs.GetInt("RecentScore");
        coinsText.text = "" + PlayerPrefs.GetInt("CoinCount");
        scoreText.text = "" + (int)Score.scoreAmount;
    }
}
