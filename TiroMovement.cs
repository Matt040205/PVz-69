using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroMovement : MonoBehaviour
{
    public Rigidbody2D bulletRb;
    int speed = 10;
    public int Pontos;
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
                GameObject go = GameObject.FindGameObjectWithTag("ScoreCounter");
                ScoreCounter sm = go.GetComponent<ScoreCounter>();
                sm.Pontos += 100;
            }
        }
    }
}