using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text texto;
    public int pontos = 0;

    private void Update()
    {
        texto.text = "PONTOS " + pontos;
    }
}