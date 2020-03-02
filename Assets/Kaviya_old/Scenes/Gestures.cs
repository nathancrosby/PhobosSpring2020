using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gestures : MonoBehaviour
{
    public void TermButton()
    {
        SceneManager.LoadScene("Terminologies");
    }
}
