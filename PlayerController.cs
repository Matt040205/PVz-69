using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject GameOverScreen;
    public Rigidbody2D playerRb;
    int speed = 7;

    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 moveDirection = new Vector2(moveX, moveY);

        playerRb.velocity = moveDirection * speed;

    }
    void OnDestroy()
    {
        gameOverScreen.SetActive(true);
        GameOverScreen.SetActive(true);
    }
}