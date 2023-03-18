using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class coinText : MonoBehaviour
{

    public Text coinT;
    public GameObject mainUI;
    public GameObject HelpUI;
    public GameObject BoostsUI;
    public GameObject CreditsUI;
    public GameObject BackButtonUI;
    public GameObject BackPageUI;
    public GameObject NextPageUI;

    public GameObject Page1;
    public GameObject Page2;

    


    public GameObject TrailsPage1;
    
    // Start is called before the first frame update
    void Start()
    {
       // Page1.SetActive(true);
        //Page2.SetActive(false);
        BackButtonUI.SetActive(true);
        BackPageUI.SetActive(false);

        if(PlayerPrefs.GetInt("SkinOnOff") == 1){
            SkinsPage();
        }
        if(PlayerPrefs.GetInt("TrailOnOff") == 1){
            TrailsPage();
        }
    }

    // Update is called once per frame
    void Update()
    {
        coinT.text = "" + PlayerPrefs.GetInt("CoinCount");

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
            //PlayerPrefs.SetInt("CoinCount", 2000);
        //}
    }

    public void BackButton()
    {
        SceneManager.LoadScene("Menu");
    }
    public void NextPage()
    {
        Page1.SetActive(false);
        Page2.SetActive(true);
        NextPageUI.SetActive(false);
        TrailsPage1.SetActive(false);
        BackButtonUI.SetActive(false);
        BackPageUI.SetActive(true);
    }

    public void BackPage(){
        Page1.SetActive(true);
        Page2.SetActive(false);
        NextPageUI.SetActive(true);
        TrailsPage1.SetActive(false);
        BackButtonUI.SetActive(true);
        BackPageUI.SetActive(false);
    }

    public void TrailsPage(){
       TrailsPage1.SetActive(true);
       Page1.SetActive(false);
        Page2.SetActive(false);
        NextPageUI.SetActive(false);
        BackButtonUI.SetActive(true);
        BackPageUI.SetActive(false);
    }
    public void SkinsPage(){
        Page1.SetActive(true);
        Page2.SetActive(false);
        NextPageUI.SetActive(true);
        TrailsPage1.SetActive(false);
        BackButtonUI.SetActive(true);
        BackPageUI.SetActive(false);
    }
    public void Help()
    {
        mainUI.SetActive(false);
        HelpUI.SetActive(true);
    }
    public void Boosts(){
        mainUI.SetActive(false);
        HelpUI.SetActive(false);
        CreditsUI.SetActive(false);
        BoostsUI.SetActive(true);
    }
    public void Credits()
    {
        mainUI.SetActive(false);
        HelpUI.SetActive(false);
        CreditsUI.SetActive(true);
    }
    public void BackButtonCB(){
        mainUI.SetActive(false);
        HelpUI.SetActive(true);
        CreditsUI.SetActive(false);
        BoostsUI.SetActive(false);
    }
    public void BackButtonCWD(){
        mainUI.SetActive(true);
        HelpUI.SetActive(false);
        CreditsUI.SetActive(false);
        BoostsUI.SetActive(false);
        SkinsPage();
    }
}
