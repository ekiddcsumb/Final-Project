using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveableObject : MonoBehaviour
{
    private bool input;
    private bool isTriggered = false;

    public GameObject uiText;

    public Transform pickupDestination;

    private void Start()
    {
        uiText.SetActive(false);
    }

    private void Update()
    {
        input = Input.GetButtonDown("Interact");
        
        if (input && isTriggered)
         {
             transform.parent = (pickupDestination == transform.parent) ? null : pickupDestination ;
         }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTriggered = true;
            uiText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isTriggered = false;
        uiText.SetActive(false);
        transform.parent = null;
    }
}
