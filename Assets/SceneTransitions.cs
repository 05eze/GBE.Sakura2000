using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransitions : MonoBehaviour
{
    public GameObject gameOb;


    public void DefendTheCrown()
    {
        SceneManager.LoadScene("DTC 1");
    }

    public void Scene2()
    {
        SceneManager.LoadScene("SCENE2");
    }

    public void Scene2Minigame()
    {
        SceneManager.LoadScene("SCENE2-STREET");
    }

    public void Scene2School()
    {
        SceneManager.LoadScene("SCENE2-SCHOOL");
    }

    /*(public void Scene3()
    {
        SceneManager.LoadScene("");
    }*/

    public void No()
    {
        gameOb.gameObject.SetActive(false);
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
