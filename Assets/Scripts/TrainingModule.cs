using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrainingModule : MonoBehaviour
{
    private int currentTaskNum;
    private int numTasks = 8;
    public Text taskText;
    private Animator anima;

    // Start is called before the first frame update
    private void Start()
    {
        anima = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        taskText.text = "Task 1: Remove battery";
        Battery1();
        taskText.text = "Task 2: Unscrew back panel";
        Screws1();
        taskText.text = "Task 3: Remove back panel";
        Backpanel1();
        taskText.text = "Task 4: Insert new ram";
        RamInsertion1();
        taskText.text = "Task 5: Put on back panel";
        BackpanelRev1();
        taskText.text = "Task 6: Screw in back panel";
        ScrewsRev1();
        taskText.text = "Task 7: Replace battery";
        BatteryRev1();
    }
           
   private void Backpanel1()
    {
        anima.Play("AvatarBackPanelParent");
    }

    private void BackpanelRev1()
    {
        anima.Play("AvatarBackPanelParentRev");
    }

    private void BackpanelRestart1()
    {
        anima.Play("BackPanelStart");
        //anima.Play("AvatarBackPanelParent");
    }

    private void BackpanelRevRestart1()
    {
        anima.Play("BackPanelRevStart");
    }

    private void Walk1()
    {
        anima.Play("AvatarWalkParent");
    }

    private void WalkRestart1()
    {
        anima.Play("WalkStart");
        //anima.Play("AvatarWalkParent");
    }
    private void Screws1()
    {
        anima.Play("ScrewDriverBox");
    }
    private void ScrewsRev1()
    {
        anima.Play("Screwdriver reverse animaation");
    }
    private void ScrewsRestart1()
    {
        anima.Play("ScrewDriverBoxStart");
        //anima.Play("Screwdriver animaation");
    }
    private void ScrewsRevRestart1()
    {
        anima.Play("Screwdriver reverse start");
        //anima.Play("Screwdriver animaation");
    }
    private void RamInsertion1()
    {
        anima.Play("Ram_insertion_box");
    }
    private void RamInsertionRestart1()
    {
        anima.Play("Ram_insertion Start");
    }
    private void Battery1()
    {
        anima.Play("BatteryRemove");
    }
    private void BatteryRev1()
    {
        anima.Play("Batteryrev");
    }
    private void BatteryRestart1()
    {
        anima.Play("BatteryRemoveStart");
    }
    private void BatteryRevStart1()
    {
        anima.Play("BatteryrevStart");
    }
   
}
