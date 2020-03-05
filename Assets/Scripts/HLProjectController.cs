using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HLProjectController : MonoBehaviour
{
    private int currentTaskNum;
    private int numTasks = 8;
    private Animator anim;
    public Text taskText;
    private string[] taskStrings;
    private MeshRenderer m_ButtonHighlight;
    public void OnGaze(bool hasGaze)
    {
        m_ButtonHighlight.enabled = hasGaze;
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        currentTaskNum = 0;
        taskStrings = new string[numTasks];
        taskStrings[0] = " ";
        taskStrings[1] = "Task 1: Remove battery";
        taskStrings[2] = "Task 2: Unscrew back panel";
        taskStrings[3] = "Task 3: Remove back panel";
        taskStrings[4] = "Task 4: Insert new ram";
        taskStrings[5] = "Task 5: Put on back panel";
        taskStrings[6] = "Task 6: Screw in back panel";
        taskStrings[7] = "Task 7: Replace battery";
        taskText.text = taskStrings[currentTaskNum];
    }
    public void OnSelect()
    {
        if(gameObject.name=="Next")
        {
            NextTask();
        }
        if(gameObject.name=="Previous")
        {
            PreviousTask();
        }
    }
    void NextTask()
    {
        if (currentTaskNum >= numTasks-1)
        {
            return;
        }
        else
        {
            taskText.text = taskStrings[currentTaskNum];
            switch (currentTaskNum)
            {
                case 0:
                    Battery();
                    break;
                case 1:
                    Screws();
                    break;
                case 2:
                    Backpanel();
                    break;
                case 3:
                    RamInsertion();
                    break;
                case 4:
                    BackpanelRev();
                    break;
                case 5:
                    ScrewsRev();
                    break;
                case 6:
                    BatteryRev();
                    break;
            }
        }        
        currentTaskNum++;
    }
    void PreviousTask()
    {
        if (currentTaskNum == 0)
        {
            return;
        }
        else
        {
            taskText.text = taskStrings[currentTaskNum];
            switch (currentTaskNum)
            {
                case 0:
                    break;
                case 1:
                    BatteryRestart();
                    break;
                case 2:
                    ScrewsRestart();
                    break;
                case 3:
                    BackpanelRestart();
                    break;
                case 4:
                    RamInsertionRestart();
                    break;
                case 5:
                    BackpanelRevRestart();
                    break;
                case 6:
                    ScrewsRevRestart();
                    break;
                case 7:
                    BatteryRevStart();
                    break;
            }
        }        
        currentTaskNum--;
    }
    private void Backpanel()
    {
        anim.Play("AvatarBackPanelParent");
    }

    private void BackpanelRev()
    {
        anim.Play("AvatarBackPanelParentRev");
    }

    private void BackpanelRestart()
    {
        anim.Play("BackPanelStart");
    }

    private void BackpanelRevRestart()
    {
        anim.Play("BackPanelRevStart");
    }

    private void Walk()
    {
        anim.Play("AvatarWalkParent");
    }

    private void WalkRestart()
    {
        anim.Play("WalkStart");
    }
    private void Screws()
    {
        anim.Play("ScrewDriverBox");
    }
    private void ScrewsRev()
    {
        anim.Play("ScrewDriverBoxReverse");
    }
    private void ScrewsRestart()
    {
        anim.Play("ScrewDriverBoxStart");
    }
    private void ScrewsRevRestart()
    {
        anim.Play("ScrewDriverBoxRevStart");
    }
    private void RamInsertion()
    {
        anim.Play("Ram_insertion_box");
    }
    private void RamInsertionRestart()
    {
        anim.Play("Ram_insertion Start");
    }
    private void Battery()
    {
        anim.Play("BatteryRemove");
    }
    private void BatteryRev()
    {
        anim.Play("Batteryrev");
    }
    private void BatteryRestart()
    {
        anim.Play("BatteryRemoveStart");
    }
    private void BatteryRevStart()
    {
        anim.Play("BatteryrevStart");
    }
   
}
