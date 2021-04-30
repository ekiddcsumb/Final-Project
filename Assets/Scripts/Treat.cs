using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treat : MonoBehaviour
{
    public GameObject cat;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Interact"))
        {
            Debug.Log("E was pressed");
            Destroy(gameObject);
            
        }
    }
    
}
