using UnityEngine;
using System.Collections;

public class Quest1Text : MonoBehaviour {

	private string text;
	public TextAsset textFile;
	bool display= false;
	public GameObject beginQuest;
	public GameObject q1Closed;
    public GUISkin customSkin;

    void Start () {
		text = textFile.text;
	}

	void Update () {
	
	}
	void OnTriggerEnter(Collider inCollide)
	{
		if (inCollide.transform.name == "Player") {
			display = true;
			beginQuest.SetActive (false);
		}
	}
	void OnTriggerExit(Collider outCollide)
	{
		if (outCollide.transform.name == "Player") {
			display = false;
		}
	}
	void OnGUI()
	{
        GUI.skin = customSkin;
        if (display==true && q1Closed.activeSelf){
			GUI.Box (new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, 680, 325), text);
		}
	}
}
