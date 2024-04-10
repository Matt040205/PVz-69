using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerT;
    public Transform cameraT;

    void Update()
    {
        if (playerT != null)
        {
            cameraT.position = new Vector3(playerT.position.x, playerT.position.y, -10);
        }
    }
}