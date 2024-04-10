using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text texto;
    public int Pontos = 0;

    private void Update()
    {
        texto.text = "PONTOS " + Pontos;
    }
}