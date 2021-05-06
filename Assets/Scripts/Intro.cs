using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    public GameObject introText;
    void Start()
    {
        introText.SetActive(true);
        StartCoroutine("Wait");
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        introText.SetActive(false);
    }
}
