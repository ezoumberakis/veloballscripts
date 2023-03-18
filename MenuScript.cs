using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{


    public GameObject mainUI;
    public GameObject SettingsUI;
    public GameObject HelpUI;
    

    public GameObject backButton;
    public GameObject SettingsButton;

    public GameObject CreditsUI;
    public GameObject BoostsUI;


    void Update() {
        if(PlayerPrefs.GetInt("SUIT")==1){
            Settings();
            PlayerPrefs.DeleteKey("SUIT");
        }
    }

    private void Start()
    {
        
        mainUI.SetActive(true);
        SettingsUI.SetActive(false);
        HelpUI.SetActive(false);
        backButton.SetActive(false);

        PlayerPrefs.DeleteKey("SkinOnOff");
        PlayerPrefs.DeleteKey("TrailOnOff");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("VeloBall");
    }
    public void Help()
    {
        mainUI.SetActive(false);
        HelpUI.SetActive(true);
    }
    public void Settings()
    {
        mainUI.SetActive(true);
        SettingsUI.SetActive(true);
        SettingsButton.SetActive(false);
        backButton.SetActive(true);

    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }
    public void BackButton()
    {
        mainUI.SetActive(true);
        SettingsButton.SetActive(true);
        SettingsUI.SetActive(false);
        HelpUI.SetActive(false);
    }

    public void CreditsScene()
    {
        mainUI.SetActive(false);
        HelpUI.SetActive(false);
        CreditsUI.SetActive(true);
    }
    public void BackButtonC()
    {
        mainUI.SetActive(false);
        SettingsButton.SetActive(false);
        SettingsUI.SetActive(false);
        HelpUI.SetActive(true);
        CreditsUI.SetActive(false);
        BoostsUI.SetActive(false);
    }
    public void SkinShop(){
        PlayerPrefs.SetInt("SkinOnOff", 1);
        SceneManager.LoadScene("Shop");
    }
    public void TrailShop(){
        PlayerPrefs.SetInt("TrailOnOff", 1);
        SceneManager.LoadScene("Shop");
    }

    public void Boosts(){
        mainUI.SetActive(false);
        HelpUI.SetActive(false);
        CreditsUI.SetActive(false);
        BoostsUI.SetActive(true);
    }
    
}
