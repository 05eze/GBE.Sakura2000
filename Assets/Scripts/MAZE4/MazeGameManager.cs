using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeGameManager : MonoBehaviour
{
    public GameObject results;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            if (collider.tag == "WinTrig")
            {
                Time.timeScale = 0f;
                results.gameObject.SetActive(true);
            }
        }
    }

    public void Continue()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scene");
    }

    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
