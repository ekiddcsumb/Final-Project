using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject arm;
    public GameObject text;
    
    private void Start()
    {
        arm.gameObject.SetActive(false);
        text.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            arm.gameObject.SetActive(true);
            text.SetActive(true);
        }
        else
        {
            arm.gameObject.SetActive(false);
            text.SetActive(false);
        }
    }
}
