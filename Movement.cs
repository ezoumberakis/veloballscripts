using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    public bool moveLeft;
    public bool moveRight;

    private float horizontalMove;

    public float speed;

    public GameObject fastSFX;

    
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        moveLeft = false;
        moveRight = false;

        
    }

    public void PointerDownLeft(){
        moveLeft = true;
    }

    public void PointerUpLeft(){
        moveLeft = false;
    }

    public void PointerDownRight(){
        moveRight = true;
    }

    public void PointerUpRight(){
        moveRight = false;
    }

    // Update is called once per frame
    void Update()
    {
        BMovement();
    }
    private void BMovement(){
        if(moveLeft){
            horizontalMove = -speed;
        }
        else if(moveRight){
            horizontalMove = speed;
        }else{
            horizontalMove = 0;
        }
    }

    private void FixedUpdate() {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    private float cameraNormSize = 7.5F;
    private float slowsubtract = 0.5F;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "speedboost")
        {
            speed = speed + Random.Range(1, 4);
            Destroy(collision.gameObject);
            Invoke("SetSpeedNorm", Random.Range(5, 10));
            
        }

        if (collision.gameObject.tag == "slowboost")
        {
            speed = speed - Random.Range(slowsubtract, 1);
            Destroy(collision.gameObject);
            Invoke("SetSpeedNorm", Random.Range(5, 10));
        }
        if(collision.gameObject.tag == "speedboostult")
        {
            speed = speed + Random.Range(2, 8);
            Destroy(collision.gameObject);
            Invoke("SetSpeedNorm", Random.Range(5, 15));
            fastSFX.SetActive(true);
           Camera.main.orthographicSize = 10;
        }

        if (collision.gameObject.tag == "slowboostult")
        {
            speed = speed - Random.Range(slowsubtract, 2);
            Destroy(collision.gameObject);
            Invoke("SetSpeedNorm", Random.Range(1, 4));
            Camera.main.orthographicSize = 3;
        }
    }
    
    void SetSpeedNorm()
    {
        speed = 3;
        fastSFX.SetActive(false);
        Camera.main.orthographicSize = cameraNormSize;
    }
 }
