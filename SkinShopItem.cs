﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinShopItem : MonoBehaviour
{

    [SerializeField] private SkinManager skinManager;

    [SerializeField] private int skinIndex;

    [SerializeField] private Button buyButton;

    [SerializeField] Text costText;

    private Skin skin;

    // Start is called before the first frame update
    void Start()
    {
        skin = skinManager.skins[skinIndex];

        GetComponent<Image>().sprite = skin.sprite;

        if (skinManager.IsUnlocked(skinIndex))
        {
            buyButton.gameObject.SetActive(false);
        }
        else
        {
            buyButton.gameObject.SetActive(true);
            costText.text = skin.cost.ToString();
        }
    }

    public void OnSkinPressed()
    {
        if (skinManager.IsUnlocked(skinIndex))
        {
            skinManager.SelectSkin(skinIndex);
        }
    }

    public void OnBuyButtonPressed()
    {
        int coins = PlayerPrefs.GetInt("CoinCount", 0);

        if(coins >= skin.cost && !skinManager.IsUnlocked(skinIndex))
        {
            PlayerPrefs.SetInt("CoinCount", coins - skin.cost);
            skinManager.Unlock(skinIndex);
            buyButton.gameObject.SetActive(false);
            skinManager.SelectSkin(skinIndex);
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
