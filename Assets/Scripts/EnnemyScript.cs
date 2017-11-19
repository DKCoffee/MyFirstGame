﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyScript : MonoBehaviour {

    private Rigidbody2D body;
    [SerializeField]
    private Transform initialPosition;
    [SerializeField]
    private int direction = 1;
    [SerializeField]
    private float maxDist;
    [SerializeField]
    private float minDist;
    [SerializeField]
    private float movingSpeed;

   



    // Use this for initialization
    void Start ()
    {
        
        //initialPosition = transform.position;
        direction = -1;
        maxDist += transform.position.x;
        minDist -= transform.position.x;
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        switch (direction)
        {
            case -1:
                //Move Left
                if(transform.position.x > minDist)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(-movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                }
                else
                {
                    direction = 1;
                }
                break;
            case 1:
                //Move Right
                if(transform.position.x < maxDist)
                {
                    GetComponent<Rigidbody2D>().velocity = new Vector2(movingSpeed, GetComponent<Rigidbody2D>().velocity.y);
                }
                else
                {
                    direction = -1;
                }
                break;

                
        }
        
    }
   
}
