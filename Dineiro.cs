using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pontos : MonoBehaviour
{
    public Text texto;
    public int ponto = 0;

    private void Update()
    {
        texto.text = "Dineiro " + ponto;
    }
}