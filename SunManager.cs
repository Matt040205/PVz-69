using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SunManager : MonoBehaviour
{
    public Text texto;
    public int sol = 100;

    private void Update()
    {
        texto.text = "SOL " + sol;
    }
}