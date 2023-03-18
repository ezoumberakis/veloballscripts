using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public GameObject SFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPrefs.GetInt("SoundOnOFF") == 1)
        {
            SFX.SetActive(true);
        }
        else
        {
            SFX.SetActive(false);
        }
    }
}
