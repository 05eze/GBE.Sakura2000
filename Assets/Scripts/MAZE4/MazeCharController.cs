using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeCharController : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float moveSpeed;
    public Vector2 moveInput;
    public GameObject gameOver;
    public Animator animator;

    Vector2 movement;

    public GameObject results;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Glitch")
        {
            Time.timeScale = 0f;
            gameOver.gameObject.SetActive(true);
        }
        else
        {
            if (collider.tag == "WinTrig")
            {
                Time.timeScale = 0f;
                results.gameObject.SetActive(true);
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
        moveInput.x = Input.GetAxisRaw("Horizontal");
        moveInput.y = Input.GetAxisRaw("Vertical");

        moveInput.Normalize();

        rb2d.velocity = moveInput * moveSpeed;

        animator.SetFloat("Horizontal ", moveInput.x);
        animator.SetFloat("Vertical", moveInput.y);
        animator.SetFloat("Speed", moveInput.sqrMagnitude);
    }
}
