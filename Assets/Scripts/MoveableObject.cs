using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveableObject : MonoBehaviour
{
    private bool input;

    public GameObject uiText;

    private void Start()
    {
        uiText.SetActive(false);
    }

    private void FixedUpdate()
    {
         input = Input.GetButtonDown("Interact");
    }
    
    void OnTriggerStay(Collider other)
    {
        uiText.SetActive(true);
        // TODO: need to figure out pickup bug.
        // Debug.Log("Box is inside the trigger.");
        // Debug.Log("This is the collider: " + other.name);
        if (input)
        {
            transform.parent = (other.transform == transform.parent) ? null : other.transform ;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        uiText.SetActive(false);
        transform.parent = null;
    }
}
