using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNivel : MonoBehaviour
{
    [SerializeField] private Puntaje puntaje;
    [SerializeField] private int puntajeCondicional;
    [SerializeField] private int nivelSiguiente;
    [SerializeField] private GameObject panelCarga;

    public void CambioDeNivel()
    {
        if (puntaje.puntajeGlobal >= puntajeCondicional)
        {
            if(panelCarga != null)
                panelCarga.SetActive(true);
            SceneManager.LoadScene(nivelSiguiente);
        }
    }

}
