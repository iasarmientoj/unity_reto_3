using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agua : MonoBehaviour
{
    [SerializeField] private float antigravedad;

    GameObject player;

    public GameObject panelAgua;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            player = other.gameObject;
            Invoke("Antigravedad",1);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<ConstantForce>().force = new Vector3(0, 0, 0);
            panelAgua.SetActive(false);
        }
    }

    private void Antigravedad()
    {
        player.gameObject.GetComponent<ConstantForce>().force = new Vector3(0, antigravedad, 0);
        panelAgua.SetActive(true);

    }

}
