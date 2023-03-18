using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class VolumeSFX : MonoBehaviour
{
   
    public GameObject audioSFX;

    public GameObject GameOverCanvasGO;

    public GameObject PauseCanvasGO;
    public GameObject NormalCanvasGO;


    [SerializeField]
    private AudioMixer audioMixer;

    private float audioDB;

    [SerializeField]
    private string parameterName;




    public GameObject NormalUI;
    public GameObject PauseUI;
    void Update()
    {
        if(PlayerPrefs.GetInt("SoundOnOFF") == 1)
        {
            audioSFX.SetActive(true);
            audioMixer.SetFloat(parameterName, audioDB);

            if (GameOverCanvasGO.activeInHierarchy == true)
            {
                audioSFX.SetActive(false);
            }
            else
            {
                audioSFX.SetActive(true);
            }

            if (PauseCanvasGO.activeInHierarchy == true)
            {
                audioSFX.SetActive(false);
            }
            else
            {
                audioSFX.SetActive(true);
            }
            if (NormalCanvasGO.activeInHierarchy == true)
            {
                audioSFX.SetActive(true);
            }
            else
            {
                audioSFX.SetActive(false);
            }

            
        }

        if(PlayerPrefs.GetInt("SoundOnOFF") == 0)
        {
            audioSFX.SetActive(false);
            audioMixer.SetFloat(parameterName, -80);
        }

        
    }

    public void Resume()
    {
        Time.timeScale = 1F;
        PauseUI.SetActive(false);
        NormalUI.SetActive(true);
        audioSFX.SetActive(true);
    }
}
