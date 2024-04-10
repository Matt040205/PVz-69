using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieKill : MonoBehaviour
{
    float timer;

    void OnColliderEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            timer += Time.deltaTime;

            if (timer >= 1)
            {
                Destroy(collision.gameObject);
                timer = 0;
            }
        }
    }
}