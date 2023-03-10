using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject talkPanel;
    public Text talkText;
    public GameObject scanObject;
    public bool isAction;

    public void Action(GameObject scanObj)
    {
        if(isAction)//exit action
        {
            isAction = false;
        }
        else//enter action
        {
            isAction = true;
            talkPanel.SetActive(true);
            scanObject = scanObj;
            talkText.text = "이것의 이름은" + scanObject.name + "이라고 한다.";
        }

        talkPanel.SetActive(isAction);
    }
}
