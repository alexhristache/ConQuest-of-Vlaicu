using UnityEngine;
using System.Collections;

public class Quest1Shortcut : MonoBehaviour {
	string questText;
	public TextAsset beginTexts;
	public TextAsset quest1Text;
	public TextAsset quest2Text;
	public TextAsset quest2Finish;
    public TextAsset quest4Text;
    public TextAsset quest3Text;
	public GameObject beginQuests;
	public GameObject quest1;
	public GameObject quest2;
	public GameObject quest3;
    public GameObject umbrella;
    public GameObject stick;
	public GameObject allfound;
    public GUISkin customSkin;
    void OnGUI()
	{
        GUI.skin = customSkin;
        GUI.Label (new Rect(10, 10,100, 20), ("Current quest:"));
        if (beginQuests.activeSelf)
        {
            questText = beginTexts.text;
            GUI.Label(new Rect(10, 20, 400, 20), questText);
        }
        else
                if (quest1.activeSelf)
        {
            questText = quest1Text.text;
            GUI.Label(new Rect(10, 20, 300, 50), questText);
        }
        else if (quest2.activeSelf && allfound.activeSelf)
        {
            questText = quest2Text.text;
            GUI.Label(new Rect(10, 20, 300, 50), questText);
        }
        else if (quest2.activeSelf && allfound.activeSelf == false)
        {
            questText = quest2Finish.text;
            GUI.Label(new Rect(10, 20, 300, 50), questText);
        }
        else if (quest2.activeSelf && quest3.activeSelf)
        {
            questText = quest3Text.text;
            GUI.Label(new Rect(10, 20, 300, 50), questText);
        }
        else if (stick.activeSelf == false && quest3.activeSelf && Quest3Text.usedStick == false)
        {
            questText = quest4Text.text;
            GUI.Label(new Rect(10, 20, 300, 50), questText);
        }
        else if (quest3.activeSelf && Quest3Text.usedStick == true  && umbrella.activeSelf == true)
            GUI.Label(new Rect(10, 20, 300, 50), "Look for an umbrella");
        else if (umbrella.activeSelf == false)
            GUI.Label(new Rect(10, 20, 300, 50), "Find the key to the exit door and leave the school");
    }
}

