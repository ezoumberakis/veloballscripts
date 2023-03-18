using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrailShopItem : MonoBehaviour
{

    [SerializeField] private TrailManager trailManager;

    [SerializeField] private int trailIndex;

    [SerializeField] private Button buyButton;

    [SerializeField] Text costText;

    [SerializeField] private GameObject GCI;

    private Trail trail;

    // Start is called before the first frame update
    void Start()
    {
        trail = trailManager.trails[trailIndex];

        GCI = trail.gameObjectF;

        if (trailManager.IsUnlocked(trailIndex))
        {
            buyButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            costText.text = trail.cost.ToString();
        }
    }

    public void OnTrailPressed()
    {
        if (trailManager.IsUnlocked(trailIndex))
        {
            trailManager.SelectTrail(trailIndex);
            
        }
    }

    public void OnBuyButtonPressed()
    {
        int coins = PlayerPrefs.GetInt("CoinCount", 0);

        if(coins >= trail.cost && !trailManager.IsUnlocked(trailIndex))
        {
            PlayerPrefs.SetInt("CoinCount", coins - trail.cost);
            trailManager.Unlock(trailIndex);
            buyButton.gameObject.SetActive(false);
            trailManager.SelectTrail(trailIndex);
        }
        else
        {
            Debug.Log("Not Enough Coins :(");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
