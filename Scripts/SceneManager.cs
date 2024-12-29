using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

    public void Autors()
    {
        Application.LoadLevel("Titles");
    }

    public void Mode()
    {
        Application.LoadLevel("Modes");
    }

    public void FreedomEzda()
    {
        Application.LoadLevel("TrackTest0");
    }

    public void AutoDemo()
    {
        Application.LoadLevel("TestDev");
    }
}
