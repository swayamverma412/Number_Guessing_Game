using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startscene : MonoBehaviour
{
    public void startMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void playagain()
    {
      SceneManager.LoadScene(1);

    }
    public void correctbutton()
    {
       SceneManager.LoadScene(2);

    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
