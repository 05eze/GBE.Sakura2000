using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopGameManager : MonoBehaviour
{
    //public UnityEvent Destroyed;


    public GameObject heart0;
    //Live Hearts
    public GameObject heartOne;
    public GameObject heartTwo;
    public GameObject heartThree;
    public GameObject heartFour;

    //Broken Hearts
    public GameObject crackOne;
    public GameObject crackTwo;
    public GameObject crackThree;
    public GameObject crackFour;

    //Game Over
    public GameObject gameOver;

    //Live Count
    public static int health;

    //Total Items
    public GameObject totalItems;

    //Results
    public GameObject results;


    // Start is called before the first frame update
    void Start()
    {
        health = 5;
        //heartOne
        heart0.gameObject.SetActive(true);
        heartOne.gameObject.SetActive(true);
        heartTwo.gameObject.SetActive(true);
        heartThree.gameObject.SetActive(true);
        heartFour.gameObject.SetActive(true);
        gameOver.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        switch(health)
        {
            case 5:
                heart0.gameObject.SetActive(true);
                heartOne.gameObject.SetActive(true);
                heartTwo.gameObject.SetActive(true);
                heartThree.gameObject.SetActive(true);
                heartFour.gameObject.SetActive(true);
                break;
            case 4:
                heart0.gameObject.SetActive(true);
                heartOne.gameObject.SetActive(true);
                heartTwo.gameObject.SetActive(true);
                heartThree.gameObject.SetActive(true);
                heartFour.gameObject.SetActive(false);
                break;
            case 3:
                heart0.gameObject.SetActive(true);
                heartOne.gameObject.SetActive(true);
                heartTwo.gameObject.SetActive(true);
                heartThree.gameObject.SetActive(false);
                heartFour.gameObject.SetActive(false);
                break;
            case 2:
                heart0.gameObject.SetActive(true);
                heartOne.gameObject.SetActive(true);
                heartTwo.gameObject.SetActive(false);
                heartThree.gameObject.SetActive(false);
                heartFour.gameObject.SetActive(false);
                break;
            default:
                heart0.gameObject.SetActive(false);
                heartOne.gameObject.SetActive(false);
                heartTwo.gameObject.SetActive(false);
                heartThree.gameObject.SetActive(false);
                heartFour.gameObject.SetActive(false);
                gameOver.gameObject.SetActive(true);
                Time.timeScale = 0;
                break;
        }

       //In Prog
          /*  if (Destroy(totalItems))
            {
            Debug.Log("Win Game");
                results.gameObject.SetActive(true);
            }*/
        



        
    }
}
