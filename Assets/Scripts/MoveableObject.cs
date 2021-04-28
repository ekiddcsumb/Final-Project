using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public Transform pickupDestination;
    public bool isPickedUp = false;

    public List<GameObject> objectsInTrigger = new List<GameObject>();

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

    private void Update()
    {
        // if (isPickedUp)
        // {
        //     transform.position = pickupDestination.position;
        //     transform.parent = GameObject.Find("PickupDestination").transform;
        // }
        // else
        // {
        //     transform.parent = null;
        // }
        // if (Input.GetButtonDown("Interact") && !isPickedUp)
        // {
        //     Debug.Log("E has been pressed.");
        //     transform.position = pickupDestination.position;
        //     transform.parent = GameObject.Find("PickupDestination").transform;
        //     isPickedUp = true;
        // }
        //
        // if (Input.GetButtonUp("Interact") && isPickedUp)
        // {
        //     Debug.Log("E has been released.");
        //     isPickedUp = false;
        //     transform.parent = null;
        // }
    }

    private void OnTriggerEnter(Collider other)
    {
        objectsInTrigger.Add(other.gameObject);
    }

    void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space pressed");
        }
        // Debug.Log("Box is inside the trigger.");
        // Debug.Log("This is the collider: " + other.name);
        if (Input.GetButtonDown("Interact"))
        {
            Debug.Log("E has been pressed.");
            // isPickedUp = true;
            // transform.position = pickupDestination.position;
            // transform.parent = GameObject.Find("PickupDestination").transform;
            transform.parent = (other.transform == transform.parent)? null: other.transform ;
        }
        
        // if (Input.GetButtonUp("Interact") && isPickedUp)
        // {
        //     Debug.Log("E has been released.");
        //     isPickedUp = false;
        // }
        
        
    
        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     transform.position = pickupDestination.position;
        //     transform.parent = GameObject.Find("PickupDestination").transform;
        // }
    }
    
    private void OnTriggerExit(Collider other)
    {
        objectsInTrigger.Remove(other.gameObject);
        transform.parent = null;
    }
}
