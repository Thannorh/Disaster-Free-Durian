using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    //Variables
    public float Speed = 4.0f;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = Vector2.up * Speed / 5;
    }
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Paddle")
        {
            //Calculate hit Value (aka, the x value we will need to change direction)
            float hitValue = Ricochet(transform.position, collision.transform.position, collision.collider.bounds.size.x);

            //Give the ball the direction necessary
            Vector2 Direction = new Vector2(hitValue, 1).normalized;
            GetComponent<Rigidbody2D>().velocity = Direction * Speed;
        }
        
    }

    //This function is supposed to replicate the ricochet used in Arkanoid
    float Ricochet(Vector2 Ball, Vector2 Paddle, float Position)
    {
        //this should return an exact x value that we can use to ricochet properly
        return (Ball.x - Paddle.x) / Position;
    }
}
