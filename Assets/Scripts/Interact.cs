using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    // public float distance;
    // public LayerMask layermask;
    //
    // private bool input;
    //
    // void Update()
    // {
    //     input = Input.GetButtonDown("Interact");
    //     
    //     RaycastHit hitInfo;
    //     Ray ray = new Ray(transform.position, Vector3.up);
    //
    //     if (Physics.Raycast(ray, out hitInfo, distance, layermask))
    //     {
    //         if (hitInfo.collider.tag == "Treat" || hitInfo.collider.tag == "MoveableObject")
    //             Debug.Log("ray hit " + hitInfo.collider.name);
    //         {
    //             if (input)
    //             {
    //                 hitInfo.collider.transform.parent = (transform == transform.parent) ? 
    //                     null : transform ;
    //             }
    //         }
    //     }
    // }
}
