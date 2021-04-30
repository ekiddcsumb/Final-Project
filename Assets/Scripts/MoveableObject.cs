using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    void OnTriggerStay(Collider other)
    {
        // Debug.Log("Box is inside the trigger.");
        // Debug.Log("This is the collider: " + other.name);
        if (Input.GetButtonDown("Interact"))
        {
            transform.parent = (other.transform == transform.parent) ? null : other.transform ;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
