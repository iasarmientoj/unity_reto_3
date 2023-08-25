using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    [SerializeField] private Animator puertaPadre;
    [SerializeField] private GameObject panelAvisoLetraE;
    [SerializeField] private bool interactivo;
    private bool permitirAbrir;
    [SerializeField] private AudioSource audioSourceDoor;
    [SerializeField] private AudioClip audioOpen;
    [SerializeField] private AudioClip audioClose;


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                permitirAbrir = true;
                if (panelAvisoLetraE != null)
                    panelAvisoLetraE.SetActive(false);
                if (permitirAbrir)
                {
                    puertaPadre.Play("open");
                    if (audioSourceDoor != null && audioClose != null && audioOpen != null)
                        audioSourceDoor.PlayOneShot(audioOpen);
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (interactivo)
            {
                if (panelAvisoLetraE != null)
                    panelAvisoLetraE.SetActive(true);

            }
            else
            {
                puertaPadre.Play("open");
                if (audioSourceDoor != null && audioClose != null && audioOpen != null)
                    audioSourceDoor.PlayOneShot(audioOpen);
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (interactivo)
            {
                if (permitirAbrir)
                {
                    puertaPadre.Play("close");
                    if (audioSourceDoor != null && audioClose != null && audioOpen != null)
                        audioSourceDoor.PlayOneShot(audioClose);
                    permitirAbrir = false;
                }
                if (panelAvisoLetraE != null)
                    panelAvisoLetraE.SetActive(false);
            }
            else
            {
                puertaPadre.Play("close");
                if (audioSourceDoor != null && audioClose != null && audioOpen != null)
                    audioSourceDoor.PlayOneShot(audioClose);
            }
        }
    }
}
