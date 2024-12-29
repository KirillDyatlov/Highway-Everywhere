using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            anim.SetInteger("camera", 2);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    public void Cam()
    {
        anim.SetInteger("camera", 2);
    }
}