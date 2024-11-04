using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("WRLDSELECT");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        //abre UI options en menues
    }

    public void Resetart()
    {
        //restartea el lvl en el que esta el jugador (desconosco el como podria hacerse)
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("STARTMENU");
    }
}
