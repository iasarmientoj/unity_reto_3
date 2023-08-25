using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampolin : MonoBehaviour
{
    [SerializeField] private float fuerzaImpulso;
    [SerializeField] private Animator trampolinPadre;
    [SerializeField] private AudioSource audioSourceObject;
    [SerializeField] private AudioClip audioAction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(transform.up * fuerzaImpulso);
            if(trampolinPadre != null)
                trampolinPadre.Play("impulso");
            if (audioSourceObject != null && audioAction != null)
                audioSourceObject.PlayOneShot(audioAction);
        }
    }
}
