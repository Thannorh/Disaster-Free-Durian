using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public string NextScene;
    public int EndCounter = 0;
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
        if(collision.gameObject.tag == "Red Block" || collision.gameObject.tag == "Blue Block" || collision.gameObject.tag == "Yellow Block")
        {
            EndCounter++;
        } 

        if(EndCounter == 39)
        {
            SceneManager.LoadScene(NextScene, LoadSceneMode.Single);
        }
    }
}
