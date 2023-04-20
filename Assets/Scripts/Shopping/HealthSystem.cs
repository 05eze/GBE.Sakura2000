using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    //Item Objects
    public GameObject gameObject;

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
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag == "Item")
        {
            Destroy(gameObject);
            //SetActive == false one of the hearts after(then adtewr make sure last heart becomes trig for you lose screen)
            //SetActive.heartOne == false;
            //SetActive.crackOne == true;
        }//else
        //if(collider.tag == "")
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
