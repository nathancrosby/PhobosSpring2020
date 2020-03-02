using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ670 : MonoBehaviour
{
    public void PreviousButton7()
    {
        SceneManager.LoadScene("FAQF");
    }
    public void NextButton7()
    {
        SceneManager.LoadScene("FAQFG");
    }
    public void ExitButton7()
    {
        SceneManager.LoadScene("Help");
    }
}
