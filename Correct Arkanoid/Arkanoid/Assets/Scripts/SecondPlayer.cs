using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x == ResetPoint)
        {
           transform.position = new Vector2(ResetPosition, transform.position.y);
        }
        CheckUserInput();
    }
    public float ResetPoint = 0;
    public float ResetPosition = 0;
    public float speed = 150;
    void CheckUserInput()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.left * speed;
        }
    }
}
