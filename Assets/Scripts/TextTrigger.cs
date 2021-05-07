using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class TextTrigger : MonoBehaviour
{
    [FormerlySerializedAs("cabinetText")] public GameObject triggerText;

    private void Start()
    {
        triggerText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerText.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            triggerText.SetActive(false);
        }
    }
}
