using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float speed;
    public Text LivesText;
    public Text WText;
    private Rigidbody rb;

    private int lives;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        lives = 6;
        setliveText();
        WText.text = "";  
    }

    

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

       
    }

    void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Traps"))
       {

           
           transform.position = new Vector3(-10.0f, 1.5f, -17.0f);
           
          
           


           lives = lives - 1;
           rb.isKinematic = false;
           setliveText();
           Debug.Log("You have " + lives + " left!");

           if (lives == 0)
           {
               Debug.Log("Game over");
               WText.text = "Sorry, You lost!";
               rb.isKinematic = true;
           }
       }

    }

    void setliveText()
    {
        LivesText.text = "Lives: " + lives.ToString();
    }
}
