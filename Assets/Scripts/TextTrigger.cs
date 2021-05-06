using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTrigger : MonoBehaviour
{
    public GameObject cabinetText;

    private void Start()
    {
        cabinetText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        cabinetText.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        cabinetText.SetActive(false);
    }
}
