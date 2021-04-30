using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treat : MonoBehaviour
{
    public GameObject cat;
    public Sounds sounds;
    void OnTriggerStay(Collider other)
    {
        if (Input.GetButtonDown("Interact"))
        {
            cat.GetComponent<AudioSource>().PlayOneShot(sounds.getSounds()[5]);
            Destroy(gameObject);
            Debug.Log("You ate a treat!");
        }
    }
    
}
