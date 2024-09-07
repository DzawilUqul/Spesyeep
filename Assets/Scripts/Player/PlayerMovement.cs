using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementInputDirection;
    
    private Rigidbody2D rb;

    public float movementSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();


        /*
        // Create movement for spaceship to move left and right
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * 5);
        } else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * 5);
        }
        */
    }

    private void FixedUpdate()
    {
        ApplyMovement();
    }

    private void CheckInput()
    {
        movementInputDirection = Input.GetAxisRaw("Horizontal");
    }

    private void ApplyMovement()
    {
        rb.velocity = new Vector2(movementSpeed * movementInputDirection * Time.deltaTime, rb.velocity.y);
    }
}
