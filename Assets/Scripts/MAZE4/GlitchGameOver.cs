using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitchGameOver : MonoBehaviour
{

    public GameObject gameOver;



    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Player")
        {
            if (collider.tag == "Glitch")
            {
                Time.timeScale = 0f;
                gameOver.gameObject.SetActive(true);
            }
        }
        
    }
    // Start is called before the first frame update
    void Start()
    {
        gameOver.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
