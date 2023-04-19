using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartController : MonoBehaviour
{
    public float maxSpeed;
    Rigidbody2D cartCnt;

    // Start is called before the first frame update
    void Start()
    {
        cartCnt = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal") * maxSpeed;

        cartCnt.velocity = new Vector2(movementValueX, cartCnt.velocity.y);
    }
}
