﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class AdsManagerCoinAD : MonoBehaviour, IUnityAdsListener
{
#if UNITY_IOS
    string gameId = "5137587";
#else 
    string gameId = "5137586";
#endif

    public int coinCountA;
    public GameObject thisg;
    // Start is called before the first frame update
    void Start()
    {
        Advertisement.Initialize(gameId);
        Advertisement.AddListener(this);
    }

    public void PlayRewardedAd(){
        if (Advertisement.IsReady("Rewarded_iOS")){
            Advertisement.Show("Rewarded_iOS");
        }else{
            Debug.Log("Rewarded ad is not ready!");
        }
    }
    
    public void OnUnityAdsReady(string placementId){
        Debug.Log("ADS ARE READY");
    }
    public void OnUnityAdsDidError(string message){
        Debug.Log("ERROR: " + message);
    }
    public void OnUnityAdsDidStart(string placementId){
        Debug.Log("VIDEO STARTED");
    }
    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult){
        if (placementId == "Rewarded_iOS" && showResult == ShowResult.Finished){
            Debug.Log("PLAYER SHOULD BE REWARDED");
            coinCountA = PlayerPrefs.GetInt("CoinCount");
            coinCountA = coinCountA += 25;
            PlayerPrefs.SetInt("CoinCount", coinCountA);
        }
    }
}
