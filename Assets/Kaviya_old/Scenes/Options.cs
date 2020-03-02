using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public Dropdown myDropdown;
    private void Start()
    {
        this.GetComponent<Dropdown>().captionText.text = "Select Term";
    }
    public void nameinserter()
    {
        List<string> names = new List<string> { "SIMULATION", "VIRTUAL REALITY", "AUGMENTED REALITY", "HOLOLENS", "ZERO GRAVITY" };
        this.GetComponent<Dropdown>().AddOptions(names);
    }
   
    public void ExitButton()
    {
        SceneManager.LoadScene("Help");
    }
   // void Update()
   // {
     //   switch (myDropdown.value)
       // {
         //   case "SIMULATION":
           //     SceneManager.LoadScene("SimulationDef");
             //   break;
        //}
    //}
}
