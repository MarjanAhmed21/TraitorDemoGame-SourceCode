using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level1Transition : MonoBehaviour
{
    public void Redo()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Again()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}