using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObject : MonoBehaviour
{
    public GameObject gameObject1, gameObject2, gameObject3, gameObject4;

    // Start is called before the first frame update
    void Start()
    {
        gameObject1.gameObject.SetActive(false);
        gameObject2.gameObject.SetActive(false);
        gameObject3.gameObject.SetActive(false);
        gameObject4.gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        gameObject1.gameObject.SetActive(true);
        gameObject2.gameObject.SetActive(true);
        gameObject3.gameObject.SetActive(true);
        gameObject4.gameObject.SetActive(true);
    }
}
