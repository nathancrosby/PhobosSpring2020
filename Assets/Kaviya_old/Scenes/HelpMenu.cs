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
        SceneManager.LoadScene("PlayAnimation");
    }
    public void Gestures()
    {
        SceneManager.LoadScene("Bloom");
    }
    
}

