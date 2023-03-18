using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrailSelecter : MonoBehaviour
{

    [SerializeField] public Image SelctedImageT;

    [SerializeField] public Color myColor1;
    [SerializeField] public Color myColor2;
    [SerializeField] public Color myColor3;
    [SerializeField] public Color myColor4;
    [SerializeField] public Color myColor5;
    [SerializeField] public Color myColor6;
    
    // Start is called before the first frame update
    void Start()
    {
       myColor1.a = 1;
       myColor2.a = 1;
       myColor3.a = 1;
       myColor4.a = 1;
       myColor5.a = 1;
       myColor6.a = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetInt("SelectedTrail") == 1){
            SelctedImageT.color = myColor1;
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 2){
            SelctedImageT.color = myColor2;
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 3){
            SelctedImageT.color = myColor3;
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 4){
            SelctedImageT.color = myColor4;
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 5){
            SelctedImageT.color = myColor5;
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 6){
            SelctedImageT.color = myColor6;
        }
    }
}
