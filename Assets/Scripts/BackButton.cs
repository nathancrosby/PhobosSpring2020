using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    private MeshRenderer m_ButtonHighlight;
    public GameObject current;
    public GameObject next;
    public GameObject previous;

    public void OnGaze(bool hasGaze)
    {
        m_ButtonHighlight.enabled = hasGaze;
    }
    // Start is called before the first frame update
    public void OnSelect()
    {
        if (gameObject.name == "BloomBack")
        {
            SceneManager.LoadScene("1-Menu");
        }
        current.SetActive(false);
        previous.SetActive(true);
    }
}
