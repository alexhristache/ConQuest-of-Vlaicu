using UnityEngine;
using System.Collections;

public class Quest3Text : MonoBehaviour
{

    public static bool usedStick = false;
    public string text;
    public TextAsset textFile;
    public static bool display = false;
    public GameObject q2Closed;
    public GameObject USB;
    public GUISkin customSkin;
    void Start()
    {
        text = textFile.text;
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
            Item.isUsed = false;
        }
    }
    void OnGUI()
    {
        GUI.skin = customSkin;
        if (display == true && q2Closed.activeSelf && USB.activeSelf == false && Item.isUsed==true)
        {
            GUI.Box(new Rect(Screen.width * 1 / 5, Screen.height * 1 / 5, Screen.width * 5 / 7, Screen.height * 5 / 7), text);
            usedStick = true;
        }
    }
}
