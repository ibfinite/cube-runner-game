using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000;
    public float sidewaysForce = 600;
    public float upwardsForce = 1000;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //makes cube move forward
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        //move cube left and right
        if(Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //jump
        //if(Input.GetKey(KeyCode.Space))
        //{
        //    rb.AddForce(0, upwardsForce * Time.deltaTime, 0);
        //}

        //to end game if player falls off
        if (rb.position.y < -2)
        {
            FindObjectOfType<LogicScript>().GameOver();
        }
    }
}
