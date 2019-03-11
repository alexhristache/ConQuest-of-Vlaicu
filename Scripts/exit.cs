using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour {

    public GameObject key;
    private bool isRange=false,show=false;
    public string text;
    public TextAsset textFile;
    public GUISkin customSkin;
    void Start()
    {
        text = textFile.text;
    }
    void Update () {
        if (key.activeSelf == false && isRange)
            show = true;
           
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
            isRange = true;
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player")
            isRange = false;
    }
    void OnGUI()
    {
        GUI.skin = customSkin;
        if (show == true && isRange)
            GUI.Box(new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, Screen.width * 5 / 7, Screen.height * 5 / 7), text);
    }
}
