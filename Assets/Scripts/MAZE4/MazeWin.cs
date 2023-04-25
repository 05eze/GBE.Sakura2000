using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeWin : MonoBehaviour
{
    public GameObject results;
    

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            if (collider.tag == "WinTrig")
            {
                Time.timeScale = 0f;
                results.gameObject.SetActive(true);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        results.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
