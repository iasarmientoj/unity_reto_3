using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip sonido;
    [SerializeField] private GameObject particulas;

    public void CogerCristal()
    {
        if (audioSource != null && sonido != null)
            audioSource.PlayOneShot(sonido);

        Instantiate(particulas, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}
