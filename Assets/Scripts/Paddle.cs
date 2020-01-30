/* 
 Paddle.cs
 Description: Paddle Movement
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //Variables
    public float Speed = 2.0f;
    public float MaxLeft = -4.0f;
    public float MaxRight = 4.0f;
    // Main Function for movement
    void Update()
    {
        //Check for input
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Moves the paddle Right, stops if going too far
            if (transform.position.x > MaxRight)
            {
                transform.position = new Vector3(MaxRight, transform.position.y, 0);
            }
            else
            {
                transform.position += Vector3.right * Speed;
            }
        }
        //Check for input
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //Moves the paddle left, stops if going too far
            if (transform.position.x < MaxLeft)
            {
                transform.position = new Vector3(MaxLeft, transform.position.y, 0);
            }
            else
            {
                transform.position += Vector3.left * Speed;
            }
        }
    }
}
