using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    public void RestartLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MAZE4");
    }

    public void QuitGameToMM()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
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
