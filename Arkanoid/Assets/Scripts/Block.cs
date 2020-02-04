using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;
using System.Collections;



public class Block : MonoBehaviour
{
    public Transform Enlarge;

    public int whichpowerup;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        whichpowerup = Random.Range(1 , 6);

        if (whichpowerup == 1)
        {
            Instantiate (Enlarge, transform.position, Enlarge.rotation);

        }
        if (whichpowerup == 2)
        {
            Instantiate(Enlarge, transform.position, Enlarge.rotation);

        }
        if (whichpowerup == 3)
        {
            Instantiate(Enlarge, transform.position, Enlarge.rotation);

        }
        if (whichpowerup == 4)
        {
            Instantiate(Enlarge, transform.position, Enlarge.rotation);

        }
        if (whichpowerup == 5)
        {
            Instantiate(Enlarge, transform.position, Enlarge.rotation);

        }


        // Destroy the whole Block
        Destroy(gameObject);
    }
}
