
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    private MeshRenderer m_ButtonHighlight;

    private
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OnGaze(bool hasGaze)
    {
        m_ButtonHighlight.enabled = hasGaze;
    }

    public void OnSelect()
    {
        
        if (gameObject.name == "Watch")
        {
            SceneManager.LoadScene("Test2");
        }
        if (gameObject.name == "Act")
        {
            SceneManager.LoadScene("Test5");
        }
        if (gameObject.name=="Bloom")
        {
            SceneManager.LoadScene("BloomAnimation");
        }
        if (gameObject.name == "Pinch")
        {
            SceneManager.LoadScene("PinchAnimation");
        }

    }
}

