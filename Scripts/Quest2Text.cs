using UnityEngine;
using System.Collections;

public class Quest2Text : MonoBehaviour {

	public string text;
	public TextAsset textFile;
    bool display= false;
	public GameObject q2Closed;
	public GameObject document;
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
		if(display==true && q2Closed.activeSelf && document.activeSelf==false){
			GUI.Box (new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, Screen.width * 5 / 7, Screen.height * 5 / 7), text);
		}
	}
}
