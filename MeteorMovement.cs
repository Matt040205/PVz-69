using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public Rigidbody2D meteorRb;
    int speed = 5;
    void Start()
    {
        meteorRb.velocity = Vector2.down * speed;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (gameObject.transform.position.y < -6)
        {
            Destroy(gameObject);
        }
    }
   
}
