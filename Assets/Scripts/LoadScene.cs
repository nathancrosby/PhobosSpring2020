using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public MeshRenderer m_ButtonHighlight;
    public GameObject scenename;

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
        //Debug.Log("OnSelect() called on: " + gameObject.name);
        SceneManager.LoadScene(scenename);
    }
}

