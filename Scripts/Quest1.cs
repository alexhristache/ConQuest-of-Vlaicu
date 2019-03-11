using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Quest1 : MonoBehaviour {

	public Text myText;
	public bool displayInfo;
	public float fadeTime;
	void Start () {
		myText = GameObject.Find ("Text").GetComponent<Text> ();
		myText.color = Color.clear;
	}

	void Update () {
		FadeText ();
	}
		void OnMouseOver()
		{
			displayInfo=true;
		}
		void OnMouseExit()
		{
			displayInfo = false;
		}
		void FadeText()
		{
			if (displayInfo) {
			
			myText.color = Color.Lerp (myText.color, Color.white, fadeTime * Time.deltaTime);
			} else {
				myText.color = Color.Lerp (myText.color, Color.clear, fadeTime * Time.deltaTime);
			}
		}

	}

