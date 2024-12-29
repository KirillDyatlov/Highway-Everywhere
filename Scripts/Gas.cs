using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gas : MonoBehaviour
{
    AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource> ();
        StartCoroutine(Work());
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            audio.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audio.Play();
        }
    }

    IEnumerator Work()
    {
        while(true)
        {
            yield return new WaitForSeconds(3.0f);
            audio.Play();
        }
    }
}
