using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDetector : MonoBehaviour
{
    Rigidbody body;
    public float maxSpeed = 1.0f;


    public GameObject gameObject;


    //Deleting items through collision
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Shopping Cart")
        {
            
            Destroy(gameObject);
            Debug.Log("Item Caught");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Falling item
        transform.position -= transform.up * Time.deltaTime * 5;
    }
}
