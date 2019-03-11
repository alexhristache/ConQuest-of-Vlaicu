using UnityEngine;
using System.Collections;

public class BeginQuest : MonoBehaviour {

    private string text;
    public TextAsset textFile;
    bool display = false;
    public GameObject isBegin;
    public GUISkin customSkin;

    void Start()
    {
        text = textFile.text;
    }

    void Update()
    {

    }
    void OnTriggerEnter(Collider inCollide)
    {
        if (inCollide.transform.name == "Player")
        {
            display = true;
        }
    }
    void OnTriggerExit(Collider outCollide)
    {
        if (outCollide.transform.name == "Player")
        {
            display = false;
        }
    }
    void OnGUI()
    {
        GUI.skin = customSkin;

        if (display == true && isBegin.activeSelf)
        {
            GUI.Box(new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, 750, Screen.height*5/7), text);
        }
    }
}
