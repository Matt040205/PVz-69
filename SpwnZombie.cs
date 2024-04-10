using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZombie : MonoBehaviour
{
    public GameObject zombiePrefab;
    public Transform[] spawnPoints;
    public Transform playerTransform;
    float timer;
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 1 && playerTransform != null)
        {
            Vector3 randomPos = spawnPoints[Random.Range(0, 6)].position;

            GameObject zombie = Instantiate(zombiePrefab, randomPos, Quaternion.identity);
            zombie.GetComponent<ZombieMovement>().playerTransform = playerTransform;

            timer = 0;
        }

    }
}