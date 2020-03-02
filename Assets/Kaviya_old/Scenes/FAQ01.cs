using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ01 : MonoBehaviour
{
    public void FAQButton()
    {
        SceneManager.LoadScene("FAQA");
    }
    public void MainButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Terminologies()
    {
        SceneManager.LoadScene("Terminologies");
    }
    public void Control()
    {
        SceneManager.LoadScene("Control");
    }
}
