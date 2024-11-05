using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("WRLDSELECT");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void Options()
    {
        //abre UI options en menues (crear si pedido, sino sacar)
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnMenu()
    {
        SceneManager.LoadScene("STARTMENU");
    }

    public void Lvl1Select()
    {
        SceneManager.LoadScene("LVL1");
    }
}
