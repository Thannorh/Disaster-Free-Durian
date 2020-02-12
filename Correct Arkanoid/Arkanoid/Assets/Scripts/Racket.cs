using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racket : MonoBehaviour
{
    public float ResetPoint = 0;
    public float ResetPosition = 0;
    public float speed = 150;
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        //if (transform.position.x == ResetPoint)
        //{
        //    transform.position = new Vector2(ResetPosition, transform.position.y);
        //}
    }
    //private void Update()
    //{
    //    if (transform.position.x == ResetPoint)
    //    {
    //        transform.position = new Vector2(ResetPosition, transform.position.y);
    //    }
    //}
}
