using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public float distance;
    public LayerMask layerMask;

    public Transform pickupDestination;
    
    // void Update()
    // {
    //     RaycastHit interactableObjectInfo;
    //     Ray ray = new Ray(transform.position, Vector3.forward);
    //     
    //     if (Physics.Raycast(ray, out interactableObjectInfo, distance, layerMask))
    //     {
    //         interactableObjectInfo.collider.transform.position = pickupDestination.position;
    //         interactableObjectInfo.collider.transform.parent = GameObject.Find("PickupDestination").transform;
    //         // if (interactableObjectInfo.collider.CompareTag("MoveableObject"))
    //         // {
    //         //     Debug.Log(interactableObjectInfo.collider.name + " is in front of ray.");
    //         //     interactableObjectInfo.collider.transform.position = pickupDestination.position;
    //         //     interactableObjectInfo.collider.transform.parent = GameObject.Find("PickupDestination").transform;
    //         // }
    //     }
    // }
    
    
}
