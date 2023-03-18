using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TrailManager", menuName = "Trail Manager")]
public class TrailManager : ScriptableObject
{

    [SerializeField] public Trail[] trails;

    private const string Prefix = "Trail_";

    private const string SelectedTrail = "SelectedTrail";

    public void SelectTrail(int trailIndex){
         PlayerPrefs.SetInt(SelectedTrail, trailIndex);
         
    } 
    // Start is called before the first frame update
    public Trail GetSelectedTrail()
    {
        int trailIndex = PlayerPrefs.GetInt(SelectedTrail, 0);
        if(trailIndex >= 0 && trailIndex < trails.Length)
        {
            return trails[trailIndex];
        }
        else
        {
            return null;
        }
    }
   
    public void Unlock(int trailIndex) => PlayerPrefs.SetInt(Prefix + trailIndex, 1);

    public bool IsUnlocked(int trailIndex) => PlayerPrefs.GetInt(Prefix + trailIndex, 0) == 1;
}
