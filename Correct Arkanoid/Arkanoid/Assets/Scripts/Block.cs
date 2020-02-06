using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Block : MonoBehaviour
{
    public GameObject Enlarge;
    public GameObject Laser;
    public GameObject Duplicate;
    public GameObject Catch;
    public GameObject Slow;
    public GameObject Player;

    public int whichpowerup;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {

        whichpowerup = Random.Range(1 , 11);
        if (Enlarge != null)
        {
            if (whichpowerup == 1)
            {
                Instantiate(Enlarge, transform.position, Enlarge.transform.rotation);

            }
            if (whichpowerup == 2)
            {
                Instantiate(Laser, transform.position, Laser.transform.rotation);

            }
            if (whichpowerup == 3)
            {
                Instantiate(Duplicate, transform.position, Duplicate.transform.rotation);

            }
            if (whichpowerup == 4)
            {
                Instantiate(Catch, transform.position, Catch.transform.rotation);

            }
            if (whichpowerup == 5)
            {
                Instantiate(Slow, transform.position, Slow.transform.rotation);

            }
            if (whichpowerup == 6)
            {
                Instantiate(Player, transform.position, Player.transform.rotation);

            }

        }


        // Destroy the whole Block
        Destroy(gameObject);
    }
}
