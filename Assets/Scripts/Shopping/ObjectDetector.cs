using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{

    public Animator animator;

    Rigidbody body;
    public float maxSpeed = 1.0f;

    //Item 
    public GameObject gameObject;

    //public void SetActive(bool true);

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

    public GameObject finalItem;

    public GameObject results;

    //Deleting items through collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        

        if (collision.gameObject.name == "Shopping Cart")
        {
            Destroy(gameObject);
            //In prog
            
            Debug.Log("Item Caught");
            animator.SetBool("isOpen", false);

        } 
        else
        if(collision.gameObject.name == "Wrong Item Detect")
        {
            Destroy(gameObject);
            Debug.Log("Live Lost");

            animator.SetBool("isHit", true);

            ShopGameManager.health -= 1;
            //heartOne.SetActive(false);
           // crackOne.SetActive(true);

        }
        else
        if(collision.gameObject.name == "Shopping Cart" && gameObject.tag == "Final Item")
        {
            animator.SetBool("isHit", true);
            Debug.Log("Game Over");
            Destroy(gameObject);
            results.gameObject.SetActive(true);
        }
        
        
        /* (crackOne.activeInHierarchy && !heartOne.activeInHierarchy)
        {
            if (collision.gameObject.name == "Wrong Item Detect ")
            {
                heartTwo.SetActive(false);
                crackTwo.SetActive(true);
            }
        }*/
    }
    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("isOpen", false);
    }

    // Update is called once per frame
    void Update()
    {
        //Falling item
        transform.position -= transform.up * Time.deltaTime * 5;
    }
}
