using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacles : MonoBehaviour
{
    public GameObject player;

    public Text coinText;

    public int coins;
    private float timewait = 0.05F;

    public ParticleSystem obst;
    
    public GameObject deathUI;
    public GameObject normalUI;
    public SpriteRenderer playsr;
    public Score score;
    public ScoreManager ScoreManager;

    public static int finalscore;
    public int highscore;

    [Header("Trails")]
    public GameObject trail1;
    public GameObject trail2;
    public GameObject trail3;
    public GameObject trail4;
    public GameObject trail5;
    public GameObject trail6;

    public Text scoreTextRA;
    public GameObject reviveButton;
    public Transform playertr;
    public Movement Movement;
    


    void Start()
    {
        coins = PlayerPrefs.GetInt("CoinCount");
        coinText.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("CoinCount");
    }


    public void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "obstacle")
        {
            
            Invoke("PauseTime", timewait);
            obst.Play();
            deathUI.SetActive(true);
            normalUI.SetActive(false);
            PlayerPrefs.SetInt("RecentScore", finalscore);
            playsr.enabled = false;
            
        }

        if(other.gameObject.tag == "coin")
        {
            PlayerPrefs.SetInt("CoinCount", coins = coins += 1);
            coinText.GetComponent<Text>().text = "" + PlayerPrefs.GetInt("CoinCount");
            Destroy(other.gameObject);
        }

        
    }

    void PauseTime()
    {
        Time.timeScale = 0;
    }

    void Update(){

        finalscore = score.finalscoreAmount;
        SetRecent();
        highscore = PlayerPrefs.GetInt("HighScore");

        if(finalscore > highscore)
        {
            PlayerPrefs.SetInt("HighScore", finalscore);
        }
        if (finalscore < highscore)
        {
            PlayerPrefs.GetInt("HighScore");
        }

        trail1.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5F, player.transform.position.z);
        trail2.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5F, player.transform.position.z);
        trail3.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5F, player.transform.position.z);
        trail4.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5F, player.transform.position.z);
        trail5.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5F, player.transform.position.z);
        trail6.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 0.5F, player.transform.position.z);



        if(PlayerPrefs.GetInt("SelectedTrail") == 1){
            trail1.SetActive(true);
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 2){
            trail2.SetActive(true);
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 3){
            trail3.SetActive(true);
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 4){
            trail4.SetActive(true);
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 5){
            trail5.SetActive(true);
        }
        if(PlayerPrefs.GetInt("SelectedTrail") == 6){
            trail6.SetActive(true);
        }
        if(trail1.activeInHierarchy== true){
            trail2.SetActive(false);
            trail3.SetActive(false);
            trail4.SetActive(false);
            trail5.SetActive(false);
            trail6.SetActive(false);
        }
        if(trail2.activeInHierarchy== true){
            trail1.SetActive(false);
            trail3.SetActive(false);
            trail4.SetActive(false);
            trail5.SetActive(false);
            trail6.SetActive(false);
        }
        if(trail3.activeInHierarchy== true){
            trail1.SetActive(false);
            trail2.SetActive(false);
            trail4.SetActive(false);
            trail5.SetActive(false);
            trail6.SetActive(false);
        }
        if(trail4.activeInHierarchy== true){
            trail1.SetActive(false);
            trail2.SetActive(false);
            trail3.SetActive(false);
            trail5.SetActive(false);
            trail6.SetActive(false);
        }
        if(trail5.activeInHierarchy== true){
            trail1.SetActive(false);
            trail2.SetActive(false);
            trail3.SetActive(false);
            trail4.SetActive(false);
            trail6.SetActive(false);
        }
        if(trail6.activeInHierarchy == true){
            trail1.SetActive(false);
            trail2.SetActive(false);
            trail3.SetActive(false);
            trail4.SetActive(false);
            trail5.SetActive(false);
        }

        
        if(PlayerPrefs.GetInt("REVIVEAD") == 1){
            CheckRevived();
            normalUI.SetActive(true);
            deathUI.SetActive(false);
            Time.timeScale = 1;
            scoreTextRA.text = PlayerPrefs.GetInt("RecentScore") + "";
            playsr.enabled = true;
            playertr.position = new Vector3(0 , transform.position.y, transform.position.z);
            Movement.moveLeft = false;
            Movement.moveRight = false;
            PlayerPrefs.SetInt("ALREADYREVIVED", 1);
            PlayerPrefs.SetInt("REVIVEAD", 0);
            
        }

    }

    void SetRecent()
    {
        PlayerPrefs.SetInt("RecentScore", finalscore);
    }

    void CheckRevived(){
        if(PlayerPrefs.GetInt("ALREADYREVIVED") == 1){
            reviveButton.SetActive(false);
        }else{

        }
    }

}
