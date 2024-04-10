using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public Rigidbody2D bulletRb;
    int speed = 10;
    void Start()
    {
        bulletRb.velocity = transform.up * speed;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Destroy(collision.gameObject);
                GameObject go = GameObject.FindGameObjectWithTag("ScoreManager");
                ScoreManager sm = go.GetComponent<ScoreManager>();
                sm.pontos += 100;
            }
        }
    }
}