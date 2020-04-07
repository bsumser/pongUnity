using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    public bool isPlayer1; //distinguishes between player 1 and 2
    public float speed; //speed of player movement
    public Rigidbody2D rb; //reference to the rigid body
    public Vector3 startPosition;

    public float movement; //determine if moving up or down

    void Start()
    {
        startPosition = transform.position;
    }
    void Update()
    {
        if (isPlayer1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else 
        {
            movement = Input.GetAxisRaw("Vertical2");
        } 
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
