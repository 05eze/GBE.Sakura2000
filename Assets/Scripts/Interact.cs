using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject interactCanvas;

    void OnTriggerEnter2D(Collider2D collider2D)
    {
        interactCanvas.gameObject.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collider2D)
    {
        interactCanvas.gameObject.SetActive(false);
    }



    // Start is called before the first frame update
    void Start()
    {
        interactCanvas.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
