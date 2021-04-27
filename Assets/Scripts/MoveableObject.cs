using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public Transform pickupDestination;
    private bool isPickedUp = false;

    // void OnMouseDown()
    // {
    //     
    // }
    //
    // void OnMouseUp()
    // {
    //     
    // }

    private void Update()
    {
        if (Input.GetButtonDown("Interact") && !isPickedUp)
        {
            Debug.Log("E has been pressed.");
            isPickedUp = true;
            transform.position = pickupDestination.position;
            transform.parent = GameObject.Find("PickupDestination").transform;
        }

        if (Input.GetButtonUp("Interact") && isPickedUp)
        {
            Debug.Log("E has been released.");
            isPickedUp = false;
            transform.parent = null;
        }
        
    }
}
