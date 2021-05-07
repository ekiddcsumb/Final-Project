using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treat : MonoBehaviour
{
    public GameObject cat;
    public Sounds sounds;
    
    public GameObject pressEuiText;
    public GameObject treatUiText;
    
    private bool input;
    private bool isTriggered = false;
    
    private void Start()
    {
        pressEuiText.SetActive(false);
        treatUiText.SetActive(false);
    }
    
    private void Update()
    {
        input = Input.GetButtonDown("Interact");
        
        if (input && isTriggered)
        {
            cat.GetComponent<AudioSource>().PlayOneShot(sounds.getSounds()[5]);
            pressEuiText.SetActive(false);
            treatUiText.SetActive(true);
            StartCoroutine("Wait");
        }
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isTriggered = true;
            pressEuiText.SetActive(true);
        }
    }
    // void OnTriggerStay(Collider other)
    // {
    //     Debug.Log("in trigger");
    //     pressEuiText.SetActive(true);
    //     
    //     if (Input.GetButtonDown("Interact"))
    //     {
    //         cat.GetComponent<AudioSource>().PlayOneShot(sounds.getSounds()[5]);
    //         pressEuiText.SetActive(false);
    //         treatUiText.SetActive(true);
    //         StartCoroutine("Wait");
    //     }
    // }

    private void OnTriggerExit(Collider other)
    {
        pressEuiText.SetActive(false);
        isTriggered = false;
    }

    IEnumerator Wait()
    {
        isTriggered = false;
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        pressEuiText.SetActive(false);
        yield return new WaitForSeconds(3);
        treatUiText.SetActive(false);
        Destroy(gameObject);
    }
}
