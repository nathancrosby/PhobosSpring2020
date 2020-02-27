using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Terminologies : MonoBehaviour
{
    public void ExitButton()
    {
        SceneManager.LoadScene("Help");
    }
    public void Simulation()
    {
        SceneManager.LoadScene("Simulation");
    }
    public void VirtualReality()
    {
        SceneManager.LoadScene("Virtual");
    }
    public void AugmentedReality()
    {
        SceneManager.LoadScene("Augmented");
    }
    public void PHOBOS()
    {
        SceneManager.LoadScene("PHOBOS");
    }
    public void HoloLens()
    {
        SceneManager.LoadScene("Hololens");
    }
    public void Hologram()
    {
        SceneManager.LoadScene("Hologram");
    }
    public void Gestures()
    {
        SceneManager.LoadScene("Gestures");
    }
    public void Virtual()
    {
        SceneManager.LoadScene("Prototype");
    }
    public void Immersion()
    {
        SceneManager.LoadScene("Immersion");
    }
}



