using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveableObject : MonoBehaviour
{
    public Transform pickupDestination;

    void OnMouseDown()
    {
        transform.position = pickupDestination.position;
        transform.parent = GameObject.Find("PickupDestination").transform;
    }

    void OnMouseUp()
    {
        transform.parent = null;
    }
}
