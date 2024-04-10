using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    public Rigidbody2D zombieRb;
    public Transform playerTransform;
    float timer;
    int speed = 4;

    void Update()
    {
        if (playerTransform != null)
        {
            Vector2 direction = playerTransform.position - transform.position;
            zombieRb.velocity = direction.normalized * speed;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
           
                Destroy(collision.gameObject);
                
        }
    }
}