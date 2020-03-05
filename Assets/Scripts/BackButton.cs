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
        " Hologram : It is technique in which the 
light beams from the object are
processed into a 3D - image and
 can be seen through the holographic
 frame.";
        current.SetActive(false);
        previous.SetActive(true);
    }
}
