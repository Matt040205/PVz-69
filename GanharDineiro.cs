using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GanharDinero : MonoBehaviour
{
    public void GanharDinheiro()
    {
        GameObject go = GameObject.FindGameObjectWithTag("pontos");
        pontos sm = go.GetComponent<pontos>();
        sm.ponto += 100;
    }
}
