﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
   
    public Vector3 velocity = new Vector3(1, 1, 0);
    float speed = 2f;
    // Use this for initialization
	void Start ()
    {
        Random rand = new Random();
        GetComponent<SpriteRenderer>().color = new Color(255, 255, 255);
        velocity.Normalize();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
        transform.position += velocity * Time.deltaTime * speed;
        if (transform.position.x < -1.75f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(-1.75f, transform.position.y, 0);
        }
        if (transform.position.x > 1.75f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(1.75f, transform.position.y, 0);
        }
        if (transform.position.y > 1)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, 1, 0);
        }
        if (transform.position.y < -1)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, -1, 0);
        }
    }
}
