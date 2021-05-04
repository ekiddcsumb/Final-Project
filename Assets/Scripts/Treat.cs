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
    
    private void Start()
    {
        pressEuiText.SetActive(false);
        treatUiText.SetActive(false);
    }
    void OnTriggerStay(Collider other)
    {
        pressEuiText.SetActive(true);
        
        if (Input.GetButtonDown("Interact"))
        {
            cat.GetComponent<AudioSource>().PlayOneShot(sounds.getSounds()[5]);
            pressEuiText.SetActive(false);
            treatUiText.SetActive(true);
            StartCoroutine("Wait");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        pressEuiText.SetActive(false);
    }

    IEnumerator Wait()
    {
        gameObject.GetComponent<MeshRenderer>().enabled = false;
        gameObject.GetComponent<CapsuleCollider>().enabled = false;
        pressEuiText.SetActive(false);
        yield return new WaitForSeconds(3);
        treatUiText.SetActive(false);
        Destroy(gameObject);
    }
}
