using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PowerUpCollision : MonoBehaviour
{
    public Material racket;
    public Material VausSpacecraftLarge;
    public GameObject Object;
    
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
        Destroy(gameObject); 
        
        if(collision.gameObject.name == "Slow")
        {
            //On ball Script
        }
        else if(collision.gameObject.name == "Enlarge")
        {
           // Object.GetComponent<MeshRenderer>().racket = VausSpacecraftLarge;
        }
        else if (collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }
        else if (collision.gameObject.name == "")
        {

        }

    }
}
