using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpeed : MonoBehaviour
{
    public float modifier = 1000000; //int to mutiply the speed of the ball
    public GameObject pickupEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            Debug.Log("Powerup collected");
            Pickup(collision);
        }
    }

    public void Pickup(Collider2D ball)
    {   //spawn an effect
        //Instantiate(pickupEffect, transform.position, transform.rotation);
        
        Ball theBall = ball.GetComponent<Ball>();//apply an affect to the player
        theBall.rb.velocity = new Vector2(theBall.rb.velocity.x * modifier, theBall.rb.velocity.y * modifier);

        Destroy(gameObject); //remove the powerup
        Debug.Log("Powerup collected");
    }
}