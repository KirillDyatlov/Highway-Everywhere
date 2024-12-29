using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Mechanics : MonoBehaviour
{
    AudioSource audio;
    public GameObject belt;
    float speed = 0f;

    public void Start()
    {
        audio = GetComponent<AudioSource>();
        OnGUI();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.H))
        {
            audio.Play();
        }

        if(Input.GetKeyDown(KeyCode.B))
        {
            Destroy(belt);
        }
    }

    public void Exit()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Reboot()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 250, 50), "Скорость: " + speed);
    }
}
