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

    public void ShopTillYouDrop()
    {
        SceneManager.LoadScene("STYD2");
    }

    public void Maze9()
    {
        SceneManager.LoadScene("MAZE4");
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

    public void Scene1Bedroom()
    {
        SceneManager.LoadScene("SCENE 1-BEDROOM");
    }

    public void No()
    {
        gameOb.gameObject.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            DefendTheCrown();
        }
    }

    public void Scene2Cutscene()
    {
        SceneManager.LoadScene("SCENE 2 YOU WIN");
    }
    
    public void Scene2Classroom()
    {
        SceneManager.LoadScene("Classroom");
    }

    public void Scene2Hallway()
    {
        SceneManager.LoadScene("Hallway");
    }

    public void Scene3()
    {
        SceneManager.LoadScene("SCENE 3 STREET");
    } 
    
    
    public void Scene3Supermarket()
    {
        SceneManager.LoadScene("SCENE 3 SUPERMARKET");
    }

    public void Scene3YouWin()
    {
        SceneManager.LoadScene("SCENE 3 YOU WIN");
    }
    
    
    public void Scene3PostSTYD()
    {
        SceneManager.LoadScene("SCENE 3 LEAVE");
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
