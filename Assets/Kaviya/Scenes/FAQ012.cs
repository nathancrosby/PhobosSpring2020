using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ012 : MonoBehaviour
{
    public void PreviousButton1()
    {
        SceneManager.LoadScene("FAQA");
    }
    public void NextButton1()
    {
        SceneManager.LoadScene("FAQB");
    }
    public void ExitButton1()
    {
        SceneManager.LoadScene("Help");
    }
}
