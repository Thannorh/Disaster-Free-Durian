﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject); 
        if(collision.gameObject.name == "Slow")
        {

        }
        else if(collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }

    }
}