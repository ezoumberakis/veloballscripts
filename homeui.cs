using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class homeui : MonoBehaviour
{
    public void HomeUIToggle(){
        SceneManager.LoadScene("Menu");
    }
    public void SettingsUIToggle(){
        SceneManager.LoadScene("Menu");
        PlayerPrefs.SetInt("SUIT", 1);
    }
}
