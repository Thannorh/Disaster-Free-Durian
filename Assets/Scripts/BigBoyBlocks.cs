using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigBoyBlocks : MonoBehaviour
{

    //Keep track of how many times the block was hit
    public int Blockhit = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Blockhit == 4)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Blockhit++;
    }
}
