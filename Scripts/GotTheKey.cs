using UnityEngine;
using System.Collections;

public class GotTheKey : MonoBehaviour {
	private bool showLabel = false;
	private bool stopShowing = false;
	public GameObject isKey;
	
	public void ToggleLabel()
	{
		showLabel = false;
		stopShowing = true;
	}
	public void OnGUI()
	{
		if(showLabel){
			GUI.Label (new Rect (Screen.width/2,Screen.height/2, 100, 25), "You got the key");
		}
	}
}
