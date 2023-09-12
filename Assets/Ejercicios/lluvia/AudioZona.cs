using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioZona : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip sonidoZona;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("11111111111111111");
        audioSource.clip = sonidoZona;
        audioSource.Play();
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("222222222222222222");
        audioSource.clip = null;
        audioSource.Play();
    }


}
