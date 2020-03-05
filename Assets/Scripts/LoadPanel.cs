using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPanel : MonoBehaviour
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
        previous.SetActive(false);
        next.SetActive(true);        
    }
}
