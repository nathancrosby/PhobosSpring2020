using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ345 : MonoBehaviour
{
    public void PreviousButton4()
    {
        SceneManager.LoadScene("FAQC");
    }
    public void NextButton4()
    {
        SceneManager.LoadScene("FAQE");
    }
    public void ExitButton4()
    {
        SceneManager.LoadScene("Help");
    }

}

