using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolumeToggleSFX : MonoBehaviour
{
    [SerializeField]
    private string parameterName;

    [SerializeField]
    private Toggle audioToggle;

    [SerializeField]
    private AudioMixer audioMixer;

    public float audioDB;

    public GameObject audioSFX;
    

    public int TSFXN;
    public bool ToggleSFX;

    
    
    private void Start()
    {

        audioToggle.isOn = PlayerPrefs.GetInt(parameterName) == 1 ? true : false;
        audioMixer.GetFloat(parameterName, out audioDB);
        audioMixer.SetFloat(parameterName, audioToggle.isOn ? audioDB : -80);
        audioToggle.onValueChanged.AddListener(ToggleAudio);
    }

    private void ToggleAudio(bool isOn)
    {
        if (isOn)
        {
            audioMixer.SetFloat(parameterName, audioDB);
            PlayerPrefs.SetInt("TSFXN", 1);
        }

        else
        {
            audioMixer.SetFloat(parameterName, -80);
            PlayerPrefs.SetInt("TSFXN", 0);
        }

        PlayerPrefs.SetInt(parameterName, isOn ? 1 : 0);
    }

    void Update(){
        if (PlayerPrefs.GetInt("TSFXN") == 1)
        {
            ToggleSFX = true;
            
        }
        else
        {
            ToggleSFX = false;
            
        }
        PlayerPrefs.SetInt("SoundOnOFF", PlayerPrefs.GetInt("TSFXN"));


        if (ToggleSFX = true && SceneManager.GetActiveScene().buildIndex == 1)
        {
            audioMixer.SetFloat(parameterName, -80);
        }
    }

}
    

