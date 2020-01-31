using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //no matter what power up, all of them activate on collision
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(this.gameObject.tag == "LaserPower")
        {
            
        }
        else if (this.gameObject.tag == "CatchPower")
        {
            
        }
        else if (this.gameObject.tag == "BreakPower")
        {
            
        }
        else if (this.gameObject.tag == "PlayerPower")
        {
            
        }
        else if (this.gameObject.tag == "DisruptionPower")
        {

        }
        else if (this.gameObject.tag == "SlowPower")
        {
            
        }
        else if (this.gameObject.tag == "EnlargePower")
        {

        }
        Destroy(gameObject);
    }

}
