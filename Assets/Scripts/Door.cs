 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator door;

    private void OnTriggerEnter(Collider other)
    {
        door.Play("Door-open");
    }


    private void OnTriggerExit(Collider other)
    {
        door.Play("Door-close");

    }

}
