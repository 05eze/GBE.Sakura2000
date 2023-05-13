using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float maxSpeed;
    Rigidbody2D player;
    public Animator animator;
    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float movementValueX = Input.GetAxis("Horizontal") * maxSpeed;
        
        player.velocity = new Vector2(movementValueX, player.velocity.y);
       
        movement.x = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
}
