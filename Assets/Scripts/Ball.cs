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
        GetComponent<Rigidbody2D>().AddForce(Random.insideUnitCircle.normalized * Speed * 20);
    }
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Paddle")
        {
            //Calculate hit Value
            float hitValue = Ricochet(transform.position, collision.transform.position, collision.collider.bounds.size.x);
            Vector2 Direction = new Vector2(hitValue, 1).normalized;

            //Give the ball the direction necessary
            GetComponent<Rigidbody2D>().velocity = Direction * Speed;
        }
        
    }

    //This function is supposed to replicate the ricochet used in Arkanoid
    private float Ricochet(Vector2 Ball, Vector2 Paddle, float Position)
    {
        //this should return a certain value that we can use to ricochet properly
        return (Ball.x - Paddle.x) / Position;
    }
}
