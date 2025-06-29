using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WrongTransit : MonoBehaviour
{
    public void Wrongen()
    {
        SceneManager.LoadScene("Wrong1");
    }

    public void Woohoo()
    {
        SceneManager.LoadScene("RightWoohoo");
    }
}