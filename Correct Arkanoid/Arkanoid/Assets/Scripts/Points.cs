using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public int score;
    public Text PointRecord;
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
        if(collision.gameObject.tag == "Yellow Block")
        {
            score += 10;
        }
        else if (collision.gameObject.tag == "Blue Block")
        {
            score += 20;
        }
        else if (collision.gameObject.tag == "Red Block")
        {
            score += 30;
        }
        PointRecord.text = score.ToString();

    }
}
