using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ567 : MonoBehaviour
{
    public void PreviousButton6()
    {
        SceneManager.LoadScene("FAQE");
    }
    public void NextButton6()
    {
        SceneManager.LoadScene("FAQG");
    }
    public void ExitButton6()
    {
        SceneManager.LoadScene("Help");
    }
}

