using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{


public void RestartLevel()
{
    Time.timeScale = 1;
    ShopGameManager.health = 5;
    SceneManager.LoadScene("STYD2");
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
