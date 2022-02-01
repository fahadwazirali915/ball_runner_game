﻿using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate(){
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if( Input.GetKey("d") || Input.GetKey("6") ){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if( Input.GetKey("a") || Input.GetKey("4")  ){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y < -1f){
            FindObjectOfType<GameManager>().endGame();
        }

    }

}