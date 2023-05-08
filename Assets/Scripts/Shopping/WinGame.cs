using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinGame : MonoBehaviour
{
    public GameObject gameObject;
    public GameObject finalItem;
    public GameObject results;

    Rigidbody body;
    public float maxSpeed = 1.0f;

   /* private void OnDestroy()
    {
        if (Destroyed != null)
            Destroyed.Invoke();
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Shopping Cart" && gameObject.tag == "Final Item")
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            results.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            if(collision.gameObject.name == "Wrong Item Detect" && gameObject.tag == "Final Item")
            {
                Debug.Log("Game Over");
                Destroy(gameObject);
                results.gameObject.SetActive(true);
                Time.timeScale = 0f;
            }
        }
    }

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.up * Time.deltaTime * 5;
    }
}
