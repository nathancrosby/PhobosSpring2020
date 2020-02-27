using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ456 : MonoBehaviour
{
    public void PreviousButton5()
    {
        SceneManager.LoadScene("FAQD");
    }
    public void NextButton5()
    {
        SceneManager.LoadScene("FAQF");
    }
    public void ExitButton5()
    {
        SceneManager.LoadScene("Help");
    }
}

