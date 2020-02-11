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
        if (collision.gameObject.tag == "Orange Block")
        {
            score += 60;
        }
        else if (collision.gameObject.tag == "Blue Block")
        {
            score += 100;
        }
        else if (collision.gameObject.tag == "Red Block")
        {
            score += 90;
        }
        else if (collision.gameObject.tag == "Green Block")
        {
            score += 80;
        }
        else if (collision.gameObject.tag == "Pink Block")
        {
            score += 110;
        }
        else if (collision.gameObject.tag == "Big Boy Block")
        {
            score += 50;
        }
        PointRecord.text = score.ToString();

    }
}