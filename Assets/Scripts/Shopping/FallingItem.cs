using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItem : MonoBehaviour
{

    Rigidbody body;
    public float maxSpeed = 1.0f;



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {/*
        if (body.velocity.y < maxSpeed)
        {
            body.velocity = new Vector2(body.velocity.x, maxSpeed);
        }*/

        transform.position -= transform.up * Time.deltaTime * 5;
    }
}
