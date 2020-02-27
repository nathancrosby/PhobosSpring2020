using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FAQ123 : MonoBehaviour
{
    public void PreviousButton2()
    {
        SceneManager.LoadScene("FAQA");
    }
    public void NextButton2()
    {
        SceneManager.LoadScene("FAQC");
    }
    public void ExitButton2()
    {
        SceneManager.LoadScene("Help");
    }
}
