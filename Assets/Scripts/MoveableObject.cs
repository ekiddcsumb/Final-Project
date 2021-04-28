using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    // public Transform pickupDestination;

    // public List<GameObject> objectsInTrigger = new List<GameObject>();

    // void OnMouseDown()
    // {
    //     transform.position = pickupDestination.position;
    //     transform.parent = GameObject.Find("PickupDestination").transform;
    // }
    //
    // void OnMouseUp()
    // {
    //     transform.parent = null;
    // }
    
    // private void OnTriggerEnter(Collider other)
    // {
    //     objectsInTrigger.Add(other.gameObject);
    // }

    void OnTriggerStay(Collider other)
    {
        // Debug.Log("Box is inside the trigger.");
        // Debug.Log("This is the collider: " + other.name);
        if (Input.GetButtonDown("Interact"))
        {
            transform.parent = (other.transform == transform.parent) ? null : other.transform ;
        }
    }
}
