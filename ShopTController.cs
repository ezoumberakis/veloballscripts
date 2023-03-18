using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShopTController : MonoBehaviour
{
    [SerializeField] private GameObject selectedTrail;
    [SerializeField] private Text coinsText;
    [SerializeField] private TrailManager trailManager;

    void Update()
    {
        coinsText.text = "Coins: " + PlayerPrefs.GetInt("Coins");
        selectedTrail = trailManager.GetSelectedTrail().gameObjectF;
    }

    public void LoadMenu() => SceneManager.LoadScene("Menu");
}
