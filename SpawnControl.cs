using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject meteorPrefab;
    float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            Instantiate(meteorPrefab, new Vector3(Random.Range(-6.5f,6.5f), 6, 0), Quaternion.identity);
            timer = 0;
            
        }
    }
}
