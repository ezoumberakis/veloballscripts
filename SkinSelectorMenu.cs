using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkinSelectorMenu : MonoBehaviour
{

    [SerializeField] private SkinManager skinManager;

    public Image skinImage;
    // Start is called before the first frame update
    void Start()
    {
        skinImage.sprite = skinManager.GetSelectedSkin().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}