using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSpeed : MonoBehaviour
{


    public GameObject stopSpeed;
    public Transform player;
    public Rigidbody2D rb;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "StopSpeed")
        {
            Instantiate(stopSpeed, new Vector3(0, player.position.y - 10, 0), transform.rotation);
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tag == "stopSpeedBar")
        {
            Invoke("DestroyBar", 3);
            Camera.main.orthographicSize = 7.5F;

        }

        if(collision.gameObject.tag == "GravSlow")
        {
            rb.gravityScale = 0.001F;
            Invoke("GravSlowBack", 10);
            Destroy(collision.gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "stopSpeedBar")
        {
            Invoke("DestroyBars", 3);
        }
    }

    void DestroyBars()
    {
        Destroy(GameObject.Find("stopspeedbar(Clone)"));
        Destroy(GameObject.Find("stopspeedbar(Clone)"));
    }

    public void GravSlowBack(){
        rb.gravityScale = 0.1F;
    }

}
