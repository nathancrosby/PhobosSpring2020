using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Control : MonoBehaviour
{
    public void HelpButton()
    {
        SceneManager.LoadScene("Help");
    }
    public void Bloom()
    {
        SceneManager.LoadScene("BloomAnimation");
    }
    public void Pinch()
    {
        SceneManager.LoadScene("PinchAnimation");
    }
}
