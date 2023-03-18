using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class VolumeToggle : MonoBehaviour
{
    [SerializeField]
    private string parameterName;

    [SerializeField]
    private Toggle audioToggle;

    [SerializeField]
    private AudioMixer audioMixer;

    public float audioDB;
    
    public bool ToggleMusic;

    public int TMI;

    void Start()
    {

        audioToggle.isOn = PlayerPrefs.GetInt(parameterName) == 1 ? true : false;
        audioMixer.GetFloat(parameterName, out audioDB);
        audioMixer.SetFloat(parameterName, audioToggle.isOn ? audioDB : -80);
        audioToggle.onValueChanged.AddListener(ToggleAudio);
    }

    private void ToggleAudio(bool isOn)
    {
        if (isOn){
            audioMixer.SetFloat(parameterName, audioDB);
            PlayerPrefs.SetInt("TMI", 1);
        }

        else{
            audioMixer.SetFloat(parameterName, -80);
            PlayerPrefs.SetInt("TMI", 0);
        }

        PlayerPrefs.SetInt(parameterName, isOn ? 1 : 0);
    }

    void Update(){
        if (PlayerPrefs.GetInt("TMI") == 1)
        {
            ToggleMusic = true;
            audioMixer.SetFloat(parameterName, audioDB);
        }
        else
        {
            ToggleMusic = false;
            audioMixer.SetFloat(parameterName, -80);
        }
        PlayerPrefs.SetInt("MusicOnOFF", PlayerPrefs.GetInt("TMI"));
        }
    }


    

