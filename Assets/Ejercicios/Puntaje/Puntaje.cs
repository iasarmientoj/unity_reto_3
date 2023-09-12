using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    [SerializeField] private int puntajeGlobal;
    [SerializeField] private TextMeshProUGUI textoPuntaje;

    private void Start()
    {
        textoPuntaje.text = puntajeGlobal.ToString();
    }


    public void SumarPuntaje()
    {
        puntajeGlobal++;
        textoPuntaje.text = puntajeGlobal.ToString();
    }
    public void RestarPuntaje()
    {
        puntajeGlobal--;
        textoPuntaje.text = puntajeGlobal.ToString();
    }



}
