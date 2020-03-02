using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ234 : MonoBehaviour
{
    public void PreviousButton3()
    {
        SceneManager.LoadScene("FAQB");
    }
    public void NextButton3()
    {
        SceneManager.LoadScene("FAQD");
    }
    public void ExitButton3()
    {
        SceneManager.LoadScene("Help");
    }
}

