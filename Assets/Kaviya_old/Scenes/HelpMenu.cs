using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HelpMenu : MonoBehaviour
{
    public void Helpbutton()
    {
        SceneManager.LoadScene("Help");
    }
    public void Simulation()
    {
        SceneManager.LoadScene("Test2");
    }
    public void Gestures()
    {
        SceneManager.LoadScene("Test5");
    }
    
}

