using UnityEngine;
using System.Collections;

public class Clues : MonoBehaviour {
	private bool clueRange=false;
	private int display=0;
	public GameObject isQuest;
	public GameObject clue;
	private string questText;
	public TextAsset textFile;
    public GUISkin customSkin;
    void Start () {
		questText = textFile.text;
	}
	void Update () {
		if (clueRange == true && isQuest.activeSelf == false) {
			if (display == 0 || display == 3)
				display = 1;
			else if (Input.GetKeyDown (KeyCode.Mouse0) && display == 1)
				display = 2;
			else if (display == 2 && Input.GetKeyDown (KeyCode.Q))
				clue.SetActive(false);
		} else if (clueRange == true && isQuest.activeSelf && Input.GetKeyDown(KeyCode.Mouse0))
			display = 3;
      }
	void OnTriggerEnter(Collider inCollide)
	{
		if (inCollide.transform.name == "Player") {
			clueRange= true;
		}
	}
	void OnTriggerExit(Collider outCollide)
	{
		if (outCollide.transform.name == "Player") {
			clueRange = false;
		}
	}
    void OnGUI()
	{
        GUI.skin = customSkin;
        if (display==2)
			GUI.Box (new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, 710, 420), questText);
		//else if(display==2)
			//GUI.Box (new Rect(Screen.width/2-100, Screen.height/2,200,25), "Press 'Q' to pick");
		else if(display==3 && clueRange==true)
			GUI.Box (new Rect(Screen.width * 2 / 5, Screen.height * 2 / 5, 350,300), "You cannot pick this item yet\n\n\nFinish the current task");
	}
}
