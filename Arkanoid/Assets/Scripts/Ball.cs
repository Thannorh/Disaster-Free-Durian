using System.Collections;
using System.Collections.Generic;
using UnityEngine;




        
    // Start is called before the first frame update
    public class Ball : MonoBehaviour
    {
        float hitFactor(Vector2 ballPos, Vector2 racketPos,
            float racketWidth)
        {
            // ascii art:
            //
            // 1  -0.5  0  0.5   1  <- x value
            // ===================  <- racket
            //
            return (ballPos.x - racketPos.x) / racketWidth;
        }
        // Movement Speed
        public float speed = 100.0f;
    

    // Use this for initialization
    void Start()
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * speed;
        }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        



        if (collision.gameObject.name == "racket")
        {
            float x = hitFactor(transform.position,
                            collision.transform.position,
                            collision.collider.bounds.size.x);


        }


    }


}

